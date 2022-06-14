using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace MarianHasyak_AgencjaPracy
{
    public abstract class Klient : IComparable<Klient>
    {
        protected DateTime birthday;
        protected Bitmap photo;
        protected int id;
        protected string pesel;
        protected int yearBorn;
        protected string name;
        protected string surname;
        protected string country;
        protected string city;
        protected string email;
        protected float rating;

        protected static int amountOfKlients = 0;


        public Klient()
        {
            amountOfKlients++;
            this.id = amountOfKlients;
            this.pesel = "01938538299";
            this.yearBorn = 2002;
            this.name = "Eryk";
            this.surname = "Botkowski";
            this.country = "Poland";
            this.city = "Opole";
            this.email = "erykbytkowski@mail.com";
            this.rating = 8f;
            this.birthday = new DateTime(11/02);
        }

        //Parametrized constructor
        public Klient(string pesel, int yearBorn, string name, string surname, string country, string city, string email, float rating, DateTime birthday, Bitmap photo)
        {
            amountOfKlients++;
            this.id = amountOfKlients;
            this.pesel = pesel;
            this.yearBorn = yearBorn;
            this.name = name;
            this.surname = surname;
            this.country = country;
            this.city = city;
            this.email = email;
            this.rating = rating;
            this.birthday = birthday;
            this.photo = photo;
        }

        //Duplicating constructor
        public Klient(Klient klient)
        {
            amountOfKlients++;
            this.id = amountOfKlients;
            this.pesel = klient.pesel;
            this.yearBorn = klient.yearBorn;
            this.name = klient.name;
            this.surname = klient.surname;
            this.country = klient.country;
            this.city = klient.city;
            this.email = klient.email;
            this.rating = klient.rating;
            this.birthday = klient.birthday;
            this.photo = klient.photo;
        }

        //Destructor
        ~Klient()
        {
            MessageBox.Show("Destruction of the object");
        }

        virtual public void Write(ListBox lb)
        {
            lb.Items.Add("ID:\t" + id);
            lb.Items.Add("Pesel:\t" + pesel);
            lb.Items.Add("Year born:\t" + yearBorn);
            lb.Items.Add("Birthday:\t" + birthday.ToString("dd/MM"));
            lb.Items.Add("Age:\t" + CalculateAge());
            lb.Items.Add("Name:\t" + name);
            lb.Items.Add("Surname:\t" + surname);
            lb.Items.Add("Location:\t" + ReturnLocation());
            lb.Items.Add("E-mail:\t" + email);
            lb.Items.Add("Rating:\t" + rating);
        }

        virtual public void Write(ListBox lb, PictureBox pb)
        {
            lb.Items.Add("ID:\t" + id);
            lb.Items.Add("Pesel:\t" + pesel);
            lb.Items.Add("Year born:\t" + yearBorn);
            lb.Items.Add("Birthday:\t" + birthday.ToString("dd/MM"));
            lb.Items.Add("Age:\t" + CalculateAge());
            lb.Items.Add("Name:\t" + name);
            lb.Items.Add("Surname:\t" + surname);
            lb.Items.Add("Location:\t" + ReturnLocation());
            lb.Items.Add("E-mail:\t" + email);
            lb.Items.Add("Rating:\t" + rating);
            pb.Image = photo;
        }

        public void WriteSlim(ListBox lb)
        {
            lb.Items.Add(surname + " " + name + ", rating: " + rating);
        }

        public abstract void WriteLV(ListView lV);

        public bool WhereName(string phrase)
        {
            string n1 = name + surname;
            return n1.Contains(phrase);
        }

        public bool WhereAge(int from, int to)
        {
            return (rating >= from && rating <= to);
        }

        public float Rating()
        {
            return this.rating;
        }

        protected int CalculateAge()
        {
            return DateTime.Now.Year - yearBorn;
        }

        protected string ReturnLocation()
        {
            return city + ", " + country;
        }

        public virtual void WriteToFile (StreamWriter sw)
        {

        }

        public virtual void ReadFromFile(StreamReader sr)
        {

        }

        public int CompareTo(Klient other)
        {
            if (other == null)
                return 1;
            
            if (String.Compare(this.surname, other.surname) == 1)
                return 1;
            else if (String.Compare(this.surname, other.surname) == -1)
                return -1;
            else
            {
                if (String.Compare(this.name, other.name) == 1)
                    return 1;
                else if (String.Compare(this.name, other.name) == -1)
                    return -1;
                else
                {
                    if (this.rating > other.rating)
                        return 1;
                    else if (this.rating < other.rating)
                        return -1;
                    return 0;
                }
            }

        }
    }
}
