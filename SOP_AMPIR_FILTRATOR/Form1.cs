using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System;
using WindowsFormsApp1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CsvHelper;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SOP_AMPIR_FILTRATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Requests requests = new Requests();
            Members members = new Members();
            string result = "";
            richTextBox1.Text = "";
            foreach (var mem in requests.AgeSorting(members.AllMmbrs(), int.Parse(textBox1.Text)))
            {
                result += $"Имя члена отряда: {mem.Name}, пол: {mem.Gender}, возраст: {mem.Age}, дата рождения: {mem.Birthday}, номер телефона: {mem.PhoneNumber}." +
                    $" Обучается в группе {mem.Course}-{mem.Faculty}-{mem.Group}.\n";
            }
            richTextBox1.Text = result;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Requests requests = new Requests();
            Members members = new Members();
            string result = "";
            richTextBox1.Text = "";
            foreach (var mem in requests.FacultySorting(members.AllMmbrs(), (textBox2.Text)))
            {
                result += $"Имя члена отряда: {mem.Name}, пол: {mem.Gender}, возраст: {mem.Age}, дата рождения: {mem.Birthday}, номер телефона: {mem.PhoneNumber}." +
                    $" Обучается в группе {mem.Course}-{mem.Faculty}-{mem.Group}.\n";
            }
            richTextBox1.Text = result;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Requests requests = new Requests();
            Members members = new Members();
            string result = "";
            richTextBox1.Text = "";
            foreach (var mem in requests.CourseSorting(members.AllMmbrs(), int.Parse(textBox3.Text)))
            {
                result += $"Имя члена отряда: {mem.Name}, пол: {mem.Gender}, возраст: {mem.Age}, дата рождения: {mem.Birthday}, номер телефона: {mem.PhoneNumber}." +
                    $" Обучается в группе {mem.Course}-{mem.Faculty}-{mem.Group}.\n";
            }
            richTextBox1.Text = result;
        }

    }
}