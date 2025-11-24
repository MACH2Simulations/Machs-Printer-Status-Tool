using Newtonsoft.Json;
//MVP 24 11 25 With GH Auto CDI
namespace Printer_Status_Tool_MDI
{
    public partial class Printer_Status_Tool_Parent : Form
    {
        public Printer_Status_Tool_Parent()
        {
            InitializeComponent();
        }
        public int x,y = 0;
        public string json, jsonc = "";
        string workingDirectory = Directory.GetCurrentDirectory();
        public List<Printer_Status_Tool_Child> Printerss = new List<Printer_Status_Tool_Child>();
        private void Printer_Status_Tool_Parent_Load(object sender, EventArgs e)
        {
            using (StreamReader r = new StreamReader("PrinterList.json"))
            {
                json = r.ReadToEnd();
                List<Printer> Printer = JsonConvert.DeserializeObject<List<Printer>>(json);
            }
            dynamic array = JsonConvert.DeserializeObject(json);
            using (StreamReader b = new StreamReader("Config.json"))
            {
                jsonc = b.ReadToEnd();
                List<Config> Config = JsonConvert.DeserializeObject<List<Config>>(jsonc);
            }
            dynamic config = JsonConvert.DeserializeObject(jsonc);
            config = config[0];
            foreach (var printer in array)
            {
                string jsonString = File.ReadAllText("SNMP_OID.json");
                Dictionary<string, List<string>> snmpData = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(jsonString);
                string Printer_IPAddress = printer.IPAddress; // This is stupid but it works, printer.IPAddress does not work here for some reason
                string Printer_Manufacturer = printer.Manufacturer;
                string Printer_FreindName = printer.FreindName;
                Printer_Status_Tool_Child newMDIChild = new Printer_Status_Tool_Child(Printer_IPAddress, Printer_Manufacturer, Printer_FreindName, snmpData, config);
                Printerss.Add(newMDIChild);
                newMDIChild.MdiParent = this;
                newMDIChild.Show();
                newMDIChild.Location = new Point(x, y);
                x += 320;
                if (x == 1920)
                {
                    x = 0;
                    y += 312;
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            x = 0;
            y = 0;
            label1.Text = Printer_Status_Tool_Parent.ActiveForm.Size.Width.ToString() + Math.Floor(Printer_Status_Tool_Parent.ActiveForm.Size.Width / 320.0);
            int x_width = Printer_Status_Tool_Parent.ActiveForm.Size.Width;
            double New_Row_Size = Math.Floor((x_width / 320.0));
            double NewLineCount = New_Row_Size * 320;
            foreach (var Printer in Printerss)
            {
                Printer.Location = new Point(x, y);
                x += 320; 
                if (x == NewLineCount)
                {
                    x = 0;
                    y += 312;
                }
            }
        }
        protected override void OnResizeEnd(EventArgs e) //no idea whgat i did diffrerently but this works +1 AI Line
        {
            Thread.Sleep(2000);
            x = 0;
            y = 0;
            int x_width = Printer_Status_Tool_Parent.ActiveForm.Size.Width;
            double New_Row_Size = Math.Floor((x_width / 320.0));
            double NewLineCount = New_Row_Size * 320;
            foreach (var Printer in Printerss)
            {
                Printer.Location = new Point(x, y);
                x += 320; //310
                if (x == NewLineCount)
                {
                    x = 0;
                    y += 312; //340
                }
            }
        }
    }
    class Printers
    {
        public List<Printer> PrinterList { get; set; }
    }
    class Printer
    {
        public string IPAddress { get; set; }
        public string Manufacturer { get; set; }
        public string FreindName { get; set; }
    }
    class Config
    {
        public int RefreshTimer { get; set; }
        public string SNMPCommunityString { get; set; }
        public string ShowIP { get; set; }
    }
}