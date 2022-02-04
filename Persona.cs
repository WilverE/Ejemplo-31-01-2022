﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_31_01_2022
{
    internal class Persona
    {
        public string Dpi { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public int edad()
        {
            DateTime hoy = DateTime.Now;
            int año = hoy.Year - FechaNacimiento.Year;
            if (hoy < FechaNacimiento.AddYears(año))
            {
                año--; 
                
            }
            return (año);
        }
    }
}
