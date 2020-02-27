using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitus_3._2
{
    public partial class Form1 : Form
    {
        BookCounter laskuri = new BookCounter();
        public Form1()
        {
            InitializeComponent();
        }

        public class BookCounter
        {
            private const int MAX_BOOK = 100;
            private Book[] bookArray = new Book[MAX_BOOK];
            private int counter = 0;

            //oletuskonstruktori
            public BookCounter()
            {

            }


            //lisää uuden kirja-olion bookarrayhin
            public void addBook(Book kirja)
            {

                bookArray[counter] = (kirja);
                counter++;
            }

            //kirjojen nimet + tekijä otetaan ylös stringiin
            public string printBooks(int i)
            {

                if (bookArray[i] != null)
                {
                    string str1 = bookArray[i].getName();
                    string str2 = bookArray[i].getAuthor();
                    string str3 = str1 + " " + str2 + Environment.NewLine;
                    return str3;
                }
                else { return ""; }

                
            }

        }

        public class Book
        {

            private string name;
            private string author;
            public Book(string cName, string cAuthor)
            {
                name = cName;
                author = cAuthor;
                
            }

            public string getName()
            {
                return name;
            }
            public string getAuthor()
            {
                return author;
            }


        }


        private void save_button_Click(object sender, EventArgs e)
        {
            string str1 = bookName_textbox.Text;
            string str2 = author_textbox.Text;
            Book kirja = new Book(str1, str2);
            laskuri.addBook(kirja);
            author_textbox.Text = "";
            bookName_textbox.Text = "";
            infoLabel.Text = "Book saved";
            


        }

        private void print_button_Click(object sender, EventArgs e)
        {

            for(int i = 0; i<100;i++)
            {
                string str = laskuri.printBooks(i);
                printBox.AppendText(str);
            }
        }
    }
}
