using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace Pill_Identifier
{
    class PillIdentifier
    {


        private string pillImprint;
        private string pillColor;
        private string pillShape;
        private string drugName;
        private string drugStrenght;
        private string pillPhoto;
        private DateTime date;
        

        
           

        public PillIdentifier()
        {
            this.PillImprint = "";
            this.PillColor = "";
            this.PillShape = "";
            this.DrugName = "";
            this.DrugStrenght = "";
            this.date = new DateTime();
        }

        public PillIdentifier(string imprint, string color, string shape, string name, string strenght, string photo)
        {
            this.PillImprint = imprint;
            this.PillColor = color;
            this.PillShape = shape;
            this.DrugName = name;
            this.DrugStrenght = strenght;
            this.PillPhoto = photo;
            this.date = new DateTime();


        }
        

        public string PillImprint { get => pillImprint; set => pillImprint = value; }
        public string PillColor { get => pillColor; set => pillColor = value; }
        public string PillShape { get => pillShape; set => pillShape = value; }
        public string DrugName { get => drugName; set => drugName = value; }
        public string DrugStrenght { get => drugStrenght; set => drugStrenght = value; }
        public DateTime Date { get => date; set => date = value; }
        public string PillPhoto { get => pillPhoto; set => pillPhoto = value; }
     

        public bool IdentifyPill(string pillImprint)
        {
            PillDB database = new PillDB();
            PillDB FoundPill = database.SearchForAPill(pillImprint);

            Console.WriteLine("Found it: " + FoundPill.PillColor);

            if (FoundPill != null)
            {
            this.PillImprint = FoundPill.PillImprint;
            this.PillColor = FoundPill.PillColor;
            this.PillShape = FoundPill.PillShape;
            this.DrugName = FoundPill.DrugName;
            this.DrugStrenght = FoundPill.DrugStrength;
            this.PillPhoto = FoundPill.PillPhoto;
            this.date = DateTime.ParseExact(FoundPill.Date, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture); ;
                return true;
            }

            return false;



        }


    }
}
