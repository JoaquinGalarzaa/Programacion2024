﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Prueba.Models
{
    public class Libro
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse)
        public string _id { get; set; }
        public string nombre { get; set; }
        public int paginas { get; set; }
        public string autor { get; set; }
        public string editorial { get; set; }
        public string portada_url { get; set; }
        public string sinopsis { get; set; }
        public string genero { get; set; }

    }
}