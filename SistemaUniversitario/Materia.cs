﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUniversitario
{
    class Materia
    {
        private string nombre;
        private string nrc;
        private int numero_creditos;
        private double calificacion_final;
        List<Calificacion> calificaciones = new List<Calificacion>();
        private Profesor profesor;

        public Materia(string nombre, string nrc, int numero_creditos)
        {
            this.Nombre = nombre;
            this.Nrc = nrc;
            this.Numero_creditos = numero_creditos;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Nrc { get => nrc; set => nrc = value; }
        public int Numero_creditos { get => numero_creditos; set => numero_creditos = value; }
        public double Calificacion_final { get => calificacion_final; set => calificacion_final = value; }
        internal List<Calificacion> Calificaciones { get => calificaciones; set => calificaciones = value; }
        internal Profesor Profesor { get => profesor; set => profesor = value; }
    }
}
