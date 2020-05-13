using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pill_Identifier
{
    class PillIdentifier
    {


        private int pillImprint;
        private string pillColor;
        private string pillShape;
        private string drugName;
        private double drugStrenght;
        private DateTime date;

        public PillIdentifier()
        {
            this.PillImprint = 0;
            this.PillColor = "";
            this.PillShape = "";
            this.DrugName = "";
            this.DrugStrenght = 0;
            this.date = new DateTime();
        }

        public PillIdentifier(int imprint, string color, string shape, string name, double strenght)
        {
            this.PillImprint = imprint;
            this.PillColor = color;
            this.PillShape = shape;
            this.DrugName = name;
            this.DrugStrenght = strenght;
            this.date = new DateTime();


        }
        

        public int PillImprint { get => pillImprint; set => pillImprint = value; }
        public string PillColor { get => pillColor; set => pillColor = value; }
        public string PillShape { get => pillShape; set => pillShape = value; }
        public string DrugName { get => drugName; set => drugName = value; }
        public double DrugStrenght { get => drugStrenght; set => drugStrenght = value; }
        public DateTime Date { get => date; set => date = value; }




        public void AddPill()
        {



        }

        public void ModifyPill()
        {

        }

        public void IdentifyPill()
        {

        }

        public void PillReport()
        {


        }

    }
}
