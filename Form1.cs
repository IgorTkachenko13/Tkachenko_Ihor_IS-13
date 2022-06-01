using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using Newtonsoft.Json;

namespace lab1
{
    
    public partial class Form1 : Form
    {
        Worker Worker = new Worker();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Worker.firstName = textBox1.Text;
            Worker.lastName = textBox2.Text;
            Worker.ratePerDay = int.Parse(textBox3.Text);
            Worker.numberOfDaysWorked = int.Parse(textBox4.Text);

            textBox5.Text = Convert.ToString(Worker.salary(Worker.ratePerDay, Worker.numberOfDaysWorked));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string objectSerialized = JsonConvert.SerializeObject(Worker);
            File.WriteAllText("worker.json", objectSerialized);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Worker = JsonConvert.DeserializeObject<Worker>(File.ReadAllText("worker.json"));
            textBox5.Text = Convert.ToString(Worker.salary(Worker.ratePerDay, Worker.numberOfDaysWorked));
            textBox1.Text = Worker.firstName;
            textBox2.Text = Worker.lastName;
            textBox3.Text = Worker.ratePerDay.ToString();
            textBox4.Text = Worker.numberOfDaysWorked.ToString();

        }
    }
}
