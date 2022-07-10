namespace WindowsFormsApp2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnregre = new System.Windows.Forms.ToolStripButton();
            this.btnConti = new System.Windows.Forms.ToolStripButton();
            this.btnactualizar = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.btnhom = new System.Windows.Forms.ToolStripButton();
            this.webBrow = new System.Windows.Forms.ToolStripTextBox();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.cmbFav = new System.Windows.Forms.ToolStripComboBox();
            this.btnFav = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnregre,
            this.btnConti,
            this.btnactualizar,
            this.btnStop,
            this.btnhom,
            this.webBrow,
            this.btnBuscar,
            this.cmbFav,
            this.btnFav});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1182, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnregre
            // 
            this.btnregre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnregre.Image = ((System.Drawing.Image)(resources.GetObject("btnregre.Image")));
            this.btnregre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnregre.Name = "btnregre";
            this.btnregre.Size = new System.Drawing.Size(23, 22);
            this.btnregre.Text = "toolStripButton1";
            this.btnregre.Click += new System.EventHandler(this.btnregre_Click);
            // 
            // btnConti
            // 
            this.btnConti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConti.Image = ((System.Drawing.Image)(resources.GetObject("btnConti.Image")));
            this.btnConti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConti.Name = "btnConti";
            this.btnConti.Size = new System.Drawing.Size(23, 22);
            this.btnConti.Text = "toolStripButton1";
            this.btnConti.Click += new System.EventHandler(this.btnConti_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnactualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.Image")));
            this.btnactualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(23, 22);
            this.btnactualizar.Text = "toolStripButton1";
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(23, 22);
            this.btnStop.Text = "toolStripButton1";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnhom
            // 
            this.btnhom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnhom.Image = ((System.Drawing.Image)(resources.GetObject("btnhom.Image")));
            this.btnhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnhom.Name = "btnhom";
            this.btnhom.Size = new System.Drawing.Size(23, 22);
            this.btnhom.Text = "toolStripButton1";
            this.btnhom.Click += new System.EventHandler(this.btnhom_Click);
            // 
            // webBrow
            // 
            this.webBrow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.webBrow.Name = "webBrow";
            this.webBrow.Size = new System.Drawing.Size(600, 25);
            this.webBrow.Click += new System.EventHandler(this.webBrow_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 22);
            this.btnBuscar.Text = "toolStripButton1";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbFav
            // 
            this.cmbFav.Name = "cmbFav";
            this.cmbFav.Size = new System.Drawing.Size(121, 25);
            this.cmbFav.SelectedIndexChanged += new System.EventHandler(this.cmbFav_SelectedIndexChanged);
            // 
            // btnFav
            // 
            this.btnFav.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFav.Image = ((System.Drawing.Image)(resources.GetObject("btnFav.Image")));
            this.btnFav.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFav.Name = "btnFav";
            this.btnFav.Size = new System.Drawing.Size(23, 22);
            this.btnFav.Text = "toolStripButton1";
            this.btnFav.Click += new System.EventHandler(this.btnFav_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1182, 521);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 546);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = " Ahslx Bro";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripButton btnregre;
        private System.Windows.Forms.ToolStripButton btnConti;
        private System.Windows.Forms.ToolStripButton btnactualizar;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripButton btnhom;
        private System.Windows.Forms.ToolStripTextBox webBrow;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripComboBox cmbFav;
        private System.Windows.Forms.ToolStripButton btnFav;
    }
}

