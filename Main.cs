namespace SerialPortApp
{
    using System;
    using System.Windows.Forms;
    using System.IO.Ports;
    using SerialPortApp.Models;
    using SerialPortApp.Controlers;
    using SerialPortApp.Forms;
    using System.Collections.Generic;

    public partial class Main : Form
    {
        readonly SerialPort CommPort = new SerialPort();

        internal delegate void SerialDataReceivedEventHanderDelegate
        (object sender, SerialDataReceivedEventArgs e);

        delegate void SetTextCallBack(string text);

        readonly string InputData = string.Empty;
        readonly Char[] CharBuffer = new Char[50];

        // Intanciar los controler de mis entidades.
        readonly ProductsController prodductscontroller = new ProductsController();
        int EditModeProducts = 0;
        public Main()
        {
            InitializeComponent();
            CommPort.DataReceived += new SerialDataReceivedEventHandler(GetDataPortSerialComm);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadParameters();
            ConfigObjectSerialPortComm();

           



        }
        private void ConfigObjectSerialPortComm() 
        {
            // Crear el Objeto SerialPort.
            CommPort.PortName = "COM2";
            CommPort.BaudRate = Convert.ToInt32(TXT_BAL_BAUDRATE.Text);
            CommPort.StopBits = StopBits.One;
            CommPort.Parity = Parity.Space;
            CommPort.Handshake = Handshake.None;
            CommPort.ReceivedBytesThreshold = Convert.ToInt32(TXT_BAL_RECEIVEBYTES.Text);
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

        #region FORMS_ZONE
        private void BOT_OPEN_PORT_Click(object sender, EventArgs e)
        {
            CommPort.Open();
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
                + TXT_PAR_PORT_TCPIP.Text +
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

        #endregion
        #region PRODUCTS_ZONE
        private Products CreateObjectProduct() 
        {
            Products producto = new Products
            {
                CodePersonolize = TXT_PRO_PRODUCTID.Text,
                ProductName = TXT_PRO_PRODUCT_NAME.Text,
                ProductCategory = TXT_PRO_CATEGORY.Text,
                Departament = TXT_PRO_DEPARTAMENT.Text,
                UnitPrice = Convert.ToDecimal(TXT_PRO_UNITPRICE.Text),
                UnitShop = TXT_PRO_UNITSHOP.Text,
                Ingredients = TXT_PRO_INGREDIENTS.Text,
                Tax = Convert.ToDecimal(TXT_PRO_TAX.Text)
            };
            return producto;
        }
        private void PRODUCTS_ADD() 
        {  
            prodductscontroller.Add(CreateObjectProduct());
            EditModeProducts = 0;
        }
        private void PRODUCTS_UPDATE() 
        {
            prodductscontroller.Update(CreateObjectProduct());
            EditModeProducts = 0;
        }
        private void LINK_PRO_UPDATE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditModeProducts = 2;
        }
        private void LINK_PRO_GUARDAR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch (EditModeProducts)
            {
                case 1:
                    PRODUCTS_ADD();
                    break;
                case 2:
                    PRODUCTS_UPDATE();
                    break;
            }
        }
        private void LINK_PRO_AGREGAR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetStatusTextboxProducts(false);
            LINK_PRO_AGREGAR.Enabled = false;
            LINK_PRO_UPDATE.Enabled = false;
            LINK_PRO_SEARCH.Enabled = false;
            EditModeProducts = 1;
        }
        private void SetStatusTextboxProducts(bool sw)
        {
            TXT_PRO_PRODUCTID.ReadOnly = sw;
            TXT_PRO_PRODUCT_NAME.ReadOnly = sw;
            TXT_PRO_CATEGORY.ReadOnly = sw;
            TXT_PRO_DEPARTAMENT.ReadOnly = sw;
            TXT_PRO_INGREDIENTS.ReadOnly = sw;
            TXT_PRO_TAX.ReadOnly = sw;
            TXT_PRO_UNITPRICE.ReadOnly = sw;
            TXT_PRO_UNITSHOP.ReadOnly = sw;
            TXT_PRO_PRODUCTID.Focus();
        }
        #endregion

        private void LINK_PRO_SEARCH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var milista = prodductscontroller.List();
            SelecctionItems selectitems = new SelecctionItems();
            selectitems.BannerTipoItems = "Productos";
            selectitems.data = milista;
            selectitems.ShowDialog();
        }
    }
}
