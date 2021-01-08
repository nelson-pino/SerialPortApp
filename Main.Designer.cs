
namespace SerialPortApp
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TAB_DATA = new System.Windows.Forms.TabControl();
            this.TAB_PARAMETERS = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.TXT_PAR_PORT_TCPIP = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TXT_PAR_PASSWORD_SQL = new System.Windows.Forms.TextBox();
            this.TXT_PAR_USER_SQL = new System.Windows.Forms.TextBox();
            this.TXT_PAR_DBNAME = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TXT_PAR_INSTANCESQL = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TXT_BAL_OUTPUTSTRING = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.TXT_BAL_RECEIVEBYTES = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TXT_BAL_HANDSHAKE = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.TXT_BAL_STOPBITS = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.TXT_BAL_PARITY = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TXT_BAL_DATABITS = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.TXT_BAL_BAUDRATE = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_NumeroTickets = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BOT_PRIMERO = new System.Windows.Forms.ToolStripButton();
            this.BOT_SIGUIENTE = new System.Windows.Forms.ToolStripButton();
            this.BOT_ANTERIOR = new System.Windows.Forms.ToolStripButton();
            this.BOT_ULTIMO = new System.Windows.Forms.ToolStripButton();
            this.BOT_AGREGAR = new System.Windows.Forms.ToolStripButton();
            this.BOT_CANCELAR = new System.Windows.Forms.ToolStripButton();
            this.BOT_GRABAR = new System.Windows.Forms.ToolStripButton();
            this.BOT_UPDATE = new System.Windows.Forms.ToolStripButton();
            this.BOT_DELETE = new System.Windows.Forms.ToolStripButton();
            this.BOT_SEARCH = new System.Windows.Forms.ToolStripButton();
            this.BOT_ENABLED = new System.Windows.Forms.ToolStripButton();
            this.BOT_REPORT = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_FechaPesada = new System.Windows.Forms.DateTimePicker();
            this.Txt_ProductId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BOT_BUSCAR_PRODUCTS = new System.Windows.Forms.Button();
            this.Txt_ProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Peso_Bruto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Peso_Tara = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_NoBatch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Operator = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Codebar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_Commentaries = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BOT_GET_PESO = new System.Windows.Forms.Button();
            this.LBL_STATUS_BALANZA = new System.Windows.Forms.Label();
            this.LBL_RECORDS = new System.Windows.Forms.Label();
            this.BOT_PRINT_LABEL = new System.Windows.Forms.Button();
            this.chk_anulados = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TAB_DATA.SuspendLayout();
            this.TAB_PARAMETERS.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TAB_DATA
            // 
            this.TAB_DATA.Controls.Add(this.TAB_PARAMETERS);
            this.TAB_DATA.Controls.Add(this.tabPage2);
            this.TAB_DATA.Controls.Add(this.tabPage3);
            this.TAB_DATA.Location = new System.Drawing.Point(8, 291);
            this.TAB_DATA.Name = "TAB_DATA";
            this.TAB_DATA.SelectedIndex = 0;
            this.TAB_DATA.Size = new System.Drawing.Size(764, 267);
            this.TAB_DATA.TabIndex = 0;
            this.TAB_DATA.SelectedIndexChanged += new System.EventHandler(this.TAB_DATA_SelectedIndexChanged);
            // 
            // TAB_PARAMETERS
            // 
            this.TAB_PARAMETERS.Controls.Add(this.label13);
            this.TAB_PARAMETERS.Controls.Add(this.label18);
            this.TAB_PARAMETERS.Controls.Add(this.TXT_PAR_PORT_TCPIP);
            this.TAB_PARAMETERS.Controls.Add(this.label17);
            this.TAB_PARAMETERS.Controls.Add(this.label16);
            this.TAB_PARAMETERS.Controls.Add(this.TXT_PAR_PASSWORD_SQL);
            this.TAB_PARAMETERS.Controls.Add(this.TXT_PAR_USER_SQL);
            this.TAB_PARAMETERS.Controls.Add(this.TXT_PAR_DBNAME);
            this.TAB_PARAMETERS.Controls.Add(this.label15);
            this.TAB_PARAMETERS.Controls.Add(this.label14);
            this.TAB_PARAMETERS.Controls.Add(this.TXT_PAR_INSTANCESQL);
            this.TAB_PARAMETERS.Location = new System.Drawing.Point(4, 22);
            this.TAB_PARAMETERS.Name = "TAB_PARAMETERS";
            this.TAB_PARAMETERS.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_PARAMETERS.Size = new System.Drawing.Size(756, 241);
            this.TAB_PARAMETERS.TabIndex = 0;
            this.TAB_PARAMETERS.Text = "PARAMETROS";
            this.TAB_PARAMETERS.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 148);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Puerto :";
            // 
            // TXT_PAR_PORT_TCPIP
            // 
            this.TXT_PAR_PORT_TCPIP.Location = new System.Drawing.Point(179, 145);
            this.TXT_PAR_PORT_TCPIP.Name = "TXT_PAR_PORT_TCPIP";
            this.TXT_PAR_PORT_TCPIP.ReadOnly = true;
            this.TXT_PAR_PORT_TCPIP.Size = new System.Drawing.Size(198, 20);
            this.TXT_PAR_PORT_TCPIP.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 122);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Password :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Usuario SQL SRVER :";
            // 
            // TXT_PAR_PASSWORD_SQL
            // 
            this.TXT_PAR_PASSWORD_SQL.Location = new System.Drawing.Point(179, 119);
            this.TXT_PAR_PASSWORD_SQL.Name = "TXT_PAR_PASSWORD_SQL";
            this.TXT_PAR_PASSWORD_SQL.ReadOnly = true;
            this.TXT_PAR_PASSWORD_SQL.Size = new System.Drawing.Size(198, 20);
            this.TXT_PAR_PASSWORD_SQL.TabIndex = 6;
            // 
            // TXT_PAR_USER_SQL
            // 
            this.TXT_PAR_USER_SQL.Location = new System.Drawing.Point(179, 93);
            this.TXT_PAR_USER_SQL.Name = "TXT_PAR_USER_SQL";
            this.TXT_PAR_USER_SQL.ReadOnly = true;
            this.TXT_PAR_USER_SQL.Size = new System.Drawing.Size(198, 20);
            this.TXT_PAR_USER_SQL.TabIndex = 5;
            // 
            // TXT_PAR_DBNAME
            // 
            this.TXT_PAR_DBNAME.Location = new System.Drawing.Point(179, 67);
            this.TXT_PAR_DBNAME.Name = "TXT_PAR_DBNAME";
            this.TXT_PAR_DBNAME.ReadOnly = true;
            this.TXT_PAR_DBNAME.Size = new System.Drawing.Size(198, 20);
            this.TXT_PAR_DBNAME.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Nombre de Base de Datos :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Instancia de SQL :";
            // 
            // TXT_PAR_INSTANCESQL
            // 
            this.TXT_PAR_INSTANCESQL.Location = new System.Drawing.Point(179, 41);
            this.TXT_PAR_INSTANCESQL.Name = "TXT_PAR_INSTANCESQL";
            this.TXT_PAR_INSTANCESQL.ReadOnly = true;
            this.TXT_PAR_INSTANCESQL.Size = new System.Drawing.Size(198, 20);
            this.TXT_PAR_INSTANCESQL.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TXT_BAL_OUTPUTSTRING);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.TXT_BAL_RECEIVEBYTES);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.TXT_BAL_HANDSHAKE);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.TXT_BAL_STOPBITS);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.TXT_BAL_PARITY);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.TXT_BAL_DATABITS);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.TXT_BAL_BAUDRATE);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 241);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BALANZAS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TXT_BAL_OUTPUTSTRING
            // 
            this.TXT_BAL_OUTPUTSTRING.Location = new System.Drawing.Point(161, 203);
            this.TXT_BAL_OUTPUTSTRING.Name = "TXT_BAL_OUTPUTSTRING";
            this.TXT_BAL_OUTPUTSTRING.ReadOnly = true;
            this.TXT_BAL_OUTPUTSTRING.Size = new System.Drawing.Size(161, 20);
            this.TXT_BAL_OUTPUTSTRING.TabIndex = 31;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(20, 206);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 13);
            this.label25.TabIndex = 30;
            this.label25.Text = "Salida String :";
            // 
            // TXT_BAL_RECEIVEBYTES
            // 
            this.TXT_BAL_RECEIVEBYTES.Location = new System.Drawing.Point(161, 177);
            this.TXT_BAL_RECEIVEBYTES.Name = "TXT_BAL_RECEIVEBYTES";
            this.TXT_BAL_RECEIVEBYTES.ReadOnly = true;
            this.TXT_BAL_RECEIVEBYTES.Size = new System.Drawing.Size(161, 20);
            this.TXT_BAL_RECEIVEBYTES.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "ReceivedBytesThreshold :";
            // 
            // TXT_BAL_HANDSHAKE
            // 
            this.TXT_BAL_HANDSHAKE.Location = new System.Drawing.Point(161, 151);
            this.TXT_BAL_HANDSHAKE.Name = "TXT_BAL_HANDSHAKE";
            this.TXT_BAL_HANDSHAKE.ReadOnly = true;
            this.TXT_BAL_HANDSHAKE.Size = new System.Drawing.Size(161, 20);
            this.TXT_BAL_HANDSHAKE.TabIndex = 27;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(20, 154);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 13);
            this.label24.TabIndex = 26;
            this.label24.Text = "Handshake :";
            // 
            // TXT_BAL_STOPBITS
            // 
            this.TXT_BAL_STOPBITS.Location = new System.Drawing.Point(161, 125);
            this.TXT_BAL_STOPBITS.Name = "TXT_BAL_STOPBITS";
            this.TXT_BAL_STOPBITS.ReadOnly = true;
            this.TXT_BAL_STOPBITS.Size = new System.Drawing.Size(161, 20);
            this.TXT_BAL_STOPBITS.TabIndex = 25;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(20, 128);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = "StopBits :";
            // 
            // TXT_BAL_PARITY
            // 
            this.TXT_BAL_PARITY.Location = new System.Drawing.Point(161, 99);
            this.TXT_BAL_PARITY.Name = "TXT_BAL_PARITY";
            this.TXT_BAL_PARITY.ReadOnly = true;
            this.TXT_BAL_PARITY.Size = new System.Drawing.Size(161, 20);
            this.TXT_BAL_PARITY.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 102);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 13);
            this.label22.TabIndex = 22;
            this.label22.Text = "Parity :";
            // 
            // TXT_BAL_DATABITS
            // 
            this.TXT_BAL_DATABITS.Location = new System.Drawing.Point(161, 73);
            this.TXT_BAL_DATABITS.Name = "TXT_BAL_DATABITS";
            this.TXT_BAL_DATABITS.ReadOnly = true;
            this.TXT_BAL_DATABITS.Size = new System.Drawing.Size(161, 20);
            this.TXT_BAL_DATABITS.TabIndex = 21;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 76);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "DataBits :";
            // 
            // TXT_BAL_BAUDRATE
            // 
            this.TXT_BAL_BAUDRATE.Location = new System.Drawing.Point(161, 47);
            this.TXT_BAL_BAUDRATE.Name = "TXT_BAL_BAUDRATE";
            this.TXT_BAL_BAUDRATE.ReadOnly = true;
            this.TXT_BAL_BAUDRATE.Size = new System.Drawing.Size(161, 20);
            this.TXT_BAL_BAUDRATE.TabIndex = 19;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 50);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 18;
            this.label20.Text = "BaudRate :";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(6, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(320, 31);
            this.label19.TabIndex = 17;
            this.label19.Text = "PARAMETROS DE COMUNICACION DE LA BALANZA POR DEFACTO :";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(756, 241);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DATA";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero Ticket :";
            // 
            // Txt_NumeroTickets
            // 
            this.Txt_NumeroTickets.Location = new System.Drawing.Point(131, 28);
            this.Txt_NumeroTickets.Name = "Txt_NumeroTickets";
            this.Txt_NumeroTickets.ReadOnly = true;
            this.Txt_NumeroTickets.Size = new System.Drawing.Size(143, 20);
            this.Txt_NumeroTickets.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BOT_PRIMERO,
            this.BOT_SIGUIENTE,
            this.BOT_ANTERIOR,
            this.BOT_ULTIMO,
            this.BOT_AGREGAR,
            this.BOT_CANCELAR,
            this.BOT_GRABAR,
            this.BOT_UPDATE,
            this.BOT_DELETE,
            this.BOT_SEARCH,
            this.BOT_ENABLED,
            this.BOT_REPORT});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(779, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BOT_PRIMERO
            // 
            this.BOT_PRIMERO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BOT_PRIMERO.Image = ((System.Drawing.Image)(resources.GetObject("BOT_PRIMERO.Image")));
            this.BOT_PRIMERO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BOT_PRIMERO.Name = "BOT_PRIMERO";
            this.BOT_PRIMERO.Size = new System.Drawing.Size(61, 22);
            this.BOT_PRIMERO.Tag = "Agregar";
            this.BOT_PRIMERO.Text = "PRIMERO";
            this.BOT_PRIMERO.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // BOT_SIGUIENTE
            // 
            this.BOT_SIGUIENTE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BOT_SIGUIENTE.Image = ((System.Drawing.Image)(resources.GetObject("BOT_SIGUIENTE.Image")));
            this.BOT_SIGUIENTE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BOT_SIGUIENTE.Name = "BOT_SIGUIENTE";
            this.BOT_SIGUIENTE.Size = new System.Drawing.Size(66, 22);
            this.BOT_SIGUIENTE.Tag = "Agregar";
            this.BOT_SIGUIENTE.Text = "SIGUIENTE";
            this.BOT_SIGUIENTE.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // BOT_ANTERIOR
            // 
            this.BOT_ANTERIOR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BOT_ANTERIOR.Image = ((System.Drawing.Image)(resources.GetObject("BOT_ANTERIOR.Image")));
            this.BOT_ANTERIOR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BOT_ANTERIOR.Name = "BOT_ANTERIOR";
            this.BOT_ANTERIOR.Size = new System.Drawing.Size(66, 22);
            this.BOT_ANTERIOR.Tag = "Agregar";
            this.BOT_ANTERIOR.Text = "ANTERIOR";
            this.BOT_ANTERIOR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // BOT_ULTIMO
            // 
            this.BOT_ULTIMO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BOT_ULTIMO.Image = ((System.Drawing.Image)(resources.GetObject("BOT_ULTIMO.Image")));
            this.BOT_ULTIMO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BOT_ULTIMO.Name = "BOT_ULTIMO";
            this.BOT_ULTIMO.Size = new System.Drawing.Size(53, 22);
            this.BOT_ULTIMO.Tag = "Agregar";
            this.BOT_ULTIMO.Text = "ULTIMO";
            this.BOT_ULTIMO.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // BOT_AGREGAR
            // 
            this.BOT_AGREGAR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BOT_AGREGAR.Image = ((System.Drawing.Image)(resources.GetObject("BOT_AGREGAR.Image")));
            this.BOT_AGREGAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BOT_AGREGAR.Name = "BOT_AGREGAR";
            this.BOT_AGREGAR.Size = new System.Drawing.Size(63, 22);
            this.BOT_AGREGAR.Tag = "Agregar";
            this.BOT_AGREGAR.Text = "AGREGAR";
            this.BOT_AGREGAR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // BOT_CANCELAR
            // 
            this.BOT_CANCELAR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BOT_CANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("BOT_CANCELAR.Image")));
            this.BOT_CANCELAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BOT_CANCELAR.Name = "BOT_CANCELAR";
            this.BOT_CANCELAR.Size = new System.Drawing.Size(71, 22);
            this.BOT_CANCELAR.Tag = "Agregar";
            this.BOT_CANCELAR.Text = "CANCELAR";
            this.BOT_CANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // BOT_GRABAR
            // 
            this.BOT_GRABAR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BOT_GRABAR.Image = ((System.Drawing.Image)(resources.GetObject("BOT_GRABAR.Image")));
            this.BOT_GRABAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BOT_GRABAR.Name = "BOT_GRABAR";
            this.BOT_GRABAR.Size = new System.Drawing.Size(56, 22);
            this.BOT_GRABAR.Tag = "Agregar";
            this.BOT_GRABAR.Text = "GRABAR";
            this.BOT_GRABAR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // BOT_UPDATE
            // 
            this.BOT_UPDATE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BOT_UPDATE.Image = ((System.Drawing.Image)(resources.GetObject("BOT_UPDATE.Image")));
            this.BOT_UPDATE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BOT_UPDATE.Name = "BOT_UPDATE";
            this.BOT_UPDATE.Size = new System.Drawing.Size(51, 22);
            this.BOT_UPDATE.Tag = "Agregar";
            this.BOT_UPDATE.Text = "MODIF.";
            this.BOT_UPDATE.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // BOT_DELETE
            // 
            this.BOT_DELETE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BOT_DELETE.Image = ((System.Drawing.Image)(resources.GetObject("BOT_DELETE.Image")));
            this.BOT_DELETE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BOT_DELETE.Name = "BOT_DELETE";
            this.BOT_DELETE.Size = new System.Drawing.Size(56, 22);
            this.BOT_DELETE.Tag = "Agregar";
            this.BOT_DELETE.Text = "BORRAR";
            this.BOT_DELETE.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BOT_DELETE.ToolTipText = "BORRAR";
            // 
            // BOT_SEARCH
            // 
            this.BOT_SEARCH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BOT_SEARCH.Image = ((System.Drawing.Image)(resources.GetObject("BOT_SEARCH.Image")));
            this.BOT_SEARCH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BOT_SEARCH.Name = "BOT_SEARCH";
            this.BOT_SEARCH.Size = new System.Drawing.Size(55, 22);
            this.BOT_SEARCH.Tag = "Agregar";
            this.BOT_SEARCH.Text = "BUSCAR";
            this.BOT_SEARCH.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BOT_SEARCH.ToolTipText = "BUSCAR";
            // 
            // BOT_ENABLED
            // 
            this.BOT_ENABLED.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BOT_ENABLED.Image = ((System.Drawing.Image)(resources.GetObject("BOT_ENABLED.Image")));
            this.BOT_ENABLED.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BOT_ENABLED.Name = "BOT_ENABLED";
            this.BOT_ENABLED.Size = new System.Drawing.Size(57, 22);
            this.BOT_ENABLED.Tag = "Agregar";
            this.BOT_ENABLED.Text = "ANULAR";
            this.BOT_ENABLED.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BOT_ENABLED.ToolTipText = "BUSCAR";
            // 
            // BOT_REPORT
            // 
            this.BOT_REPORT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BOT_REPORT.Image = ((System.Drawing.Image)(resources.GetObject("BOT_REPORT.Image")));
            this.BOT_REPORT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BOT_REPORT.Name = "BOT_REPORT";
            this.BOT_REPORT.Size = new System.Drawing.Size(58, 22);
            this.BOT_REPORT.Tag = "Agregar";
            this.BOT_REPORT.Text = "REPORTE";
            this.BOT_REPORT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BOT_REPORT.ToolTipText = "BUSCAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha :";
            // 
            // Txt_FechaPesada
            // 
            this.Txt_FechaPesada.Enabled = false;
            this.Txt_FechaPesada.Location = new System.Drawing.Point(131, 57);
            this.Txt_FechaPesada.Name = "Txt_FechaPesada";
            this.Txt_FechaPesada.Size = new System.Drawing.Size(200, 20);
            this.Txt_FechaPesada.TabIndex = 5;
            // 
            // Txt_ProductId
            // 
            this.Txt_ProductId.Location = new System.Drawing.Point(131, 83);
            this.Txt_ProductId.Name = "Txt_ProductId";
            this.Txt_ProductId.ReadOnly = true;
            this.Txt_ProductId.Size = new System.Drawing.Size(98, 20);
            this.Txt_ProductId.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo Producto :";
            // 
            // BOT_BUSCAR_PRODUCTS
            // 
            this.BOT_BUSCAR_PRODUCTS.Location = new System.Drawing.Point(235, 81);
            this.BOT_BUSCAR_PRODUCTS.Name = "BOT_BUSCAR_PRODUCTS";
            this.BOT_BUSCAR_PRODUCTS.Size = new System.Drawing.Size(39, 23);
            this.BOT_BUSCAR_PRODUCTS.TabIndex = 8;
            this.BOT_BUSCAR_PRODUCTS.Text = "...";
            this.BOT_BUSCAR_PRODUCTS.UseVisualStyleBackColor = true;
            // 
            // Txt_ProductName
            // 
            this.Txt_ProductName.Location = new System.Drawing.Point(131, 109);
            this.Txt_ProductName.Name = "Txt_ProductName";
            this.Txt_ProductName.ReadOnly = true;
            this.Txt_ProductName.Size = new System.Drawing.Size(289, 20);
            this.Txt_ProductName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Producto Descripcion :";
            // 
            // Txt_Peso_Bruto
            // 
            this.Txt_Peso_Bruto.Location = new System.Drawing.Point(131, 135);
            this.Txt_Peso_Bruto.Name = "Txt_Peso_Bruto";
            this.Txt_Peso_Bruto.ReadOnly = true;
            this.Txt_Peso_Bruto.Size = new System.Drawing.Size(143, 20);
            this.Txt_Peso_Bruto.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Peso Bruto :";
            // 
            // Txt_Peso_Tara
            // 
            this.Txt_Peso_Tara.Location = new System.Drawing.Point(131, 161);
            this.Txt_Peso_Tara.Name = "Txt_Peso_Tara";
            this.Txt_Peso_Tara.ReadOnly = true;
            this.Txt_Peso_Tara.Size = new System.Drawing.Size(143, 20);
            this.Txt_Peso_Tara.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tara :";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox6.Font = new System.Drawing.Font("Impact", 66F);
            this.textBox6.ForeColor = System.Drawing.Color.Yellow;
            this.textBox6.Location = new System.Drawing.Point(629, 50);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(143, 141);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "0.0 ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(626, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Peso Neto :";
            // 
            // Txt_NoBatch
            // 
            this.Txt_NoBatch.Location = new System.Drawing.Point(131, 187);
            this.Txt_NoBatch.Name = "Txt_NoBatch";
            this.Txt_NoBatch.ReadOnly = true;
            this.Txt_NoBatch.Size = new System.Drawing.Size(143, 20);
            this.Txt_NoBatch.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Batch No  :";
            // 
            // Txt_Operator
            // 
            this.Txt_Operator.Location = new System.Drawing.Point(131, 213);
            this.Txt_Operator.Name = "Txt_Operator";
            this.Txt_Operator.ReadOnly = true;
            this.Txt_Operator.Size = new System.Drawing.Size(143, 20);
            this.Txt_Operator.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Operador  :";
            // 
            // Txt_Codebar
            // 
            this.Txt_Codebar.Location = new System.Drawing.Point(131, 239);
            this.Txt_Codebar.Name = "Txt_Codebar";
            this.Txt_Codebar.ReadOnly = true;
            this.Txt_Codebar.Size = new System.Drawing.Size(143, 20);
            this.Txt_Codebar.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Codigo Barra  :";
            // 
            // Txt_Commentaries
            // 
            this.Txt_Commentaries.Location = new System.Drawing.Point(131, 265);
            this.Txt_Commentaries.Name = "Txt_Commentaries";
            this.Txt_Commentaries.ReadOnly = true;
            this.Txt_Commentaries.Size = new System.Drawing.Size(287, 20);
            this.Txt_Commentaries.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Comentario  :";
            // 
            // BOT_GET_PESO
            // 
            this.BOT_GET_PESO.Location = new System.Drawing.Point(629, 197);
            this.BOT_GET_PESO.Name = "BOT_GET_PESO";
            this.BOT_GET_PESO.Size = new System.Drawing.Size(139, 23);
            this.BOT_GET_PESO.TabIndex = 25;
            this.BOT_GET_PESO.Text = "Tomar Peso";
            this.BOT_GET_PESO.UseVisualStyleBackColor = true;
            // 
            // LBL_STATUS_BALANZA
            // 
            this.LBL_STATUS_BALANZA.AutoSize = true;
            this.LBL_STATUS_BALANZA.Location = new System.Drawing.Point(674, 223);
            this.LBL_STATUS_BALANZA.Name = "LBL_STATUS_BALANZA";
            this.LBL_STATUS_BALANZA.Size = new System.Drawing.Size(55, 13);
            this.LBL_STATUS_BALANZA.TabIndex = 26;
            this.LBL_STATUS_BALANZA.Text = "ESTABLE";
            // 
            // LBL_RECORDS
            // 
            this.LBL_RECORDS.AutoSize = true;
            this.LBL_RECORDS.Location = new System.Drawing.Point(689, 275);
            this.LBL_RECORDS.Name = "LBL_RECORDS";
            this.LBL_RECORDS.Size = new System.Drawing.Size(79, 13);
            this.LBL_RECORDS.TabIndex = 27;
            this.LBL_RECORDS.Text = "Registro 0 de 0";
            // 
            // BOT_PRINT_LABEL
            // 
            this.BOT_PRINT_LABEL.Location = new System.Drawing.Point(506, 54);
            this.BOT_PRINT_LABEL.Name = "BOT_PRINT_LABEL";
            this.BOT_PRINT_LABEL.Size = new System.Drawing.Size(117, 23);
            this.BOT_PRINT_LABEL.TabIndex = 28;
            this.BOT_PRINT_LABEL.Text = "Print Label";
            this.BOT_PRINT_LABEL.UseVisualStyleBackColor = true;
            // 
            // chk_anulados
            // 
            this.chk_anulados.AutoSize = true;
            this.chk_anulados.Location = new System.Drawing.Point(328, 238);
            this.chk_anulados.Name = "chk_anulados";
            this.chk_anulados.Size = new System.Drawing.Size(101, 17);
            this.chk_anulados.TabIndex = 29;
            this.chk_anulados.Text = "Ticket Anulado ";
            this.chk_anulados.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(7, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(320, 31);
            this.label13.TabIndex = 18;
            this.label13.Text = "PARAMETROS DE CONEXION A LA BASE DE DATOS SQL-SERVER :";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 561);
            this.Controls.Add(this.chk_anulados);
            this.Controls.Add(this.BOT_PRINT_LABEL);
            this.Controls.Add(this.LBL_RECORDS);
            this.Controls.Add(this.LBL_STATUS_BALANZA);
            this.Controls.Add(this.BOT_GET_PESO);
            this.Controls.Add(this.Txt_Commentaries);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Txt_Codebar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Txt_Operator);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Txt_NoBatch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Txt_Peso_Tara);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Peso_Bruto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_ProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BOT_BUSCAR_PRODUCTS);
            this.Controls.Add(this.Txt_ProductId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_FechaPesada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Txt_NumeroTickets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TAB_DATA);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE PESAJE EN BALANZAS ELECTRONICAS";
            this.Load += new System.EventHandler(this.Main_Load);
            this.TAB_DATA.ResumeLayout(false);
            this.TAB_PARAMETERS.ResumeLayout(false);
            this.TAB_PARAMETERS.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TAB_DATA;
        private System.Windows.Forms.TabPage TAB_PARAMETERS;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_NumeroTickets;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BOT_REPORT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Txt_FechaPesada;
        private System.Windows.Forms.TextBox Txt_ProductId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BOT_BUSCAR_PRODUCTS;
        private System.Windows.Forms.TextBox Txt_ProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Peso_Bruto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Peso_Tara;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_NoBatch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Operator;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Codebar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_Commentaries;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BOT_GET_PESO;
        private System.Windows.Forms.ToolStripButton BOT_AGREGAR;
        private System.Windows.Forms.ToolStripButton BOT_CANCELAR;
        private System.Windows.Forms.ToolStripButton BOT_GRABAR;
        private System.Windows.Forms.Label LBL_STATUS_BALANZA;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripButton BOT_PRIMERO;
        private System.Windows.Forms.ToolStripButton BOT_SIGUIENTE;
        private System.Windows.Forms.ToolStripButton BOT_ANTERIOR;
        private System.Windows.Forms.ToolStripButton BOT_ULTIMO;
        private System.Windows.Forms.Label LBL_RECORDS;
        private System.Windows.Forms.Button BOT_PRINT_LABEL;
        private System.Windows.Forms.ToolStripButton BOT_UPDATE;
        private System.Windows.Forms.ToolStripButton BOT_DELETE;
        private System.Windows.Forms.ToolStripButton BOT_SEARCH;
        private System.Windows.Forms.ToolStripButton BOT_ENABLED;
        private System.Windows.Forms.CheckBox chk_anulados;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TXT_PAR_PASSWORD_SQL;
        private System.Windows.Forms.TextBox TXT_PAR_USER_SQL;
        private System.Windows.Forms.TextBox TXT_PAR_DBNAME;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TXT_PAR_INSTANCESQL;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TXT_PAR_PORT_TCPIP;
        private System.Windows.Forms.TextBox TXT_BAL_RECEIVEBYTES;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXT_BAL_HANDSHAKE;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox TXT_BAL_STOPBITS;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox TXT_BAL_PARITY;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TXT_BAL_DATABITS;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox TXT_BAL_BAUDRATE;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TXT_BAL_OUTPUTSTRING;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label13;
    }
}

