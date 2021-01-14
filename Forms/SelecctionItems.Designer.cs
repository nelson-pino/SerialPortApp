
namespace SerialPortApp.Forms
{
    partial class SelecctionItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.banner_tipo_clase = new System.Windows.Forms.Label();
            this.TXT_BUSCAR = new System.Windows.Forms.TextBox();
            this.GRID_DATOS = new System.Windows.Forms.DataGridView();
            this.filtro1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filtro5 = new System.Windows.Forms.RadioButton();
            this.filtro2 = new System.Windows.Forms.RadioButton();
            this.filtro4 = new System.Windows.Forms.RadioButton();
            this.filtro3 = new System.Windows.Forms.RadioButton();
            this.NUM_REGISTROS = new System.Windows.Forms.Label();
            this.BOT_BUSCAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_DESDE = new System.Windows.Forms.DateTimePicker();
            this.TXT_HASTA = new System.Windows.Forms.DateTimePicker();
            this.LABEL_DESDE = new System.Windows.Forms.Label();
            this.LABEL_HASTA = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRID_DATOS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.banner_tipo_clase);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 100);
            this.panel1.TabIndex = 0;
            // 
            // banner_tipo_clase
            // 
            this.banner_tipo_clase.Font = new System.Drawing.Font("HP Simplified", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banner_tipo_clase.Location = new System.Drawing.Point(0, 24);
            this.banner_tipo_clase.Name = "banner_tipo_clase";
            this.banner_tipo_clase.Size = new System.Drawing.Size(457, 50);
            this.banner_tipo_clase.TabIndex = 1;
            this.banner_tipo_clase.Text = "TIPO DE ELEMENTO";
            this.banner_tipo_clase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_BUSCAR
            // 
            this.TXT_BUSCAR.Location = new System.Drawing.Point(12, 125);
            this.TXT_BUSCAR.Name = "TXT_BUSCAR";
            this.TXT_BUSCAR.Size = new System.Drawing.Size(355, 20);
            this.TXT_BUSCAR.TabIndex = 2;
            this.TXT_BUSCAR.TextChanged += new System.EventHandler(this.TXT_BUSCAR_TextChanged);
            // 
            // GRID_DATOS
            // 
            this.GRID_DATOS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GRID_DATOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("HP Simplified", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRID_DATOS.DefaultCellStyle = dataGridViewCellStyle1;
            this.GRID_DATOS.Location = new System.Drawing.Point(12, 151);
            this.GRID_DATOS.Name = "GRID_DATOS";
            this.GRID_DATOS.ReadOnly = true;
            this.GRID_DATOS.RowHeadersWidth = 30;
            this.GRID_DATOS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GRID_DATOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRID_DATOS.Size = new System.Drawing.Size(436, 235);
            this.GRID_DATOS.TabIndex = 3;
            this.GRID_DATOS.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GRID_DATOS_CellMouseDoubleClick);
            // 
            // filtro1
            // 
            this.filtro1.AutoSize = true;
            this.filtro1.Checked = true;
            this.filtro1.Location = new System.Drawing.Point(16, 20);
            this.filtro1.Name = "filtro1";
            this.filtro1.Size = new System.Drawing.Size(60, 20);
            this.filtro1.TabIndex = 4;
            this.filtro1.TabStop = true;
            this.filtro1.Text = "filtro1";
            this.filtro1.UseVisualStyleBackColor = true;
            this.filtro1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filtro5);
            this.groupBox1.Controls.Add(this.filtro2);
            this.groupBox1.Controls.Add(this.filtro1);
            this.groupBox1.Controls.Add(this.filtro4);
            this.groupBox1.Controls.Add(this.filtro3);
            this.groupBox1.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(258, 392);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 125);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FILTROS : ";
            // 
            // filtro5
            // 
            this.filtro5.AutoSize = true;
            this.filtro5.Location = new System.Drawing.Point(16, 102);
            this.filtro5.Name = "filtro5";
            this.filtro5.Size = new System.Drawing.Size(66, 20);
            this.filtro5.TabIndex = 8;
            this.filtro5.Text = "filtro5 :";
            this.filtro5.UseVisualStyleBackColor = true;
            this.filtro5.Visible = false;
            // 
            // filtro2
            // 
            this.filtro2.AutoSize = true;
            this.filtro2.Location = new System.Drawing.Point(16, 40);
            this.filtro2.Name = "filtro2";
            this.filtro2.Size = new System.Drawing.Size(60, 20);
            this.filtro2.TabIndex = 5;
            this.filtro2.Text = "filtro2";
            this.filtro2.UseVisualStyleBackColor = true;
            this.filtro2.Visible = false;
            // 
            // filtro4
            // 
            this.filtro4.AutoSize = true;
            this.filtro4.Location = new System.Drawing.Point(16, 81);
            this.filtro4.Name = "filtro4";
            this.filtro4.Size = new System.Drawing.Size(63, 20);
            this.filtro4.TabIndex = 7;
            this.filtro4.Text = "filtro4:";
            this.filtro4.UseVisualStyleBackColor = true;
            this.filtro4.Visible = false;
            // 
            // filtro3
            // 
            this.filtro3.AutoSize = true;
            this.filtro3.Location = new System.Drawing.Point(16, 60);
            this.filtro3.Name = "filtro3";
            this.filtro3.Size = new System.Drawing.Size(60, 20);
            this.filtro3.TabIndex = 6;
            this.filtro3.Text = "filtro3";
            this.filtro3.UseVisualStyleBackColor = true;
            this.filtro3.Visible = false;
            // 
            // NUM_REGISTROS
            // 
            this.NUM_REGISTROS.AutoSize = true;
            this.NUM_REGISTROS.Font = new System.Drawing.Font("HP Simplified", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUM_REGISTROS.Location = new System.Drawing.Point(12, 389);
            this.NUM_REGISTROS.Name = "NUM_REGISTROS";
            this.NUM_REGISTROS.Size = new System.Drawing.Size(81, 18);
            this.NUM_REGISTROS.TabIndex = 6;
            this.NUM_REGISTROS.Text = "REGISTROS :";
            // 
            // BOT_BUSCAR
            // 
            this.BOT_BUSCAR.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOT_BUSCAR.Location = new System.Drawing.Point(373, 122);
            this.BOT_BUSCAR.Name = "BOT_BUSCAR";
            this.BOT_BUSCAR.Size = new System.Drawing.Size(75, 23);
            this.BOT_BUSCAR.TabIndex = 7;
            this.BOT_BUSCAR.Text = "BUSCAR";
            this.BOT_BUSCAR.UseVisualStyleBackColor = true;
            this.BOT_BUSCAR.Click += new System.EventHandler(this.BOT_BUSCAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "BUSCAR POR :";
            // 
            // TXT_DESDE
            // 
            this.TXT_DESDE.Location = new System.Drawing.Point(28, 450);
            this.TXT_DESDE.Name = "TXT_DESDE";
            this.TXT_DESDE.Size = new System.Drawing.Size(200, 20);
            this.TXT_DESDE.TabIndex = 9;
            this.TXT_DESDE.Visible = false;
            // 
            // TXT_HASTA
            // 
            this.TXT_HASTA.Location = new System.Drawing.Point(28, 494);
            this.TXT_HASTA.Name = "TXT_HASTA";
            this.TXT_HASTA.Size = new System.Drawing.Size(200, 20);
            this.TXT_HASTA.TabIndex = 10;
            this.TXT_HASTA.Visible = false;
            // 
            // LABEL_DESDE
            // 
            this.LABEL_DESDE.AutoSize = true;
            this.LABEL_DESDE.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_DESDE.Location = new System.Drawing.Point(25, 431);
            this.LABEL_DESDE.Name = "LABEL_DESDE";
            this.LABEL_DESDE.Size = new System.Drawing.Size(51, 16);
            this.LABEL_DESDE.TabIndex = 11;
            this.LABEL_DESDE.Text = "DESDE :";
            this.LABEL_DESDE.Visible = false;
            // 
            // LABEL_HASTA
            // 
            this.LABEL_HASTA.AutoSize = true;
            this.LABEL_HASTA.Font = new System.Drawing.Font("HP Simplified", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_HASTA.Location = new System.Drawing.Point(25, 475);
            this.LABEL_HASTA.Name = "LABEL_HASTA";
            this.LABEL_HASTA.Size = new System.Drawing.Size(51, 16);
            this.LABEL_HASTA.TabIndex = 12;
            this.LABEL_HASTA.Text = "HASTA :";
            this.LABEL_HASTA.Visible = false;
            // 
            // SelecctionItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 529);
            this.Controls.Add(this.LABEL_HASTA);
            this.Controls.Add(this.LABEL_DESDE);
            this.Controls.Add(this.TXT_HASTA);
            this.Controls.Add(this.TXT_DESDE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BOT_BUSCAR);
            this.Controls.Add(this.NUM_REGISTROS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GRID_DATOS);
            this.Controls.Add(this.TXT_BUSCAR);
            this.Controls.Add(this.panel1);
            this.Name = "SelecctionItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion de Elementos";
            this.Load += new System.EventHandler(this.SelecctionItems_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRID_DATOS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label banner_tipo_clase;
        private System.Windows.Forms.TextBox TXT_BUSCAR;
        private System.Windows.Forms.DataGridView GRID_DATOS;
        private System.Windows.Forms.RadioButton filtro1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton filtro2;
        private System.Windows.Forms.Label NUM_REGISTROS;
        private System.Windows.Forms.RadioButton filtro5;
        private System.Windows.Forms.RadioButton filtro4;
        private System.Windows.Forms.RadioButton filtro3;
        private System.Windows.Forms.Button BOT_BUSCAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker TXT_DESDE;
        private System.Windows.Forms.DateTimePicker TXT_HASTA;
        private System.Windows.Forms.Label LABEL_DESDE;
        private System.Windows.Forms.Label LABEL_HASTA;
    }
}