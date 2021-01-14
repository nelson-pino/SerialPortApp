using SerialPortApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace SerialPortApp.Forms
{
    public partial class SelecctionItems : Form
    {
        public string BannerTipoItems { get; set; }
        public object Data { get; set; } 
        public List<object> listdata;
        public object EntityReturn { get; set; }
        public bool ProcessTask { get; set; }

        public SelecctionItems()
        {
            InitializeComponent();
        }
       
        private void SelecctionItems_Load(object sender, EventArgs e)
        {
            ProcessTask = false;
            listdata = ((IEnumerable)Data).Cast<object>().ToList();
            this.banner_tipo_clase.Text = BannerTipoItems;
            GRID_DATOS.DataSource = listdata;
            CountRecordData(listdata);
            ConfigForms();
        }
        private void ConfigForms() 
        {
            if (Data.GetType().ToString().Contains("Products"))
            {
                FormatScreenProducts();
            }
            if (Data.GetType().ToString().Contains("Batchs")) 
            {
                FormatScreenBatches();
            }
        }
        private void CountRecordData(List<object> lista) 
        {
            NUM_REGISTROS.Text = "NUMERO DE REGISTROS : " + lista.Count().ToString();
    }
        private void FormatScreenProducts() 
        {
            //configuracion si la llamada es desde productos.
            //COLUMNAS DEL GRID
            GRID_DATOS.Columns["Productid"].Visible = false;
            GRID_DATOS.Columns["UnitShop"].Visible = false;
            GRID_DATOS.Columns["Tax"].Visible = false;
            GRID_DATOS.Columns["Ingredients"].Visible = false;
            GRID_DATOS.Columns["Departament"].Visible = false;
            GRID_DATOS.Columns["CodePersonolize"].HeaderText = "Id.";
            GRID_DATOS.Columns["CodePersonolize"].Width = 60;
            GRID_DATOS.Columns["ProductName"].HeaderText = "Producto Descripcion";
            GRID_DATOS.Columns["ProductName"].Width = 175;
            GRID_DATOS.Columns["ProductCategory"].HeaderText = "Categoria";
            GRID_DATOS.Columns["UnitPrice"].Width = 60;
            GRID_DATOS.Columns["UnitPrice"].HeaderText = "Unit Price.";
            //FILTROS DE PRODUCTOS.
            filtro1.Visible = true;
            filtro1.Text = "Codigo de Producto";
            filtro2.Visible = true;
            filtro2.Text = "Nombre del Producto";
            filtro3.Visible = true;
            filtro3.Text = "Categoria";
          


        }
        private void FormatScreenBatches() 
        {
            GRID_DATOS.Columns["Id"].Visible = false;
            GRID_DATOS.Columns["DateClose"].Visible = false;
            GRID_DATOS.Columns["BatchNumber"].HeaderText = "Numero";
            GRID_DATOS.Columns["BatchNumber"].Width = 60;
            GRID_DATOS.Columns["DateOpen"].DisplayIndex = 2;
            GRID_DATOS.Columns["DateOpen"].HeaderText = "Fecha Creacion";
            GRID_DATOS.Columns["DateOpen"].Width = 60;
            GRID_DATOS.Columns["Description"].HeaderText = "Descripcion del Lote";
            GRID_DATOS.Columns["Description"].Width = 123;
            GRID_DATOS.Columns["BatchStatus"].HeaderText = "Cerrado";
            GRID_DATOS.Columns["BatchStatus"].Width = 60;
            // CONTROLES DE FECHA
            LABEL_DESDE.Visible = true;
            LABEL_HASTA.Visible = true;
            TXT_DESDE.Visible = true;
            TXT_HASTA.Visible = true;
            // Configurar los filtros 
            filtro1.Text = "Numero de Lote";
            filtro2.Text = "Fecha Creacion";
            filtro3.Text = "Persona Contacto";
            filtro1.Visible = true;
            filtro2.Visible = true;
            filtro3.Visible = true;



        }
        private void BOT_BUSCAR_Click(object sender, EventArgs e)
        {
            if (filtro1.Checked)
            {
                QueryDataEntityByParameters("CodePersonolize");
            }
            if (filtro2.Checked)
            {
                QueryDataEntityByParameters("ProductName");
            }
            if (filtro3.Checked)
            {
                QueryDataEntityByParameters("ProductCategory");
            }
        }
        private void QueryDataEntityByParameters(string field) 
        {
            var  query = listdata.Where(i => (i.GetType().GetProperty(field).GetValue(i) as string).
            ToUpper().Contains(TXT_BUSCAR.Text.ToUpper().Trim())).ToList();
            GRID_DATOS.DataSource = query;
            CountRecordData(query);

        }
        private void TXT_BUSCAR_TextChanged(object sender, EventArgs e)
        {
            if (TXT_BUSCAR.Text == "") 
            {
                GRID_DATOS.DataSource = listdata;
                CountRecordData(listdata);
            }
        }
        private void GRID_DATOS_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = GRID_DATOS.Rows[e.RowIndex].Cells["CodePersonolize"].Value.ToString();
            EntityReturn  = listdata.Where(i => (i.GetType().GetProperty("CodePersonolize").
            GetValue(i) as string).Equals(id)).SingleOrDefault();
            ProcessTask = true;
            this.Close();
        }
    }
}
