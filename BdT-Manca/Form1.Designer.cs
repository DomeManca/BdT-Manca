namespace BdT_Manca
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Metodi come nella versione precedente

        private void InitializeComponent()
        {
            this.lstSoci = new System.Windows.Forms.ListBox();
            this.lstDebito = new System.Windows.Forms.ListBox();
            this.lstSegreteria = new System.Windows.Forms.ListBox();
            this.lstPrestazioni = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSoci = new System.Windows.Forms.TabPage();
            this.tabSegreteria = new System.Windows.Forms.TabPage();
            this.tabPrestazioni = new System.Windows.Forms.TabPage();
            this.tabDebito = new System.Windows.Forms.TabPage();
            this.btReload = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabSoci.SuspendLayout();
            this.tabSegreteria.SuspendLayout();
            this.tabPrestazioni.SuspendLayout();
            this.tabDebito.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSoci
            // 
            this.lstSoci.ItemHeight = 16;
            this.lstSoci.Location = new System.Drawing.Point(0, 0);
            this.lstSoci.Name = "lstSoci";
            this.lstSoci.Size = new System.Drawing.Size(439, 388);
            this.lstSoci.TabIndex = 0;
            // 
            // lstDebito
            // 
            this.lstDebito.ItemHeight = 16;
            this.lstDebito.Location = new System.Drawing.Point(0, 0);
            this.lstDebito.Name = "lstDebito";
            this.lstDebito.Size = new System.Drawing.Size(439, 388);
            this.lstDebito.TabIndex = 2;
            // 
            // lstSegreteria
            // 
            this.lstSegreteria.ItemHeight = 16;
            this.lstSegreteria.Location = new System.Drawing.Point(0, 0);
            this.lstSegreteria.Name = "lstSegreteria";
            this.lstSegreteria.Size = new System.Drawing.Size(443, 388);
            this.lstSegreteria.TabIndex = 4;
            // 
            // lstPrestazioni
            // 
            this.lstPrestazioni.ItemHeight = 16;
            this.lstPrestazioni.Location = new System.Drawing.Point(0, 0);
            this.lstPrestazioni.Name = "lstPrestazioni";
            this.lstPrestazioni.Size = new System.Drawing.Size(439, 388);
            this.lstPrestazioni.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSoci);
            this.tabControl1.Controls.Add(this.tabSegreteria);
            this.tabControl1.Controls.Add(this.tabPrestazioni);
            this.tabControl1.Controls.Add(this.tabDebito);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(447, 414);
            this.tabControl1.TabIndex = 8;
            // 
            // tabSoci
            // 
            this.tabSoci.Controls.Add(this.lstSoci);
            this.tabSoci.Location = new System.Drawing.Point(4, 25);
            this.tabSoci.Name = "tabSoci";
            this.tabSoci.Padding = new System.Windows.Forms.Padding(3);
            this.tabSoci.Size = new System.Drawing.Size(439, 385);
            this.tabSoci.TabIndex = 0;
            this.tabSoci.Text = "Soci";
            this.tabSoci.UseVisualStyleBackColor = true;
            // 
            // tabSegreteria
            // 
            this.tabSegreteria.Controls.Add(this.lstSegreteria);
            this.tabSegreteria.Location = new System.Drawing.Point(4, 25);
            this.tabSegreteria.Name = "tabSegreteria";
            this.tabSegreteria.Padding = new System.Windows.Forms.Padding(3);
            this.tabSegreteria.Size = new System.Drawing.Size(439, 392);
            this.tabSegreteria.TabIndex = 1;
            this.tabSegreteria.Text = "Segreteria";
            this.tabSegreteria.UseVisualStyleBackColor = true;
            // 
            // tabPrestazioni
            // 
            this.tabPrestazioni.Controls.Add(this.lstPrestazioni);
            this.tabPrestazioni.Location = new System.Drawing.Point(4, 25);
            this.tabPrestazioni.Name = "tabPrestazioni";
            this.tabPrestazioni.Size = new System.Drawing.Size(439, 392);
            this.tabPrestazioni.TabIndex = 2;
            this.tabPrestazioni.Text = "Prestazioni";
            this.tabPrestazioni.UseVisualStyleBackColor = true;
            // 
            // tabDebito
            // 
            this.tabDebito.Controls.Add(this.lstDebito);
            this.tabDebito.Location = new System.Drawing.Point(4, 25);
            this.tabDebito.Name = "tabDebito";
            this.tabDebito.Size = new System.Drawing.Size(439, 392);
            this.tabDebito.TabIndex = 3;
            this.tabDebito.Text = "Debito";
            this.tabDebito.UseVisualStyleBackColor = true;
            // 
            // btReload
            // 
            this.btReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReload.Location = new System.Drawing.Point(16, 432);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(439, 18);
            this.btReload.TabIndex = 9;
            this.btReload.Text = "Reload";
            this.btReload.UseVisualStyleBackColor = true;
            this.btReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(467, 456);
            this.Controls.Add(this.btReload);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Banca del Tempo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSoci.ResumeLayout(false);
            this.tabSegreteria.ResumeLayout(false);
            this.tabPrestazioni.ResumeLayout(false);
            this.tabDebito.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // Definizione dei controlli dell'interfaccia grafica qui
        private System.Windows.Forms.ListBox lstSoci;
        private System.Windows.Forms.ListBox lstDebito;
        private System.Windows.Forms.ListBox lstSegreteria;
        private System.Windows.Forms.ListBox lstPrestazioni;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSoci;
        private System.Windows.Forms.TabPage tabSegreteria;
        private System.Windows.Forms.TabPage tabPrestazioni;
        private System.Windows.Forms.TabPage tabDebito;
        private System.Windows.Forms.Button btReload;
    }
}
