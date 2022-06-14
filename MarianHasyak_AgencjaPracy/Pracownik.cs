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
    class Pracownik:Klient
    {
        bool hasEducation;
        string doingTypeOfJob;
        int startedWorkingYear;
        string previousExperience;
        List<string> skills;

        //Default constructor
        public Pracownik() : base()
        {
            this.hasEducation = false;
            this.doingTypeOfJob = "programmer";
            this.startedWorkingYear = 2019;
            this.previousExperience = "Frontend developer";
            this.skills = new List<string>();
            //
            skills.Add("creative");
            skills.Add("team player");
        }

        //Parametrized constructor
        public Pracownik(string pesel, int yearBorn, string name, string surname, string country, string city, string email, float rating, DateTime birthday, Bitmap photo, bool hasEducation, string doingTypeOfJob, int startedWorkingYear, string previousExperience, List<string> skills) : base(pesel, yearBorn, name, surname, country, city, email, rating, birthday, photo)
        {
            this.hasEducation = hasEducation;
            this.doingTypeOfJob = doingTypeOfJob;
            this.startedWorkingYear = startedWorkingYear;
            this.previousExperience = previousExperience;
            this.skills = skills;
        }

        //Duplicating constructor
        public Pracownik(Pracownik pracownik):base(pracownik)
        {
            this.hasEducation = pracownik.hasEducation;
            this.doingTypeOfJob= pracownik.doingTypeOfJob;
            this.startedWorkingYear = pracownik.startedWorkingYear;
            this.previousExperience= pracownik.previousExperience;
            this.skills = pracownik.skills;
        }

        override public void Write(ListBox lb)
        {
            base.Write(lb);
            lb.Items.Add("Title:\t" + ReturnPracownikTitle());
            lb.Items.Add("Years working:\t" + CalculateYearsWorking());
            lb.Items.Add("Previous experience:\t" + previousExperience);
            lb.Items.Add("Skills:\t" + string.Join(",", skills));
        }

        private int CalculateYearsWorking()
        {
            return DateTime.Now.Year - startedWorkingYear;
        }

        private string ReturnPracownikTitle()
        {
            if(hasEducation)
            {
                return "Educated " + doingTypeOfJob;
            }
            else
            {
                return doingTypeOfJob;
            }
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
            sw.WriteLine("PW");

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

            sw.WriteLine(hasEducation.ToString());
            sw.WriteLine(doingTypeOfJob);
            sw.WriteLine(startedWorkingYear);
            sw.WriteLine(previousExperience);
            sw.WriteLine(string.Join(",", skills));

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

            hasEducation = bool.Parse(sr.ReadLine());
            doingTypeOfJob = sr.ReadLine();
            startedWorkingYear = Convert.ToInt32(sr.ReadLine());
            previousExperience = sr.ReadLine();
            skills = sr.ReadLine().Split(',').ToList();

            photo = LoadBmp(sr);
        }

        public override void WriteLV(ListView lV)
        {
            lV.Items.Add(new ListViewItem(new[] {
                id.ToString(), name + " " + surname, pesel, CalculateAge().ToString(), ReturnLocation(), email, rating.ToString(), "Pracownik"
            }));
        }
    }
}
