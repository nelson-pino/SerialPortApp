using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialPortApp
{
    public partial class Main : Form
    {
        SerialPort CommPort = new SerialPort();

        internal delegate void SerialDataReceivedEventHanderDelegate
        (object sender, SerialDataReceivedEventArgs e);

        delegate void SetTextCallBack(string text);
        string InputData = string.Empty;

        Char[] CharBuffer = new Char[50];
        Int32 count;

        public Main()
        {
            InitializeComponent();
            CommPort.DataReceived += new SerialDataReceivedEventHandler(GetDataPortSerialComm);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadParameters();
        }
        private void LoadParameters()
        {
            //Carga de Parametros de Conexion de la Base de Datos
            TXT_PAR_INSTANCESQL.Text = Properties.Resources.INSTANCE_SQLSERVER;
            TXT_PAR_DBNAME.Text = Properties.Resources.DATABASE_NAME_DEFAULT;
            TXT_PAR_USER_SQL.Text = Properties.Resources.USER_SQL;
            TXT_PAR_PASSWORD_SQL.Text = Properties.Resources.PASSWORD_SQL;
            TXT_PAR_PORT_TCPIP.Text = Properties.Resources.PORT_TCP_SQL;

            //Crear el string de Conexion

            TXT_PAR_STRIG_CONECTION.Text = "Server = " + TXT_PAR_INSTANCESQL.Text + ","
                +TXT_PAR_PORT_TCPIP.Text +
                "; Database = " + TXT_PAR_DBNAME.Text + "; UserId = " + TXT_PAR_USER_SQL.Text + 
                "; Password = " + TXT_PAR_PASSWORD_SQL.Text;

            // Carga de Parametros de Comunicacion de la Balanza.
            TXT_BAL_BAUDRATE.Text = Properties.Resources.BALANZA_PROPERTY_BaudRate;
            TXT_BAL_DATABITS.Text = Properties.Resources.BALANZA_PROPERTY_DataBits;
            TXT_BAL_PARITY.Text = Properties.Resources.BALANZA_PROPERTY_Parity;
            TXT_BAL_HANDSHAKE.Text = Properties.Resources.BALANZA_PROPERTY_Handshake;
            TXT_BAL_STOPBITS.Text = Properties.Resources.BALANZA_PROPERTY_StopBits;
            TXT_BAL_RECEIVEBYTES.Text = Properties.Resources.BALANZA_PROPERTY_ReceivedBytesThreshold;
            TXT_BAL_OUTPUTSTRING.Text = Properties.Resources.BALANZA_PROPERTY_StringOutputDevice;
            TXT__BAL_COMM_PORT.Text = Properties.Resources.BALANZA_PROPERTY_CommPort;
        }
        private void GetDataPortSerialComm(object sender, SerialDataReceivedEventArgs e)
        {
            CommPort.Read(CharBuffer, 1, 49);
            ProcessData();
            if (InputData != String.Empty)
            {
                this.BeginInvoke(new SetTextCallBack(SetText), new object[] { InputData });
            }
        }
        private void SetText(string text) 
        {
            TXT_HYPER_TERMINAL.Text = Text;
        }
        private void ProcessData() 
        {
        
        }
    }
}
