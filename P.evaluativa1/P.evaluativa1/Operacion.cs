using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P.evaluativa1
{
    public class Operacion
    {
        public List<Persona> ObtenerPersona()
        {
            var datos = ObtenerLineas();
            List<Persona> personas = new List<Persona>();
            foreach (var item in datos)
            {
                string[] info = item.Split(',');
                Persona persona = new Persona
                {
                    Id = int.Parse(info[0]),
                    Nombre = info[1],
                    Profesion = info[2],
                    Edad = int.Parse(info[3])
                };
                personas.Add(persona);
            }
            return personas;
        }
        public List<string> ObtenerLineas()
        {
            try
            {
                List<string> lineas = new List<string>();
                string[] info = null;
                if (File.Exists("Datos.txt"))
                {
                    info = File.ReadAllLines("Datos.txt");
                }

                foreach (string item in info)
                {
                    lineas.Add(item);
                }
                return lineas;
            }
            catch (System.Exception)
            {


            }
            return null;
        }
        public void DesplegarPersona()
        {
            Console.WriteLine("Ingrese el ID de la persona: ");
            int Buscar = int.Parse(Console.ReadLine());
            var gente = ObtenerPersona();
            Persona p = new Persona();
            foreach (var item in gente)
            {
                if (Buscar == item.Id)
                {
                    p = item;
                }
            }
            Console.WriteLine("Nombre:    {0}\nProfesion: {1}\nEdad:      {2}", p.Nombre, p.Profesion, p.Edad);
            Console.WriteLine("Desea buscar a otra persona ?");
            Console.WriteLine("1.-Si");
            Console.WriteLine("2.-No");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.Clear();
                    DesplegarPersona();
                    break;


            }
            Console.Clear();

        }
    }
}


