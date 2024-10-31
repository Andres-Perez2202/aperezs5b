using aperezs5b.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aperezs5b.Utils
{
    public class PersonRepository
    {
        string dbPath;
        private SQLiteConnection conn;

        public string status {  get; set; }
        public PersonRepository(string path) {
            dbPath = path;
        }
        
        public void Init()
        {
            if (conn is  not null) 
                return;
            conn = new (dbPath);
            conn.CreateTable<Persona>();
        }

        public void AddnewPerson(string name) 
        {
            int result = 0;
            try
            {
                Init();
                if (string.IsNullOrEmpty(name))
                    throw new Exception("El nombre es requerido");
                Persona persona = new() {Name = name };
                result = conn.Insert(persona);
                status = string.Format("Dato ingresado");
            }
            catch (Exception ) {
                status = string.Format("Error al ingresar");
            }
    }
        public List<Persona> GetAllPeople() {
            try
            {
                Init();
                return conn.Table<Persona>().ToList();
            }
            catch (Exception)
            {

                status = string.Format("Error al ingresar");
            }
            return new List<Persona>();
}
}
}