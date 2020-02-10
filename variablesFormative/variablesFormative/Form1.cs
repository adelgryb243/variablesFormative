using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variablesFormative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //wayne gretzky
            string name;
            name = "Wayne Gretzky";

            int number;
            number = 99;
            outputLabel.Text = name + " is number " + number;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //area of a circle
            double radius;
            radius = 15.00;
           
            double pi;
            pi = 3.14;

            double area;
            area = pi *(radius*radius);

            outputLabel.Text = "The area of a circle with the radius of 15cm is " + area;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //carpet cost by area

            double length;
            length = 8.50;

            double width;
            width = 6.00;

            double costPerMetre;
            costPerMetre = 19.95;

            double area;
            area = width * length;

            double totalCost;
            totalCost = area * costPerMetre;

            outputLabel.Text = "The area of a room with the dimensions" + width + " by " + length + " is " + area;




        }

        private void button4_Click(object sender, EventArgs e)
        {
            //bill of sale

            double tax;
            tax = 0.13;

            double price;
            price = 12.49;

            double total;
            total = (price * tax) + price;

            double bill;
            bill = 20.00;

            double change;
            change = bill - total;

            outputLabel.Text = "Bill of sale \n";
            outputLabel.Text = "Shirt:               " + price;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
