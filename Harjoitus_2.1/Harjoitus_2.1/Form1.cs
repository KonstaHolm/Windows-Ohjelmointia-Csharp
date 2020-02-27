using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Harjoitus_2.1";
        }

        public class Book
        {
            private string name;
            private int price;

            public Book()
            {
                name = "Aapinen";
                price = 0;
            }
            
            public Book(string pName, int pPrice)
            {
                name = pName;
                price = pPrice;
            }

            public void SetName(string pName)
            {
                name = pName;
            }
            
            public void SetPrice(int pPrice)
            {
                price = pPrice;
            }

            public string GetName()
            {
                return name;
            }

            public int GetPrice()
            {
                return price;
            }



        }

        private void show_books_button_Click(object sender, EventArgs e)
        {
            Book aapinen = new Book();
            aapinen.SetPrice(20);

            Book koulukirja = new Book("Fysiikka 1", 25);

            int aapinen_hinta = aapinen.GetPrice();
            int koulukirja_hinta = koulukirja.GetPrice();

            string aapinen_nimi = aapinen.GetName();
            string koulukirja_nimi = koulukirja.GetName();

            textBox1.Text = aapinen_hinta.ToString();
            textBox2.Text = aapinen_nimi;
            textBox3.Text = koulukirja_hinta.ToString();
            textBox4.Text = koulukirja_nimi;


        }
    }
}
