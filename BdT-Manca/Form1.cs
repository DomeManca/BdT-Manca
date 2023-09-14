using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BdT_Manca
{
    public partial class Form1 : Form
    {
        public List<Socio> soci = new List<Socio>();
        public List<Prestazione> prestazioni = new List<Prestazione>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void LoadData()
        {
            // Caricare dati da file JSON
            if (File.Exists("soci.json"))
            {
                string sociJson = File.ReadAllText("soci.json");
                soci = JsonConvert.DeserializeObject<List<Socio>>(sociJson);
            }

            if (File.Exists("prestazioni.json"))
            {
                string prestazioniJson = File.ReadAllText("prestazioni.json");
                prestazioni = JsonConvert.DeserializeObject<List<Prestazione>>(prestazioniJson);
            }
        }

        private void UpdateUI()
        {
            // Aggiornare la visualizzazione dei dati nell'interfaccia grafica
            lstSoci.Items.Clear();
            foreach (Socio socio in soci)
            {
                lstSoci.Items.Add($"{socio.Cognome}, {socio.Nome} - Tel: {socio.Telefono} | Zona: {socio.Zona}");
            }
        }

        public void CalcDebito()
        {
            // Logica per produrre l'elenco dei soci con debito
            List<Socio> debitori = soci.Where(s => s.CalcolaDebito() > 0 ).ToList();

            lstDebito.Items.Clear();
            foreach (Socio debitor in debitori)
            {
                lstDebito.Items.Add($"{debitor.Cognome}, {debitor.Nome} | Debito: {debitor.Debito}");
            }
        }

        public void CalcSegreteria()
        {
            // Logica per visualizzare i soci della segreteria
            List<Socio> segreteriaSoci = soci.Where(s => s.Segreteria).ToList();

            lstSegreteria.Items.Clear();
            foreach (Socio segreteriaSocio in segreteriaSoci)
            {
                lstSegreteria.Items.Add($"{segreteriaSocio.Cognome}, {segreteriaSocio.Nome} - Tel: {segreteriaSocio.Telefono}");
            }
        }

        public void CalcPrestazioni()
        {
            // Logica per ordinare e visualizzare le prestazioni
            List<Prestazione> prestazioniOrdinate = prestazioni.OrderByDescending(p => p.Ore).ToList();

            lstPrestazioni.Items.Clear();
            foreach (Prestazione prestazione in prestazioniOrdinate)
            {
                lstPrestazioni.Items.Add($"{prestazione.Erogatore.Cognome}, {prestazione.Erogatore.Nome} -> {prestazione.Ricevente.Cognome}, {prestazione.Ricevente.Nome} - {prestazione.Ore} ore di {prestazione.Tipo}");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
        }
        public void Reload()
        {
            LoadData();
            UpdateUI();
            CalcDebito();
            CalcPrestazioni();
            CalcSegreteria();
            listBox1.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = comboBox1.Items[0].ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
             bool done = true;
             double newphone;
             if (String.IsNullOrWhiteSpace(textBox1.Text))
             {
                done = false;
                MessageBox.Show("Cognome non valido");
             }
             if (String.IsNullOrWhiteSpace(textBox2.Text))
             {
                done = false;
                MessageBox.Show("Nome non valido");
            }
            if (String.IsNullOrWhiteSpace(textBox3.Text) || textBox3.Text.Length != 10)
            {
                try
                {
                    newphone = double.Parse(textBox3.Text);
                }
                catch
                {
                    done = false;
                    MessageBox.Show("Telefono non valido");
                }
            }
            if (comboBox1.Text == string.Empty)
            {
                done = false;
                MessageBox.Show("Zona non valida");
            }
            if (done)
            {
                Socio nuovo = new Socio(textBox1.Text, textBox2.Text, double.Parse(textBox3.Text),0, comboBox1.Text,false);
                Aggiungi(nuovo);
                MessageBox.Show("Aggiunta eseguita con SUCCESSO");
            }
        }
        public static void Aggiungi(Socio nuovo)
        {
            var N = new FileStream(@"soci.json", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            N.Close();
            StreamReader sr = new StreamReader(@"soci.json");
            StreamWriter sw = new StreamWriter(@"./soci2.json");

            string line = "";
            int i = 0;

            while (!sr.EndOfStream || i != 1)
            {
                line = sr.ReadLine();

                if (line != null && i == 0 && line != "]")
                {
                        sw.WriteLine(line);
                }
                else if(line == "]")
                {
                        sw.WriteLine(",");
                        //aggiunta classe jsonata
                        string jsonString = JsonConvert.SerializeObject(nuovo, Formatting.None);
                        sw.WriteLine(jsonString);
                        sw.WriteLine("]");
                        i = 1;
                }
            }
            sr.Close();
            sw.Close();

            System.IO.File.Delete(@"soci.json");
            System.IO.File.Move(@"./soci2.json", @"soci.json");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Logica per produrre l'elenco dei saldi dei soci
            listBox1.Items.Clear();
            foreach (Socio debitor in soci)
            {
                listBox1.Items.Add($"{debitor.Cognome}, {debitor.Nome} | Saldo: {-debitor.Debito}");
            }
        }
    }
}
