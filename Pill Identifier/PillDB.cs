using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Pill_Identifier
{
    class PillDB
    {
        private string pillImprint;
        private string pillColor;
        private string pillShape;
        private string drugName;
        private string drugStrength;
        private string pillPhoto;
        private DateTime date;

        private MySqlConnection conn;

        public string PillImprint { get => pillImprint; set => pillImprint = value; }
        public string PillColor { get => pillColor; set => pillColor = value; }
        public string PillShape { get => pillShape; set => pillShape = value; }
        public string DrugName { get => drugName; set => drugName = value; }
        public string DrugStrength { get => drugStrength; set => drugStrength = value; }
        public string PillPhoto { get => pillPhoto; set => pillPhoto = value; }
        public DateTime Date { get => date; set => date = value; }

        public PillDB()
        {
            string cs = @"server=localhost;userid=root;password=111957;database=pharma";
            conn = new MySqlConnection(cs);
            conn.Open();
        }

        public PillDB(string pillImprint, string pillColor, string pillShape, string drugName, string drugStrength, string pillPhoto, DateTime time)
        {
            PillImprint = pillImprint;
            PillColor = pillColor;
            PillShape = pillShape;
            DrugName = drugName;
            DrugStrength = drugStrength;
            PillPhoto = pillPhoto;
            Date = time;
        }

        public List<PillDB> SelectAllPills()
        {
            string sql = "SELECT * FROM Pills";
            List<PillDB> records = new List<PillDB>();
            var cmd = new MySqlCommand(sql, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                PillDB record = new PillDB(reader.GetString("pill_imprint"), reader.GetString("pill_color"),
                    reader.GetString("pill_shape"), reader.GetString("drug_name"), reader.GetString("drug_strength"),
                    reader.GetString("pill_photo"), reader.GetDateTime("creation_date"));

                records.Add(record);
            }

            reader.Close();
            return records;
        }

        public PillDB SearchForAPill(string pill_imprint)
        {
            string sql = "SELECT * FROM Pills WHERE pill_imprint = @pill_imprint";
            PillDB record = null;
            var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@pill_imprint", pill_imprint);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                record = new PillDB(reader.GetString(" pill_imprint"), reader.GetString("pill_color"),
                    reader.GetString("pill_shape"), reader.GetString("drug_name"), reader.GetString("drug_strength"),
                    reader.GetString("pill_photo"), reader.GetDateTime("creation_date"));
            }

            reader.Close();
            return record;
        }

        public void InsertPill(PillIdentifier record)
        {
            var sql = "INSERT INTO pharma.Pills(pill_imprint, pill_color, pill_shape, drug_name, drug_strength, pill_photo, creation_date) " +
                " VALUES(@pill_imprint, @pill_color, @pill_shape, @drug_name, @drug_strength, @pill_photo, @creation_date) ";
            var cmd = new MySqlCommand(sql, conn);
            
            //Testing purposes
            Console.WriteLine("Today is: " + record.Date.ToUniversalTime());

            cmd.Parameters.AddWithValue("@pill_imprint", record.PillImprint);
            cmd.Parameters.AddWithValue("@pill_color", record.PillColor);
            cmd.Parameters.AddWithValue("@pill_shape", record.PillShape);
            cmd.Parameters.AddWithValue("@drug_name", record.DrugName);
            cmd.Parameters.AddWithValue("@drug_strength", record.DrugStrenght);
            cmd.Parameters.AddWithValue("@pill_photo", record.PillPhoto);
            cmd.Parameters.AddWithValue("@creation_date", record.Date);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        public void UpdatePet(PillIdentifier record)
        {
            var sql = "UPDATE Pills SET  pill_color=@pill_color, pill_shape=@pill_shape, drug_name=@drug_name, drug_strength=@drug_strength, pill_photo=@pill_photo, creation_date=@creation_date" +
                      " WHERE pill_imprint = @pill_imprint";
            var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@pill_imprint", record.PillImprint);
            cmd.Parameters.AddWithValue("@pill_color", record.PillColor);
            cmd.Parameters.AddWithValue("@pill_shape", record.PillShape);
            cmd.Parameters.AddWithValue("@drug_name", record.DrugName);
            cmd.Parameters.AddWithValue("@drug_strength", record.DrugStrenght);
            cmd.Parameters.AddWithValue("@pill_photo", record.PillPhoto);
            cmd.Parameters.AddWithValue("@creation_date", record.Date);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        public void closeDB()
        {
            conn.Close();
        }

        
    }
}
