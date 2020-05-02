using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ardunio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
      
        private void Form1_Load(object sender, EventArgs e)

        {
          
            string[] ports = SerialPort.GetPortNames();  //Seri portları diziye ekleme
            foreach (string port in ports)
                comboBox1.Items.Add(port); //Seri portları comBox1' ekleme
            
        }
       
      

        
      
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();  //Eğer port açıksa kapat
        }

       

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.SelectedItem.ToString(); //comboBox1'de seçili olan portu port ismine ata
            serialPort1.Open(); //Seri portu aç
        }

        private void btnSicaklik_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");
            String arduino = serialPort1.ReadLine().ToString();


            lblsicaklik.Text = arduino;

        }

        private void btnNem_Click_1(object sender, EventArgs e)
        {
            serialPort1.Write("1");
            String arduino = serialPort1.ReadLine().ToString();
            lblnem.Text = arduino;
            


            

        }

       
       
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            double sicaklik = Convert.ToDouble(lblsicaklik.Text);
            double nem = Convert.ToDouble(lblnem.Text);
            if (sicaklik > 17.00 && nem > 75)
            {
                lblsonuc.Text = "Uygun Değil";
            }
            else
            {
                lblsonuc.Text = "Uygun";

            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            double sicaklik = Convert.ToDouble(lblsicaklik.Text);
            double nem = Convert.ToDouble(lblnem.Text);
            if (sicaklik > 22.00 && nem > 60)
            {
                lblsonuc.Text = "Uygun Değil";
            }
            else
            {
                lblsonuc.Text = "Uygun";

            }

        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            double sicaklik = Convert.ToDouble(lblsicaklik.Text);
            double nem = Convert.ToDouble(lblnem.Text);
            if (sicaklik > 18.00 && nem > 70)
            {
                lblsonuc.Text = "Uygun Değil";
            }
            else
            {
                lblsonuc.Text = "Uygun";

            }

        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            double sicaklik = Convert.ToDouble(lblsicaklik.Text);
            double nem = Convert.ToDouble(lblnem.Text);
            if (sicaklik > 27.00 && nem > 75)
            {
                lblsonuc.Text = "Uygun";
            }
            else
            {
                lblsonuc.Text = "Uygun Değil";

            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
    
}
