using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoroscopeChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
          //  DateTime expiryday = new DateTime();

            string month = cmbMonth.Text;
            int day = int.Parse(txtDay.Text);
            // check for empty fields

            if (month == "" || day <= 0 )
            {
                MessageBox.Show("Invalid, Please Fill all required fields, error");
            }
            // Throw an exception if day entered is more than days in the actual month
            //try
            //{
            //    if (day > expiryday.() Day)

            //    {


            //    }

            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            if ((month == "January" && (day >= 20 || day <= 31) ) || (month == "Febuary" && day <= 18 ))
            {
                MessageBox.Show("Your Horoscope is aquarius \n \n INFO: Water zodiacSigns are exceptionally emotional and ultra - sensitive.They are highly intuitive and they can be as mysterious as the ocean itself.");

            }
            else if ((month == "Febuary" && (day >= 19 || day <= 29)) || (month == "March" && day <= 20) )
            {
                MessageBox.Show("Your Horoscope is pisces \n\n INFO : Water zodiacSigns are exceptionally emotional and ultra-sensitive. They are highly intuitive and they can be as mysterious as the ocean itself.");
            }
            else if ((month == "March" && (day >= 21 || day <= 31)) || (month == "April" && day <= 19))
            {
                MessageBox.Show("Your Horoscope is Aries\n\n INFO : Fire zodiacSigns tend to be passionate, dynamic, and temperamental. They get angry quickly, but they also forgive easily.");

            }
            else if ((month == "April" && (day >= 20 || day <= 30)) || (month == "May" && day <= 20))
            {
                MessageBox.Show("Your Horoscope is Taurus\n\n INFO : Earth zodiacSigns are “grounded” and the ones that bring us down to earth. They are mostly conservative and realistic, but they can also be very emotional.");

            }
            else if ((month == "May" && (day >= 21 || day <= 31)) || (month == "June" && day <= 20))
            {
                MessageBox.Show("Your Horoscope is Gemini\n\n INFO : Air zodiacSigns are rational, social, and love communication and relationships with other people. They are thinkers, friendly, intellectual, communicative and analytical.");

            }
            else if ((month == "June" &&( day >= 21 || day <= 30)) || (month == "July" && day <= 22))
            {
                MessageBox.Show("Your Horoscope is Cancer\n\n INFO : Water zodiacSigns are exceptionally emotional and ultra-sensitive. They are highly intuitive and they can be as mysterious as the ocean itself.");

            }
            else if ((month == "July" && (day >= 23 || day <= 31)) || (month == "August" && day <= 22))
            {
                MessageBox.Show("Your Horoscope is Leo\n\n INFO : Air zodiacSigns are rational, social, and love communication and relationships with other people. They are thinkers, friendly, intellectual, communicative and analytical.");

            }
            else if ((month == "August" && (day >= 23 || day <= 31)) || (month == "September" && day <= 22))
            {
                MessageBox.Show("Your Horoscope is Virgo\n\n INFO : Earth zodiacSigns are “grounded” and the ones that bring us down to earth. They are mostly conservative and realistic, but they can also be very emotional.");

            }
            else if ((month == "September" && (day >= 23 || day <= 30)) || (month == "October" && day <= 22))
            {
                MessageBox.Show("Your Horoscope is Libra\n\n INFO : Air zodiacSigns are rational, social, and love communication and relationships with other people. They are thinkers, friendly, intellectual, communicative and analytical.");

            }
            else if ((month == "October" && (day >= 23 || day <= 31)) || (month == "November" && day <= 21))
            {
                MessageBox.Show("Your Horoscope is Scorpio\n\n INFO : Water zodiacSigns are exceptionally emotional and ultra-sensitive. They are highly intuitive and they can be as mysterious as the ocean itself.");

            }
            else if ((month == "November" && (day >= 22 || day <= 30)) || (month == "December" && day <= 21))
            {
                MessageBox.Show("Your Horoscope is Sagittarius\n\n INFO : Fire zodiacSigns tend to be passionate, dynamic, and temperamental. They get angry quickly, but they also forgive easily.");

            }
            else if ((month == "December" && (day >= 22 || day <= 31)) || (month == "January" && day <= 19))
            {
                MessageBox.Show("Your Horoscope is Capricorn\n\n INFO : Earth zodiacSigns are “grounded” and the ones that bring us down to earth. They are mostly conservative and realistic, but they can also be very emotional.");

            }

        }
    }
}
