namespace PIIIAltoValyrio
{
    partial class FrmIngresoProducto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresoProducto));
            this.cmbrefrigeracion = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.categoriaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.altoValyrioDataSet1 = new PIIIAltoValyrio.AltoValyrioDataSet1();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.altoValyrioDataSet4 = new PIIIAltoValyrio.AltoValyrioDataSet4();
            this.cmMarca = new System.Windows.Forms.ComboBox();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.altoValyrioDataSet3 = new PIIIAltoValyrio.AltoValyrioDataSet3();
            this.cmbpresentacion = new System.Windows.Forms.ComboBox();
            this.presentacionProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.altoValyrioDataSet2 = new PIIIAltoValyrio.AltoValyrioDataSet2();
            this.txtnombreprod = new System.Windows.Forms.TextBox();
            this.txtcodigoprod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.categoriaProductoTableAdapter = new PIIIAltoValyrio.AltoValyrioDataSet1TableAdapters.CategoriaProductoTableAdapter();
            this.presentacionProductoTableAdapter = new PIIIAltoValyrio.AltoValyrioDataSet2TableAdapters.PresentacionProductoTableAdapter();
            this.marcaTableAdapter = new PIIIAltoValyrio.AltoValyrioDataSet3TableAdapters.MarcaTableAdapter();
            this.bodegaTableAdapter = new PIIIAltoValyrio.AltoValyrioDataSet4TableAdapters.BodegaTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altoValyrioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altoValyrioDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altoValyrioDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altoValyrioDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbrefrigeracion
            // 
            this.cmbrefrigeracion.Font = new System.Drawing.Font("Quicksand Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbrefrigeracion.FormattingEnabled = true;
            this.cmbrefrigeracion.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbrefrigeracion.Location = new System.Drawing.Point(545, 367);
            this.cmbrefrigeracion.Name = "cmbrefrigeracion";
            this.cmbrefrigeracion.Size = new System.Drawing.Size(108, 31);
            this.cmbrefrigeracion.TabIndex = 107;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.categoriaProductoBindingSource;
            this.comboBox1.DisplayMember = "NombreCategoria";
            this.comboBox1.Font = new System.Drawing.Font("Quicksand Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(545, 192);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 31);
            this.comboBox1.TabIndex = 106;
            this.comboBox1.ValueMember = "IdCategoria";
            // 
            // categoriaProductoBindingSource
            // 
            this.categoriaProductoBindingSource.DataMember = "CategoriaProducto";
            this.categoriaProductoBindingSource.DataSource = this.altoValyrioDataSet1;
            // 
            // altoValyrioDataSet1
            // 
            this.altoValyrioDataSet1.DataSetName = "AltoValyrioDataSet1";
            this.altoValyrioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.bodegaBindingSource;
            this.comboBox4.DisplayMember = "NombreBodega";
            this.comboBox4.Font = new System.Drawing.Font("Quicksand Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(545, 323);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(194, 31);
            this.comboBox4.TabIndex = 105;
            this.comboBox4.ValueMember = "IdBodega";
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this.altoValyrioDataSet4;
            // 
            // altoValyrioDataSet4
            // 
            this.altoValyrioDataSet4.DataSetName = "AltoValyrioDataSet4";
            this.altoValyrioDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmMarca
            // 
            this.cmMarca.DataSource = this.marcaBindingSource;
            this.cmMarca.DisplayMember = "NombreMarca";
            this.cmMarca.Font = new System.Drawing.Font("Quicksand Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmMarca.FormattingEnabled = true;
            this.cmMarca.Location = new System.Drawing.Point(545, 273);
            this.cmMarca.Name = "cmMarca";
            this.cmMarca.Size = new System.Drawing.Size(124, 31);
            this.cmMarca.TabIndex = 104;
            this.cmMarca.ValueMember = "IdMarca";
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "Marca";
            this.marcaBindingSource.DataSource = this.altoValyrioDataSet3;
            // 
            // altoValyrioDataSet3
            // 
            this.altoValyrioDataSet3.DataSetName = "AltoValyrioDataSet3";
            this.altoValyrioDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbpresentacion
            // 
            this.cmbpresentacion.DataSource = this.presentacionProductoBindingSource;
            this.cmbpresentacion.DisplayMember = "NombrePresentacion";
            this.cmbpresentacion.Font = new System.Drawing.Font("Quicksand Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpresentacion.FormattingEnabled = true;
            this.cmbpresentacion.Location = new System.Drawing.Point(545, 229);
            this.cmbpresentacion.Name = "cmbpresentacion";
            this.cmbpresentacion.Size = new System.Drawing.Size(194, 31);
            this.cmbpresentacion.TabIndex = 103;
            this.cmbpresentacion.ValueMember = "IdPresentacion";
            // 
            // presentacionProductoBindingSource
            // 
            this.presentacionProductoBindingSource.DataMember = "PresentacionProducto";
            this.presentacionProductoBindingSource.DataSource = this.altoValyrioDataSet2;
            // 
            // altoValyrioDataSet2
            // 
            this.altoValyrioDataSet2.DataSetName = "AltoValyrioDataSet2";
            this.altoValyrioDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtnombreprod
            // 
            this.txtnombreprod.Font = new System.Drawing.Font("Quicksand Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreprod.Location = new System.Drawing.Point(545, 152);
            this.txtnombreprod.Name = "txtnombreprod";
            this.txtnombreprod.Size = new System.Drawing.Size(285, 26);
            this.txtnombreprod.TabIndex = 102;
            // 
            // txtcodigoprod
            // 
            this.txtcodigoprod.Font = new System.Drawing.Font("Quicksand Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoprod.Location = new System.Drawing.Point(545, 101);
            this.txtcodigoprod.Name = "txtcodigoprod";
            this.txtcodigoprod.Size = new System.Drawing.Size(173, 26);
            this.txtcodigoprod.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Valken", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(356, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 100;
            this.label7.Text = "Refrigeración";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Valken", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 99;
            this.label6.Text = "Bodega";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Valken", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 98;
            this.label5.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Valken", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 97;
            this.label4.Text = "Presentación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Valken", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 96;
            this.label3.Text = "Categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Valken", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 95;
            this.label2.Text = "Nombre Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Valken", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 94;
            this.label1.Text = "Código Producto";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Valken", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(505, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 60);
            this.button1.TabIndex = 93;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoriaProductoTableAdapter
            // 
            this.categoriaProductoTableAdapter.ClearBeforeFill = true;
            // 
            // presentacionProductoTableAdapter
            // 
            this.presentacionProductoTableAdapter.ClearBeforeFill = true;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Valken", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(911, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 69);
            this.button2.TabIndex = 108;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Valken", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(962, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 19);
            this.label8.TabIndex = 109;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(179, 501);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(786, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 110;
            this.pictureBox2.TabStop = false;
            // 
            // FrmIngresoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1105, 652);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbrefrigeracion);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.cmMarca);
            this.Controls.Add(this.cmbpresentacion);
            this.Controls.Add(this.txtnombreprod);
            this.Controls.Add(this.txtcodigoprod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FrmIngresoProducto";
            this.Text = "FrmIngresoProducto";
            this.Load += new System.EventHandler(this.FrmIngresoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altoValyrioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altoValyrioDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altoValyrioDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presentacionProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altoValyrioDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbrefrigeracion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox cmMarca;
        private System.Windows.Forms.ComboBox cmbpresentacion;
        private System.Windows.Forms.TextBox txtnombreprod;
        private System.Windows.Forms.TextBox txtcodigoprod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private AltoValyrioDataSet1 altoValyrioDataSet1;
        private System.Windows.Forms.BindingSource categoriaProductoBindingSource;
        private AltoValyrioDataSet1TableAdapters.CategoriaProductoTableAdapter categoriaProductoTableAdapter;
        private AltoValyrioDataSet2 altoValyrioDataSet2;
        private System.Windows.Forms.BindingSource presentacionProductoBindingSource;
        private AltoValyrioDataSet2TableAdapters.PresentacionProductoTableAdapter presentacionProductoTableAdapter;
        private AltoValyrioDataSet3 altoValyrioDataSet3;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private AltoValyrioDataSet3TableAdapters.MarcaTableAdapter marcaTableAdapter;
        private AltoValyrioDataSet4 altoValyrioDataSet4;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private AltoValyrioDataSet4TableAdapters.BodegaTableAdapter bodegaTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}