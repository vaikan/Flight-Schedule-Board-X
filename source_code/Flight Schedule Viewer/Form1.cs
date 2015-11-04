using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.FlightSimulator.SimConnect;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Web;

namespace Flight_Schedule_Viewer
{
    public partial class mainForm : Form
    {
        
        // initializing a index for datagridview2
        int temprowindex;

        //connecting to the database
        public static string MyConString = "SERVER=localhost;" + "DATABASE=fsxdb;" + "UID=root;" + "PASSWORD=;";
        MySqlConnection con = new MySqlConnection(MyConString);
        
        
        // Declare a SimConnect object 
        SimConnect simconnect = null;
        
        // User-defined win32 event
        const int WM_USER_SIMCONNECT = 0x0402;

        //add definations structures and data requests
        enum DEFINITIONS
        {
            Struct1,
        }

        enum DATA_REQUESTS
        {
            REQUEST_1,            
        };

        // declare a data structure so that simconnect knows how to fill it/read it.
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        struct Struct1
        {
            // declare a fixed size for string variables
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
            public String flightnumber;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
            public String ToAirport;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
            public String FromAirport;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public String aicurstatus;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public String atcid;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public String atcairline;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
            public String curairport;

            public int eta;
            public int etd;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public String parking;
        };

        public mainForm()
        {
            InitializeComponent();
        }

