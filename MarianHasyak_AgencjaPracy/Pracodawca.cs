using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace MarianHasyak_AgencjaPracy
{
    class Pracodawca:Klient
    {
        //
        string offeringTypeOfJob;
        int amountOfEmployeesNeeded;
        bool educationNeeded;
        bool experienceNeeded;

        //Default constructor
        public Pracodawca() : base()
        {
            this.offeringTypeOfJob = "programmer";
            this.amountOfEmployeesNeeded = 1;
            this.educationNeeded = false;
            this.experienceNeeded = false;
        }

        //Parametrized constructor
        public Pracodawca(string pesel, int yearBorn, string name, string surname, string country, string city, string email, float rating, DateTime birthday, Bitmap photo, string offeringTypeOfJob, int amountOfEmployeesNeeded, bool educationNeeded, bool experienceNeeded) : base(pesel, yearBorn, name, surname, country, city, email, rating, birthday, photo)
        {
            this.offeringTypeOfJob = offeringTypeOfJob;
            this.amountOfEmployeesNeeded = amountOfEmployeesNeeded;
            this.educationNeeded = educationNeeded;
            this.experienceNeeded = experienceNeeded;
        }

        //Duplicating constructor
        public Pracodawca(Pracodawca pracodawca) : base(pracodawca)
        {
            this.offeringTypeOfJob = pracodawca.offeringTypeOfJob;
            this.amountOfEmployeesNeeded = pracodawca.amountOfEmployeesNeeded;
            this.educationNeeded = pracodawca.educationNeeded;
            this.experienceNeeded = pracodawca.experienceNeeded;
        }

        override public void Write(ListBox lb)
        {
            base.Write(lb);
            lb.Items.Add("Offer:\t" + ReturnOffer());
            lb.Items.Add("Type of employee(s) needed:\t" + TypeOfEployeeNeeded());
        }

        private string ReturnOffer()
        {
            if(amountOfEmployeesNeeded == 1) return amountOfEmployeesNeeded + offeringTypeOfJob + " needed";
            else return amountOfEmployeesNeeded + offeringTypeOfJob + "s needed";
        }

        private string TypeOfEployeeNeeded()
        {
            if (educationNeeded && experienceNeeded) return "Educated and experienced candidates";
            else if (educationNeeded && !experienceNeeded) return "Educated candidates";
            else if (!educationNeeded && experienceNeeded) return "Experienced candidates";
            else return "Any candidates";
        }

        public static bool operator==(Pracodawca pd1, Pracodawca pd2)
        {
            if (pd1.offeringTypeOfJob == pd2.offeringTypeOfJob && pd1.amountOfEmployeesNeeded == pd2.amountOfEmployeesNeeded && pd1.educationNeeded == pd2.educationNeeded && pd1.experienceNeeded == pd2.experienceNeeded) return true;
            return false;
        }

        public static bool operator!=(Pracodawca pd1, Pracodawca pd2)
        {
            if (pd1.offeringTypeOfJob != pd2.offeringTypeOfJob || pd1.amountOfEmployeesNeeded != pd2.amountOfEmployeesNeeded || pd1.educationNeeded != pd2.educationNeeded || pd1.experienceNeeded != pd2.experienceNeeded) return true;
            return false;
        }

        public static bool operator >(Pracodawca pd1, Pracodawca pd2)
        {
            if (pd1.offeringTypeOfJob == pd2.offeringTypeOfJob && pd1.amountOfEmployeesNeeded > pd2.amountOfEmployeesNeeded) return true;
            return false;
        }

        public static bool operator <(Pracodawca pd1, Pracodawca pd2)
        {
            if (pd1.offeringTypeOfJob == pd2.offeringTypeOfJob && pd1.amountOfEmployeesNeeded < pd2.amountOfEmployeesNeeded) return true;
            return false;
        }

        private void SaveBmp(StreamWriter sw)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                photo.Save(ms, ImageFormat.Bmp);
                byte[] bytes = ms.ToArray();
                sw.WriteLine(Convert.ToBase64String(bytes, 0, bytes.Length));
            }
        }

        private Bitmap LoadBmp(StreamReader sr)
        {
            byte[] bytes = Convert.FromBase64String(sr.ReadLine());
            using (MemoryStream ms = new MemoryStream(bytes))
            return new Bitmap(ms);
        }

        public override void WriteToFile(StreamWriter sw)
        {
            sw.WriteLine("PD");

            sw.WriteLine(birthday);
            sw.WriteLine(id);
            sw.WriteLine(pesel);
            sw.WriteLine(yearBorn);
            sw.WriteLine(name);
            sw.WriteLine(surname);
            sw.WriteLine(country);
            sw.WriteLine(city);
            sw.WriteLine(email);
            sw.WriteLine(rating);

            sw.WriteLine(offeringTypeOfJob);
            sw.WriteLine(amountOfEmployeesNeeded);
            sw.WriteLine(educationNeeded.ToString());
            sw.WriteLine(experienceNeeded.ToString());

            SaveBmp(sw);
        }

        public override void ReadFromFile(StreamReader sr)
        {
            birthday = Convert.ToDateTime(sr.ReadLine());
            id = Convert.ToInt32(sr.ReadLine());
            pesel = sr.ReadLine();
            yearBorn = Convert.ToInt32(sr.ReadLine());
            name = sr.ReadLine();
            surname = sr.ReadLine();
            country = sr.ReadLine();
            city = sr.ReadLine();
            email = sr.ReadLine();
            rating = float.Parse(sr.ReadLine());

            offeringTypeOfJob = sr.ReadLine();
            amountOfEmployeesNeeded = Convert.ToInt32(sr.ReadLine());
            educationNeeded = bool.Parse(sr.ReadLine());
            experienceNeeded = bool.Parse(sr.ReadLine());

            photo = LoadBmp(sr);
        }

        public override void WriteLV(ListView lV)
        {
            lV.Items.Add(new ListViewItem(new[] {
                id.ToString(), name + " " + surname, pesel, CalculateAge().ToString(), ReturnLocation(), email, rating.ToString(), "Pracodawca"
            }));
        }
    }
}
