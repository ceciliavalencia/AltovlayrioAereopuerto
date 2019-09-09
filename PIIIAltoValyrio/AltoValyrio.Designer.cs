namespace PIIIAltoValyrio
{
    partial class AltoValyrio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltoValyrio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoProductoExistenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trasladoProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarTrasladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarTrasladoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarPorBodegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarPorTrasladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bodegasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altoValyrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCERCADEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Font = new System.Drawing.Font("LetterOMatic!", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.ediciónProductoToolStripMenuItem,
            this.trasladoProductosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.bodegasToolStripMenuItem,
            this.altoValyrioToolStripMenuItem,
            this.aCERCADEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoNuevoToolStripMenuItem,
            this.ingresoProductoExistenteToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.productosToolStripMenuItem.Text = "Producto";
            // 
            // ingresoNuevoToolStripMenuItem
            // 
            this.ingresoNuevoToolStripMenuItem.Name = "ingresoNuevoToolStripMenuItem";
            this.ingresoNuevoToolStripMenuItem.Size = new System.Drawing.Size(344, 26);
            this.ingresoNuevoToolStripMenuItem.Text = "Ingreso Nuevo";
            this.ingresoNuevoToolStripMenuItem.Click += new System.EventHandler(this.ingresoNuevoToolStripMenuItem_Click);
            // 
            // ingresoProductoExistenteToolStripMenuItem
            // 
            this.ingresoProductoExistenteToolStripMenuItem.Name = "ingresoProductoExistenteToolStripMenuItem";
            this.ingresoProductoExistenteToolStripMenuItem.Size = new System.Drawing.Size(344, 26);
            this.ingresoProductoExistenteToolStripMenuItem.Text = "Ingreso Producto existente";
            this.ingresoProductoExistenteToolStripMenuItem.Click += new System.EventHandler(this.ingresoProductoExistenteToolStripMenuItem_Click);
            // 
            // ediciónProductoToolStripMenuItem
            // 
            this.ediciónProductoToolStripMenuItem.Enabled = false;
            this.ediciónProductoToolStripMenuItem.Name = "ediciónProductoToolStripMenuItem";
            this.ediciónProductoToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.ediciónProductoToolStripMenuItem.Text = "Edición Producto";
            this.ediciónProductoToolStripMenuItem.Click += new System.EventHandler(this.ediciónProductoToolStripMenuItem_Click);
            // 
            // trasladoProductosToolStripMenuItem
            // 
            this.trasladoProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarTrasladoToolStripMenuItem,
            this.borrarTrasladoToolStripMenuItem1});
            this.trasladoProductosToolStripMenuItem.Enabled = false;
            this.trasladoProductosToolStripMenuItem.Name = "trasladoProductosToolStripMenuItem";
            this.trasladoProductosToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.trasladoProductosToolStripMenuItem.Text = "Traslado Productos";
            // 
            // borrarTrasladoToolStripMenuItem
            // 
            this.borrarTrasladoToolStripMenuItem.Name = "borrarTrasladoToolStripMenuItem";
            this.borrarTrasladoToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.borrarTrasladoToolStripMenuItem.Text = "Traslado de Producto";
            this.borrarTrasladoToolStripMenuItem.Click += new System.EventHandler(this.borrarTrasladoToolStripMenuItem_Click);
            // 
            // borrarTrasladoToolStripMenuItem1
            // 
            this.borrarTrasladoToolStripMenuItem1.Name = "borrarTrasladoToolStripMenuItem1";
            this.borrarTrasladoToolStripMenuItem1.Size = new System.Drawing.Size(283, 26);
            this.borrarTrasladoToolStripMenuItem1.Text = "Borrar Traslado";
            this.borrarTrasladoToolStripMenuItem1.Click += new System.EventHandler(this.borrarTrasladoToolStripMenuItem1_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarPorBodegaToolStripMenuItem,
            this.generarPorTrasladoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // generarPorBodegaToolStripMenuItem
            // 
            this.generarPorBodegaToolStripMenuItem.Name = "generarPorBodegaToolStripMenuItem";
            this.generarPorBodegaToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.generarPorBodegaToolStripMenuItem.Text = "Generar por bodega";
            this.generarPorBodegaToolStripMenuItem.Click += new System.EventHandler(this.generarPorBodegaToolStripMenuItem_Click);
            // 
            // generarPorTrasladoToolStripMenuItem
            // 
            this.generarPorTrasladoToolStripMenuItem.Name = "generarPorTrasladoToolStripMenuItem";
            this.generarPorTrasladoToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.generarPorTrasladoToolStripMenuItem.Text = "Generar por traslado";
            this.generarPorTrasladoToolStripMenuItem.Click += new System.EventHandler(this.generarPorTrasladoToolStripMenuItem_Click);
            // 
            // bodegasToolStripMenuItem
            // 
            this.bodegasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bodegasToolStripMenuItem.Name = "bodegasToolStripMenuItem";
            this.bodegasToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.bodegasToolStripMenuItem.Text = "Bodegas";
            this.bodegasToolStripMenuItem.Click += new System.EventHandler(this.bodegasToolStripMenuItem_Click);
            // 
            // altoValyrioToolStripMenuItem
            // 
            this.altoValyrioToolStripMenuItem.Name = "altoValyrioToolStripMenuItem";
            this.altoValyrioToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.altoValyrioToolStripMenuItem.Text = "AltoValyrio";
            this.altoValyrioToolStripMenuItem.Click += new System.EventHandler(this.altoValyrioToolStripMenuItem_Click);
            // 
            // aCERCADEToolStripMenuItem
            // 
            this.aCERCADEToolStripMenuItem.Name = "aCERCADEToolStripMenuItem";
            this.aCERCADEToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.aCERCADEToolStripMenuItem.Text = "ACERCA DE";
            this.aCERCADEToolStripMenuItem.Click += new System.EventHandler(this.aCERCADEToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("LetterOMatic!", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1151, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("LetterOMatic!", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(976, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.Font = new System.Drawing.Font("LetterOMatic!", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(415, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cerrar Sesión";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(158, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(688, 340);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // AltoValyrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1080, 609);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AltoValyrio";
            this.Text = "AltoValyrio";
            this.Load += new System.EventHandler(this.AltoValyrio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresoNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoProductoExistenteToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trasladoProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarTrasladoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónProductoToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem borrarTrasladoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generarPorBodegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarPorTrasladoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem bodegasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altoValyrioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCERCADEToolStripMenuItem;
    }
}