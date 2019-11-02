﻿using System;
using System.Data;
using System.Windows.Forms;
using SegundoParcial.Models;
using SegundoParcial.Services;
using SegundoParcial.Director;

namespace SegundoParcial
{
    public partial class Inicio : Form
    {
        DataTable Tabla;
        Dato.Usuario Dato = new Dato.Usuario();
        string ciudad;
        string temper;

        public Inicio(string nombre)
        {
            InitializeComponent();
            lbUsername.Text = nombre;
            panelSearch.Visible = false;
            panelDataGreed.Visible = false;
            panelCityForechast.Visible = false;
            Iniciar();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = true;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Form1 frm2 = new Form1();
            this.Hide();
            frm2.Show();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSearchCity_Click(object sender, EventArgs e)
        {
            Guardar();
            Iniciar();
            Consultar();
            //ciudad = comboBoxCities.Text.ToString();
            //ciudad = comboBoxCities.SelectedItem.ToString();
            /*Console.WriteLine($"Ciudad:{response.name}");
            Console.WriteLine($"Temperatura:{response.main.temp}");
            Console.WriteLine($"Max:{response.main.temp_max}");
            Console.WriteLine($"Min:{response.main.temp_min}");
            Console.ReadKey();*/
            panelDataGreed.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            panelDataGreed.Visible = false;
            panelSearch.Visible = false;
            panelCityForechast.Visible = false;
        }

        private void Iniciar()
        {
            Tabla = new DataTable();
            Tabla.Columns.Add("Ciudad");
            Tabla.Columns.Add("Temperatura");
            Tabla.Columns.Add("Max");
            Tabla.Columns.Add("Min");
            dataGridViewCities.DataSource = Tabla;
        }
        private void Guardar()
        {
            lbCity.Text = comboBoxCities.Text;
            IProxy proxy = new Proxy();
            var response = proxy.weather("rome");
            Random rnd = new Random();
            int temperatura = rnd.Next(9, 31);
            int max = rnd.Next(temperatura, 31);
            int min = rnd.Next(9, temperatura);
            int hum = rnd.Next(25, 75);
            int vie = rnd.Next(1, 34);
            int lun = rnd.Next(min, max);
            int mar = rnd.Next(min, max);
            int mie = rnd.Next(min, max);
            int jue = rnd.Next(min, max);
            ciudad = $"Ciudad:{response.name}";
            //temperatura = response.main.temp;
            //max = $"Max:{response.main.temp_max}";
            //min = $"Min:{response.main.temp_min}";
            var admi = new Admi();
            Citi cit = null;
            cit = new Citi { Ciudad = comboBoxCities.Text, Temperatura = temperatura.ToString(), Min = min.ToString(), Max = max.ToString()};
            //cit = new Citi { Ciudad = ciudad, Temperatura = $"Temperatura:{response.main.temp}", Min = $"Min:{response.main.temp_min}", Max = $"Max:{response.main.temp_max}" };
            Dato.Guardar(cit);
        }

        private void Consultar()
        {
            foreach (var item in Dato.ConsultarH())
            {
                DataRow fila = Tabla.NewRow();
                fila["Ciudad"] = item.Ciudad;
                fila["Temperatura"] = item.Temperatura;
                fila["Max"] = item.Max;
                fila["Min"] = item.Min;
                Tabla.Rows.Add(fila);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnForechast_Click(object sender, EventArgs e)
        {
            panelCityForechast.Visible = true;
        }

        private void DataGridViewCityForechast_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
