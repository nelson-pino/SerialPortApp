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
        public object data { get; set; } 
        public List<object> listdata;
        public string TypeEntity { get; set; }

        public SelecctionItems()
        {
            InitializeComponent();
        }
       
        private void SelecctionItems_Load(object sender, EventArgs e)
        {
            listdata = ((IEnumerable)data).Cast<object>().ToList();
            this.banner_tipo_clase.Text = BannerTipoItems;
            GRID_DATOS.DataSource = listdata;
            CountRecordData(listdata);
            ConfigForms();
        }
        private void ConfigForms() 
        {
            if (data.GetType().ToString().Contains("Products"))
            {
                FormatScreenProducts();
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


            var EntityGeneric = listdata.Where(i => (i.GetType().GetProperty("CodePersonolize").
            GetValue(i) as string).Equals("10.001.01")).Single();

        }
    }
}
