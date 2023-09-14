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
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.btReload = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabSoci.SuspendLayout();
            this.tabSegreteria.SuspendLayout();
            this.tabPrestazioni.SuspendLayout();
            this.tabDebito.SuspendLayout();
            this.tabAdd.SuspendLayout();
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
            this.lstDebito.Size = new System.Drawing.Size(439, 180);
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
            this.tabControl1.Controls.Add(this.tabAdd);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(447, 414);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.btnReload_Click);
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
            this.tabSegreteria.Size = new System.Drawing.Size(439, 385);
            this.tabSegreteria.TabIndex = 1;
            this.tabSegreteria.Text = "Segreteria";
            this.tabSegreteria.UseVisualStyleBackColor = true;
            // 
            // tabPrestazioni
            // 
            this.tabPrestazioni.Controls.Add(this.lstPrestazioni);
            this.tabPrestazioni.Location = new System.Drawing.Point(4, 25);
            this.tabPrestazioni.Name = "tabPrestazioni";
            this.tabPrestazioni.Size = new System.Drawing.Size(439, 385);
            this.tabPrestazioni.TabIndex = 2;
            this.tabPrestazioni.Text = "Prestazioni";
            this.tabPrestazioni.UseVisualStyleBackColor = true;
            // 
            // tabDebito
            // 
            this.tabDebito.Controls.Add(this.listBox1);
            this.tabDebito.Controls.Add(this.button2);
            this.tabDebito.Controls.Add(this.lstDebito);
            this.tabDebito.Location = new System.Drawing.Point(4, 25);
            this.tabDebito.Name = "tabDebito";
            this.tabDebito.Size = new System.Drawing.Size(439, 385);
            this.tabDebito.TabIndex = 3;
            this.tabDebito.Text = "Debito";
            this.tabDebito.UseVisualStyleBackColor = true;
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.comboBox1);
            this.tabAdd.Controls.Add(this.label4);
            this.tabAdd.Controls.Add(this.label3);
            this.tabAdd.Controls.Add(this.label2);
            this.tabAdd.Controls.Add(this.label1);
            this.tabAdd.Controls.Add(this.textBox3);
            this.tabAdd.Controls.Add(this.textBox2);
            this.tabAdd.Controls.Add(this.textBox1);
            this.tabAdd.Controls.Add(this.button1);
            this.tabAdd.Location = new System.Drawing.Point(4, 25);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Size = new System.Drawing.Size(439, 385);
            this.tabAdd.TabIndex = 4;
            this.tabAdd.Text = "Aggiungi SOCIO";
            this.tabAdd.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aggiungi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 22);
            this.textBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cognome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Zona";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Treviolo",
            "Albegno",
            "Roncola",
            "Curnasco"});
            this.comboBox1.Location = new System.Drawing.Point(121, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(432, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Visualizza tutti i saldi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 221);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(439, 164);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(467, 456);
            this.Controls.Add(this.btReload);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Banca del Tempo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSoci.ResumeLayout(false);
            this.tabSegreteria.ResumeLayout(false);
            this.tabPrestazioni.ResumeLayout(false);
            this.tabDebito.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
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
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
    }
}
