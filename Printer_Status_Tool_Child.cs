using Newtonsoft.Json;
using SnmpSharpNet;
using System.Net;
using System.Xml.Linq;


namespace Printer_Status_Tool_MDI
{
    public partial class Printer_Status_Tool_Child : Form
    {
        public string IPb;
        public string mmanu;
        public string frname = "Meow DEF";
        public Dictionary<string, List<string>> snmpData;
        public double K_Toner_Level, K_Toner_Max, K_Toner_Cur, C_Toner_Level, C_Toner_Max, C_Toner_Cur, M_Toner_Level,
                   M_Toner_Max, M_Toner_Cur, Y_Toner_Level, Y_Toner_Max, Y_Toner_Cur, Print_Page_Count, Copy_Page_Count = 0;
        bool isNamed = false;
        dynamic Global_config;
        public Printer_Status_Tool_Child(string IP, string manu, string fname, Dictionary<string, List<string>> ssnmpData, dynamic config)
        {
            InitializeComponent();
            IPb = IP; // i don't know why i have to do this but i do
            mmanu = manu;
            frname = fname;
            snmpData = ssnmpData;
            Global_config = config;
        }
        void timer_Tick(object sender, EventArgs e)
        {
            Pdu Printer_SNMP = GetSnmpData(IPb, mmanu, snmpData, Global_config);
            K_Toner_Max = ConvertFromString(Printer_SNMP.VbList[1].Value.ToString());
            K_Toner_Cur = ConvertFromString(Printer_SNMP.VbList[2].Value.ToString());
            K_Toner_Level = (K_Toner_Cur / K_Toner_Max * 100);
            K_Toner.Value = Convert.ToInt32(K_Toner_Level);
            K_Toner_TXT.Text = "Black: " + Convert.ToInt32(K_Toner_Level).ToString() + "%";
            C_Toner_Max = ConvertFromString(Printer_SNMP.VbList[3].Value.ToString());
            C_Toner_Cur = ConvertFromString(Printer_SNMP.VbList[4].Value.ToString());
            C_Toner_Level = (C_Toner_Cur / C_Toner_Max * 100);
            C_Toner.Value = Convert.ToInt32(C_Toner_Level);
            C_Toner_TXT.Text = "Cyan: " + Convert.ToInt32(C_Toner_Level).ToString() + "%";
            M_Toner_Max = ConvertFromString(Printer_SNMP.VbList[5].Value.ToString());
            M_Toner_Cur = ConvertFromString(Printer_SNMP.VbList[6].Value.ToString());
            M_Toner_Level = (M_Toner_Cur / M_Toner_Max * 100);
            M_Toner.Value = Convert.ToInt32(M_Toner_Level);
            M_Toner_TXT.Text = "Magenta: " + Convert.ToInt32(M_Toner_Level).ToString() + "%";
            Y_Toner_Max = ConvertFromString(Printer_SNMP.VbList[7].Value.ToString());
            Y_Toner_Cur = ConvertFromString(Printer_SNMP.VbList[8].Value.ToString());
            Y_Toner_Level = (Y_Toner_Cur / Y_Toner_Max * 100);
            Y_Toner.Value = Convert.ToInt32(Y_Toner_Level);
            Y_Toner_TXT.Text = "Yellow: " + Convert.ToInt32(Y_Toner_Level).ToString() + "%";
            Print_Page_Count = ConvertFromString(Printer_SNMP.VbList[9].Value.ToString());
            Copy_Page_Count = ConvertFromString(Printer_SNMP.VbList[10].Value.ToString());
            Total_Page_Count.Text = "Page Count: " + (Print_Page_Count + Copy_Page_Count);
            Printer_Status.Text = "Printer Status: " + Printer_SNMP.VbList[11].Value.ToString();
            Paper_Tray_MP.Text = "MP Tray: " + Printer_SNMP.VbList[12].Value.ToString();
            Paper_Tray_1.Text = "Tray 1 (A4): " + Printer_SNMP.VbList[13].Value.ToString();
            Paper_Tray_2.Text = "Tray 2 (A3): " + Printer_SNMP.VbList[14].Value.ToString();
            Paper_Tray_3.Text = "Tray 3 (A4): " + Printer_SNMP.VbList[15].Value.ToString();
            Paper_Tray_4.Text = "Tray 4 (A4): " + Printer_SNMP.VbList[16].Value.ToString();
            Paper_Tray_5.Text = "Tray 5: " + Printer_SNMP.VbList[17].Value.ToString();
            Paper_Tray_6.Text = "Tray 6: " + Printer_SNMP.VbList[18].Value.ToString();
            Paper_Tray_7.Text = "Tray 7: " + Printer_SNMP.VbList[19].Value.ToString();
            Paper_Tray_8.Text = "Tray 8: " + Printer_SNMP.VbList[20].Value.ToString();
            Paper_Tray_9.Text = "Tray 9): " + Printer_SNMP.VbList[21].Value.ToString();
            sys_sn.Text = "SN: " + Printer_SNMP.VbList[0].Value.ToString();
            sys_ip.Text = "IP: " + IPb;

            if (Global_config.ShowIP == "true")
            {
                sys_ip.Text = "IP: " + IPb;
            }
            else { 
                sys_ip.Hide();
            }
            if ((!isNamed))
            {
                if (frname.Contains("SNL"))
                {
                    var result = Convert.ToInt32(frname.Substring(frname.Length - 1));
                    string printer_sn = (Printer_SNMP.VbList[0].Value.ToString()).Substring(Printer_SNMP.VbList[0].Value.ToString().Length - result);
                    frname = frname.Replace(result.ToString(), "");
                    Useful_Name.Text = frname.Replace("SNL", printer_sn);
                }
                else if (frname.Contains("SNF"))
                {
                    var result = Convert.ToInt32(frname.Substring(frname.Length - 1));
                    string printer_sn = (Printer_SNMP.VbList[0].Value.ToString()).Substring(0, result);
                    frname = frname.Replace(result.ToString(), "");
                    Useful_Name.Text = frname.Replace("SNF", printer_sn);
                }
                else if (frname.Contains("SNA"))
                {
                    string printer_sn = (Printer_SNMP.VbList[0].Value.ToString());
                    Useful_Name.Text = frname.Replace("SNA", printer_sn);
                }
                else
                {
                    Useful_Name.Text = frname;
                }
                isNamed = true;
                if (Printer_SNMP.VbList[12].Value.ToString().Contains("SNMP"))
                {
                    Paper_Tray_MP.Hide();
                }
                if (Printer_SNMP.VbList[14].Value.ToString().Contains("SNMP"))
                {
                    Paper_Tray_2.Hide();
                    Paper_Tray_MP.Location = new Point(66, 193);
                }
                else
                {
                    Paper_Tray_MP.Location = new Point(169, 193);
                }
                if (Printer_SNMP.VbList[15].Value.ToString().Contains("SNMP"))
                {
                    Paper_Tray_3.Hide();
                }
                if (Printer_SNMP.VbList[16].Value.ToString().Contains("SNMP"))
                {
                    Paper_Tray_4.Hide();
                }
                if (Printer_SNMP.VbList[17].Value.ToString().Contains("SNMP"))
                {
                    Paper_Tray_5.Hide();
                }
                if (Printer_SNMP.VbList[18].Value.ToString().Contains("SNMP"))
                {
                    Paper_Tray_6.Hide();
                }
                if (Printer_SNMP.VbList[19].Value.ToString().Contains("SNMP"))
                {
                    Paper_Tray_7.Hide();
                }
                if (Printer_SNMP.VbList[20].Value.ToString().Contains("SNMP"))
                {
                    Paper_Tray_8.Hide();
                }
                if (Printer_SNMP.VbList[21].Value.ToString().Contains("SNMP"))
                {
                    Paper_Tray_9.Hide();
                }
            }
            System_Last_Update_Time.Text = "Last Update Time: " + DateTime.Now.ToString("HH:mm:ss");
        }
        public static Pdu GetSnmpData(string ipAddress, string manu, Dictionary<string, List<string>> snmpData, dynamic Global_config)
        {
            OctetString community = new OctetString(Global_config.SNMPCommunityString.ToString());
            AgentParameters param = new AgentParameters(community);
            param.Version = SnmpVersion.Ver2;
            IpAddress agent = new IpAddress(ipAddress);
            UdpTarget target = new UdpTarget((IPAddress)agent, 161, 2000, 1);
            Pdu pdu = new Pdu(PduType.Get);
            pdu.VbList.Add(snmpData[manu][0].ToString()); // SNMP SN 22
            pdu.VbList.Add(snmpData[manu][1].ToString()); // SNMP Black Total 1.3.6.1.2.1.43.11.1.1.8.1.4
            pdu.VbList.Add(snmpData[manu][2].ToString()); // SNMP Black Remaining 1.3.6.1.2.1.43.11.1.1.9.1.4
            pdu.VbList.Add(snmpData[manu][3].ToString()); // SNMP Cyan Total 1.3.6.1.2.1.43.11.1.1.8.1.2
            pdu.VbList.Add(snmpData[manu][4].ToString()); // SNMP Cyan Remaining 1.3.6.1.2.1.43.11.1.1.9.1.2
            pdu.VbList.Add(snmpData[manu][5].ToString()); // SNMP Magenta Total 1.3.6.1.2.1.43.11.1.1.8.1.3
            pdu.VbList.Add(snmpData[manu][6].ToString()); // SNMP Magenta Remaining 1.3.6.1.2.1.43.11.1.1.9.1.3
            pdu.VbList.Add(snmpData[manu][7].ToString()); // SNMP Yellow Total 1.3.6.1.2.1.43.11.1.1.8.1.4
            pdu.VbList.Add(snmpData[manu][8].ToString()); // SNMP Yellow Remaining 1.3.6.1.2.1.43.11.1.1.9.1.4
            pdu.VbList.Add(snmpData[manu][9].ToString()); // SNMP Total Page Count (Print) 1.3.6.1.4.1.1347.42.3.1.1.1.1.1
            pdu.VbList.Add(snmpData[manu][0].ToString()); // SNMP Total Page Count (Copy) 1.3.6.1.4.1.1347.42.3.1.1.1.1.2
            pdu.VbList.Add(snmpData[manu][11].ToString()); // SNMP Status (Sleep, printing, etc.) 1.3.6.1.2.1.43.16.5.1.2.1.1
            pdu.VbList.Add(snmpData[manu][12].ToString()); // SNMP MP Tray Count //Array 
            pdu.VbList.Add(snmpData[manu][13].ToString()); // SNMP Tray 1 Count 
            pdu.VbList.Add(snmpData[manu][14].ToString()); // SNMP Tray 2 Count 
            pdu.VbList.Add(snmpData[manu][15].ToString()); // SNMP Tray 3 Count 
            pdu.VbList.Add(snmpData[manu][16].ToString()); // SNMP Tray 4 Count 
            pdu.VbList.Add(snmpData[manu][17].ToString()); // SNMP Tray 5 Count 
            pdu.VbList.Add(snmpData[manu][18].ToString()); // SNMP Tray 6 Count 
            pdu.VbList.Add(snmpData[manu][19].ToString()); // SNMP Tray 7 Count 
            pdu.VbList.Add(snmpData[manu][20].ToString()); // SNMP Tray 8 Count 
            pdu.VbList.Add(snmpData[manu][21].ToString()); // SNMP Tray 9 Count 
            SnmpV2Packet result = (SnmpV2Packet)target.Request(pdu, param);
            return result.Pdu;
        }
        private double ConvertFromString(string value)
        {
            double NewValue = 0;
            try
            {
                NewValue = Convert.ToInt64(value);
                return NewValue;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        private void K_Toner_Click(object sender, EventArgs e)
        {

        }
        public void Printer_Status_Tool_Child_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = Global_config.RefreshTimer; // specify interval time as you want
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
