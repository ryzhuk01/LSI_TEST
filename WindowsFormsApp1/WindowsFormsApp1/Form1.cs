using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //connection string in properties

            raportTableAdapter.Fill(lSI_TESTDataSet.Raport);

            var lokals = this.lSI_TESTDataSet.Raport.Select(x => x.Lokal).Distinct().ToList();

            foreach (var lokal in lokals)
                comboBox1.Items.Add(lokal);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var options = CheckSelectedOptions();
            switch (options)
            {
                case 1:
                    try
                    {
                        raportTableAdapter.FillByLocal(this.lSI_TESTDataSet.Raport, comboBox1.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                case 2:
                    try
                    {
                        raportTableAdapter.FillByDo(this.lSI_TESTDataSet.Raport, dateTimePicker2.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;


                case 3:
                    try
                    {
                        raportTableAdapter.FillByOdData(this.lSI_TESTDataSet.Raport, dateTimePicker1.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                case 4:
                    try
                    {
                        raportTableAdapter.FillByLokalAndDo(this.lSI_TESTDataSet.Raport, comboBox1.Text, dateTimePicker2.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                case 5:
                    try
                    {
                        raportTableAdapter.FillByLocalAndOd(this.lSI_TESTDataSet.Raport, comboBox1.Text, dateTimePicker1.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                case 6:
                    try
                    {
                        raportTableAdapter.FillByDoAndOd(this.lSI_TESTDataSet.Raport, dateTimePicker1.Text, dateTimePicker2.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                case 7:
                    try
                    {
                        raportTableAdapter.FilterByDataAndLocal(this.lSI_TESTDataSet.Raport, dateTimePicker2.Text, dateTimePicker1.Text, comboBox1.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        int CheckSelectedOptions()
        {
            //only local
            if (!string.IsNullOrEmpty(comboBox1.Text) && string.IsNullOrEmpty(dateTimePicker2.Text) && string.IsNullOrEmpty(dateTimePicker1.Text))
                return 1;

            //only do
            if (string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(dateTimePicker2.Text) && string.IsNullOrEmpty(dateTimePicker1.Text))
                return 2;

            //only od
            if (string.IsNullOrEmpty(comboBox1.Text) && string.IsNullOrEmpty(dateTimePicker2.Text) && !string.IsNullOrEmpty(dateTimePicker1.Text))
                return 3;

            //local + do
            if (!string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(dateTimePicker2.Text) && string.IsNullOrEmpty(dateTimePicker1.Text))
                return 4;

            //local + od
            if (!string.IsNullOrEmpty(comboBox1.Text) && string.IsNullOrEmpty(dateTimePicker2.Text) && !string.IsNullOrEmpty(dateTimePicker1.Text))
                return 5;

            //do + od
            if (string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(dateTimePicker2.Text) && !string.IsNullOrEmpty(dateTimePicker1.Text))
                return 6;

            //local + od+ do
            if (!(string.IsNullOrEmpty(dateTimePicker2.Text) || string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(comboBox1.Text)))
                return 7;

            return 0;
        }
    }
}