        //ReceiveMessage must be called to trigger the events. 
        protected override void DefWndProc(ref Message m)
        {
            try
            {
                if (m.Msg == WM_USER_SIMCONNECT)
                {
                    if (simconnect != null)
                    {
                        simconnect.ReceiveMessage();
                    }
                }
                else
                {
                    base.DefWndProc(ref m);
                    
                }
            }
            catch (COMException)
            {
                // clears all system log messages and shows new messages
                lstSystemLog.Items.Clear();
                lstSystemLog1.Items.Clear();
                lstSystemLog.Items.Add(DateTime.Now + "  " +"Flight Simulator has been closed");
                lstSystemLog1.Items.Add(DateTime.Now + "  " +"Flight Simulator has been closed");
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            string currentdate = DateTime.Now.ToShortDateString();    //to add current date
            string currenttime = DateTime.Now.ToShortTimeString();    //to add current time  
            lbDateDisplay.Text = currentdate;
            lbTimeDisplay.Text = currenttime;
                      
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            //connect to flight simulator
            try
            {
                simconnect = new SimConnect("Managed Data Request", this.Handle, WM_USER_SIMCONNECT, null, 0);
                btConnectStatus.BackColor = Color.Green;
                btConnectStatus.Text = "Connected";
                btConnectStatus.ForeColor = Color.White;
                btConnect.Enabled = false;
                btDisconnect.Enabled = true;
                lstSystemLog1.Items.Clear();
                lstSystemLog1.Items.Add(DateTime.Now + "  " +"Connected to Microsoft Flight Simulator X");
                initDataRequest();
            }

            catch (COMException)
            {
                lstSystemLog1.Items.Clear();
                lstSystemLog1.Items.Add(DateTime.Now + "  "+"Connection could not be established.");
                lstSystemLog1.Items.Add(DateTime.Now + "  " +"Please ensure that Flight Simulator X is open.");
            }
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            //for disconnecting from the Flight Simulator
            simconnect.Dispose();
            simconnect = null;
            btConnectStatus.BackColor = Color.Red;
            btConnectStatus.Text = "Disconnected";
            btConnectStatus.ForeColor = Color.White;
            btDisconnect.Enabled = false;
            btConnect.Enabled = true;
            lstSystemLog1.Items.Clear();
            lstSystemLog1.Items.Add(DateTime.Now + "  " + "Disconnected with the Flight Simulator X.");
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //this section is used for searching the airline operation in the airport using a search keyword
            
            string searchtext = tbSearch.Text;  
            MySqlDataAdapter DA = new MySqlDataAdapter();
            DataTable table = new DataTable();
            if (rbAirlinesOperated.Checked && searchtext != null) 
            {
                table.Rows.Clear();
                con.Open();
                string sql = "select Distinct AirlineName from flightplan, airport, airline where flightplan.AirlineID = airline.AirlineID and flightplan.FromAirport = airport.AirportID and flightplan.FromAirport =" + "'" + searchtext + "'";
                DA.SelectCommand = new MySqlCommand(sql, con);
                DA.Fill(table);
                if (table.Rows.Count>0)
                {
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = table;
                    dataGridView2.DataSource = bSource;
                    con.Close();
                    lbAirlineOperatedHidden.Text = searchtext.ToUpper();
                }
                else
                {
                    lstSystemLog.Items.Clear();
                    lstSystemLog.Items.Add(DateTime.Now + "  " +"No Match Found for the search keyword");
                    con.Close();
                }
                
            }

            //this section is used for searching the airline's flight schedules in the airport using a search keyword
            else if (rbFlightSchedule.Checked && searchtext != null)
            {
                
                table.Rows.Clear();
                con.Open();
                string sql1 = "select AirlineName, FlightNo, FromAirport, ToAirport, DepartureTime, ArrivalTime, AircraftName from flightplan, airport, airline, aircraft where flightplan.AirlineID = airline.AirlineID and flightplan.AircraftID = aircraft.AircraftID and flightplan.FromAirport = airport.AirportID and airline.AirlineName =" + "'" + searchtext + "'";
                DA.SelectCommand = new MySqlCommand(sql1, con);
                DA.Fill(table);
                if (table.Rows.Count > 0)
                {
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = table;
                    dataGridView1.DataSource = bSource;
                    con.Close();
                    lbFlightScheduleHidden.Text = searchtext.ToUpper();
                }
                else
                {
                    lstSystemLog.Items.Clear();
                    lstSystemLog.Items.Add(DateTime.Now + "  " + "No Match Found for the search keyword");
                    con.Close();
                }
            }

            else
            {
                lstSystemLog.Items.Add(DateTime.Now + "  " + "No search keyword entered or no checkbox selected");
                
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            temprowindex = e.RowIndex; //gets a temporary row index for the data grid view
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //code for viewing flight schedule by clicking on the airlines name in the grid view

            MySqlDataAdapter DA = new MySqlDataAdapter();
            DataTable table = new DataTable();
            table.Rows.Clear();
            con.Open();
            string sql1 = "select AirlineName, FlightNo, FromAirport, ToAirport, DepartureTime, ArrivalTime, AircraftName from flightplan, airport, airline, aircraft where flightplan.AirlineID = airline.AirlineID and flightplan.AircraftID = aircraft.AircraftID and flightplan.FromAirport = airport.AirportID and airline.AirlineName =" + "'" + dataGridView2.Rows[temprowindex].Cells[0].Value.ToString() + "'";
            DA.SelectCommand = new MySqlCommand(sql1, con);
            DA.Fill(table);
            if (table.Rows.Count > 0)
            {
                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;
                dataGridView1.DataSource = bSource;
                con.Close();
            }           
        }
        
        // Set up all the SimConnect related data definitions and event handlers
        private void initDataRequest()
        {
            try
            {
                // listen to connect and quit msgs
                simconnect.OnRecvQuit += new SimConnect.RecvQuitEventHandler(simconnect_OnRecvQuit);

                // listen to other unexpected exceptions
                simconnect.OnRecvException += new SimConnect.RecvExceptionEventHandler(simconnect_OnRecvException);

                // define data structures
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "ATC FLIGHT NUMBER", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "AI TRAFFIC TOAIRPORT", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "AI TRAFFIC FROMAIRPORT", null, SIMCONNECT_DATATYPE.STRING8, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "AI TRAFFIC STATE", null, SIMCONNECT_DATATYPE.STRING32, 0.01f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "ATC Id", null, SIMCONNECT_DATATYPE.STRING32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "ATC Airline", null, SIMCONNECT_DATATYPE.STRING32, 0.0f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "AI TRAFFIC ETA", "seconds", SIMCONNECT_DATATYPE.INT32, 0.01f, SimConnect.SIMCONNECT_UNUSED);
                simconnect.AddToDataDefinition(DEFINITIONS.Struct1, "AI TRAFFIC ETD", "seconds", SIMCONNECT_DATATYPE.INT32, 0.01f, SimConnect.SIMCONNECT_UNUSED);
                
                // register defination structs with the simconnect managed wrapper marshaller
                simconnect.RegisterDataDefineStruct<Struct1>(DEFINITIONS.Struct1);
                
                // catch a simobject data request
                simconnect.OnRecvSimobjectDataBytype += new SimConnect.RecvSimobjectDataBytypeEventHandler(simconnect_OnRecvSimobjectDataBytype);
            }
            //catch any exceptions and show message.
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // when the user closes FSX
        void simconnect_OnRecvQuit(SimConnect sender, SIMCONNECT_RECV data)
        {
            lstSystemLog1.Items.Clear();
            lstSystemLog1.Items.Add(DateTime.Now+"  "+ "FSX has exited");
            simconnect.Dispose();
            simconnect = null;
            btConnectStatus.BackColor = Color.Red;
            btConnectStatus.Text = "Disconnected";
            btConnectStatus.ForeColor = Color.White;
            btDisconnect.Enabled = false;
            btConnect.Enabled = true;
        }

        void simconnect_OnRecvException(SimConnect sender, SIMCONNECT_RECV_EXCEPTION data)
        {
            lstSystemLog1.Items.Clear();
            lstSystemLog.Items.Clear();
            lstSystemLog.Items.Add(DateTime.Now + "  " + "Exception received: " + data.dwException);
            lstSystemLog1.Items.Add(DateTime.Now + "  " + "Exception received: " + data.dwException);
        }
        
        void simconnect_OnRecvSimobjectDataBytype(SimConnect sender, SIMCONNECT_RECV_SIMOBJECT_DATA_BYTYPE data)
        {
            switch ((DATA_REQUESTS)data.dwRequestID)
            {
                case DATA_REQUESTS.REQUEST_1:
                    Struct1 s1 = (Struct1)data.dwData[0];       //arrange all data from "Struct1" in a array
                   
                    gridFlightViewer.ColumnCount = 7;           //define column number needed in the datagridview
                    
                    //add name to each of the columns
                    gridFlightViewer.Columns[0].Name = "Flight No:";
                    gridFlightViewer.Columns[1].Name = "Aircraft ID";
                    gridFlightViewer.Columns[2].Name = "Airline";
                    gridFlightViewer.Columns[3].Name = "From Airport";
                    gridFlightViewer.Columns[4].Name = "To Airport";
                    gridFlightViewer.Columns[5].Name = "Departure Time";
                    gridFlightViewer.Columns[6].Name = "Flight Status";
                    
                    //exclude user aircraft and its data 
                    if (s1.etd !=0 && s1.eta !=0)
                    {
                        TimeSpan arr = TimeSpan.FromSeconds(s1.eta);
                        
                        string arrs = string.Format("{0:D2}h:{1:D2}m:{2:D2}s",
                                                arr.Hours,
                                                arr.Minutes,
                                                arr.Seconds);

                        TimeSpan dept = TimeSpan.FromSeconds(s1.etd);
                        
                        string depts = string.Format("{0:D2}h:{1:D2}m:{2:D2}s",
                                                dept.Hours,
                                                dept.Minutes,
                                                dept.Seconds);
                        
                        //change all AI Statuses to make it understandable by the user.
                        if (s1.aicurstatus == "sleep")
                        {
                            s1.aicurstatus = "At Gate";
                        }
                        else if (s1.aicurstatus == "preflight support")
                        {
                            s1.aicurstatus = "Boarding";
                        }
                        else if (s1.aicurstatus == "Push back 1" || s1.aicurstatus == "Push back 2" || s1.aicurstatus == "clearance")
                        {
                            s1.aicurstatus = "Final Check";
                        }
                        else if (s1.aicurstatus == "pre taxi out" || s1.aicurstatus == "taxi out")
                        {
                            s1.aicurstatus = "Taxiing";
                        }
                        else if (s1.aicurstatus == "takeoff 1" || s1.aicurstatus == "takeoff 2")
                        {
                            s1.aicurstatus = "Departed";
                        }
                        else if (s1.aicurstatus == "enroute")
                        {
                            s1.aicurstatus = "Enroute";
                        }
                        else if (s1.aicurstatus == "landing")
                        {
                            s1.aicurstatus = "Landing";
                        }
                        else if (s1.aicurstatus == "go around")
                        {
                            s1.aicurstatus = "Delayed";
                        }
                        else if (s1.aicurstatus == "postflight support")
                        {
                            s1.aicurstatus="Post Flight Check";
                        }

                        //create new string and add all data in that string in a row
                        string[] row = new string[] { s1.flightnumber, s1.atcid, s1.atcairline, s1.FromAirport, s1.ToAirport, depts, s1.aicurstatus};
                        gridFlightViewer.Rows.Add(row); //adds all data to the datagridview
                        
                    }
                    break;
                    
                default:

                    lstSystemLog1.Items.Clear();
                    lstSystemLog1.Items.Add(DateTime.Now + "  " + "Unknown request ID: " + data.dwRequestID);    
                    break;
            }
        }

        private void btReqData_Click(object sender, EventArgs e)
        {
            // The following call returns information to: Sim Object Type - aircraft and Facility List - Airport
            try
            {
                if (simconnect != null)
                {
                    gridFlightViewer.Rows.Clear();
                    simconnect.RequestDataOnSimObjectType(DATA_REQUESTS.REQUEST_1, DEFINITIONS.Struct1, 6000, SIMCONNECT_SIMOBJECT_TYPE.AIRCRAFT);
                }

                else
                {
                    lstSystemLog1.Items.Clear();
                    lstSystemLog1.Items.Add(DateTime.Now + "  " + "Flight Simulator not connected. Please Connect FSX first");
                }
            }
            catch (COMException)
            {
                MessageBox.Show(DateTime.Now + "  " + "Please connect to Flight Simulator X");
            }
            
        }
   }
}
