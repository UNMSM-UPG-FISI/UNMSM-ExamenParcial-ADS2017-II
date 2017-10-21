using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNMSM_ExamenParcial_ADS2017_II
{
    class Program
    {
        const int edadMinima = 18;
        const int experienciaMinima = 3;
        static void Main(string[] args)
        {

        }

        static void FailFastDirtyCode(Persona persona)
        {
            if (persona.Edad >= edadMinima)
            {
                if (persona.TiempoExperiencia >= experienciaMinima)
                {
                    //TODO: Código para los que cumplen requisitos
                    ProcesaAptos(persona);
                }
                else
                {
                    throw new Exception("No tiene la experiencia requerida.");
                }
            }
            else
            {
                throw new Exception("La persona es menor de edad.");
            }
        }

        static void FailFastCleanCode(Persona persona)
        {
            if (persona.Edad < edadMinima) throw new Exception("La persona es menor de edad.");

            if (persona.TiempoExperiencia < experienciaMinima) throw new Exception("No tiene la experiencia requerida.");

            ProcesaAptos(persona);
        }

        static void ProcesaAptos(Persona persona)
        {
            //TODO: Código para mayores de edad
            Console.WriteLine(persona.Nombre);
        }

        static string ReturnEarlyDirtyCode(int edad)
        {
            var clasificacion = string.Empty;
            if (edad < 3)
            {
                clasificacion = "infancia";
            }
            if (edad > 3 && edad <= 6)
            {
                clasificacion = "niñez temprana";
            }
            if (edad > 6 && edad <= 12)
            {
                clasificacion = "niñez intermedia ";
            }
            else
            {
                clasificacion = "ya no es niño";
            }
            return clasificacion;
        }

        static string ReturnEarlyCleanCode(int edad)
        {
            var clasificacion = string.Empty;
            if (edad < 3) return Etapa.Niñez;
            if (edad > 3 && edad <= 6) return Etapa.NiñezTemprana;
            if (edad > 6 && edad <= 12) return Etapa.NiñezIntermedia;
            
            return Etapa.NoNiño;
        }
    }
}
