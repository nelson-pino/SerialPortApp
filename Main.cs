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
        readonly ProductsController productscontroller = new ProductsController();
        readonly BatchsController batchcontroller = new BatchsController();
        int EditModeProducts, EditModeBatchs = 0;
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

        #region PORTCOMM_ZONE
        private void ProcessData()
        {

        }
        private void SetText(string text)
        {
            TXT_HYPER_TERMINAL.Text = Text;
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

        #endregion
        #region FORMS_ZONE
        private void TAB_DATA_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TAB_DATA.SelectedTab.Text)
            {
                case "PRODUCTOS":

                    ClearFormTextboxProducts();
                    MenuOptionsStatusProducts(true);
                    break;
            }
        }
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
            productscontroller.Add(CreateObjectProduct());
            EditModeProducts = 0;
            MessageBox.Show("Se agrego el producto con exito.");
        }
        private void PRODUCTS_UPDATE()
        {
            var item = CreateObjectProduct();
            item.ProductID = Convert.ToInt32(TXT_PRO_INDEX.Text);
            productscontroller.Update(item);
            EditModeProducts = 0;
            MessageBox.Show("Se modifco el producto con exito.");
        }
        private void LINK_PRO_UPDATE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditModeProducts = 2;
            SetStatusTextboxProducts(false);
            //DESACTIVO LOS CAMPOS QUE NO SE VAN A MODIFICAR
            TXT_PRO_PRODUCTID.ReadOnly = true;
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
            SetStatusTextboxProducts(true);
            MenuOptionsStatusProducts(true);
        }
        private void LINK_PRO_AGREGAR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetStatusTextboxProducts(false);
            LINK_PRO_AGREGAR.Enabled = false;
            LINK_PRO_UPDATE.Enabled = false;
            LINK_PRO_SEARCH.Enabled = false;
            ClearFormTextboxProducts();

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
        private void SetEntityToTextBoxs(Products product)
        {
            TXT_PRO_PRODUCTID.Text = product.CodePersonolize.ToString();
            TXT_PRO_PRODUCT_NAME.Text = product.ProductName.ToString();
            TXT_PRO_CATEGORY.Text = product.ProductCategory.ToString();
            TXT_PRO_DEPARTAMENT.Text = product.Departament.ToString();
            TXT_PRO_INGREDIENTS.Text = product.Ingredients.ToString();
            TXT_PRO_UNITPRICE.Text = product.UnitPrice.ToString();
            TXT_PRO_UNITSHOP.Text = product.UnitShop.ToString();
            TXT_PRO_TAX.Text = product.Tax.ToString();
            TXT_PRO_INDEX.Text = product.ProductID.ToString();
        }
        private void LINK_PRO_SEARCH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var milista = productscontroller.List();
            SelecctionItems selectitems = new SelecctionItems
            {
                BannerTipoItems = "Productos",
                data = milista
            };
            selectitems.ShowDialog();
            if (selectitems.ProcessTask == false)
            {
                return;
            }
            Products ReturnProduct = (Products)selectitems.EntityReturn;
            SetEntityToTextBoxs(ReturnProduct);

        }
        private void MenuOptionsStatusProducts(bool sw)
        {
            LINK_PRO_AGREGAR.Enabled = sw;
            LINK_PRO_GUARDAR.Enabled = sw;
            LINK_PRO_SEARCH.Enabled = sw;
            LINK_PRO_UPDATE.Enabled = sw;
            LINK_PRO_ELIMINAR.Enabled = sw;
        }
        private void ClearFormTextboxProducts()
        {
            TXT_PRO_PRODUCTID.Text = "";
            TXT_PRO_PRODUCT_NAME.Text = "";
            TXT_PRO_INGREDIENTS.Text = "";
            TXT_PRO_DEPARTAMENT.Text = "";
            TXT_PRO_UNITPRICE.Text = "";
            TXT_PRO_TAX.Text = "";
            TXT_PRO_CATEGORY.Text = "";
            TXT_PRO_UNITSHOP.Text = "";
            TXT_PRO_INDEX.Text = "";
        }
        private void LINK_PRO_ELIMINAR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (TXT_PRO_INDEX.Text == "")
            {
                MessageBox.Show("Seleccione un producto primero.");
                return;
            }
            DialogResult dr = MessageBox.Show("Esta seguro de que desea Eliminar de manera permanete este producto?",
                      "Mood Test", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    productscontroller.Detele(Convert.ToInt32(TXT_PRO_INDEX.Text.Trim()));
                    ClearFormTextboxProducts();
                    break;
                case DialogResult.No:
                    break;
            }
        }
        #endregion
        #region BATCHES_ZONE

        private void LINK_BAT_AGREGAR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetStatusTextboxBatchs(false);
            LINK_BAT_AGREGAR.Enabled = false;
            LINK_BAT_UPDATE.Enabled = false;
            LINK_BAT_SEARCH.Enabled = false;
            LINK_BAT_ELIMINAR.Enabled = false;
            LINK_BAT_CLOSE.Enabled = false;
            ClearFormTextboxBatch();
            EditModeBatchs = 1;
        }
        private void ClearFormTextboxBatch()
        {
            TXT_BAT_NUMERO.Text = "";
            TXT_BAT_PERSON.Text = "";
            TXT_BAT_DESCRIPTION.Text = "";
            TXT_BAT_DATE.Text = "";
        }
        private void SetStatusTextboxBatchs(bool sw)
        {
            TXT_BAT_NUMERO.ReadOnly = sw;
            TXT_BAT_DATE.Enabled = !sw;
            TXT_BAT_DESCRIPTION.ReadOnly = sw;
            TXT_BAT_PERSON.ReadOnly = sw;
        }
        #endregion


        private void LINK_BAT_GRABAR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch (EditModeBatchs)
            {
                case 1:
                    BATCHES_ADD();
                    break;
                case 2:
                    BATCHES_UPDATE();
                    break;
            }
            SetStatusTextboxBatches(true);
            MenuOptionsStatusBatches(true);
        }
        private void MenuOptionsStatusBatches(bool sw) 
        {
            LINK_BAT_AGREGAR.Enabled = sw;
            LINK_BAT_CLOSE.Enabled = sw;
            LINK_BAT_ELIMINAR.Enabled = sw;
            LINK_BAT_GRABAR.Enabled = sw;
            LINK_BAT_SEARCH.Enabled = sw;
            LINK_BAT_UPDATE.Enabled = sw;
        }
        private void SetStatusTextboxBatches(bool sw) 
        {
            TXT_BAT_NUMERO.ReadOnly = sw;
            TXT_BAT_PERSON.ReadOnly = sw;
            TXT_BAT_DESCRIPTION.ReadOnly = sw;
            TXT_BAT_DATE.Enabled = !sw;
        }
        private void BATCHES_ADD() 
        {
            batchcontroller.Add(CreateObjectBatch());
            EditModeBatchs = 0;
            MessageBox.Show("Se agrego un batch con exito.");

        }
        private Batchs CreateObjectBatch() 
        {
            Batchs batch = new Batchs
            {
                BatchNumber = TXT_BAT_NUMERO.Text,
                DateOpen = Convert.ToDateTime(TXT_BAT_DATE.Text),
                DateClose = Convert.ToDateTime(TXT_BAT_DATE.Text),
                Person = TXT_BAT_PERSON.Text,
                BatchStatus = false,
                Description = TXT_BAT_DESCRIPTION.Text
            };
            return batch;
        }
        private void BATCHES_UPDATE() 
        {
        
        }
    }
}
