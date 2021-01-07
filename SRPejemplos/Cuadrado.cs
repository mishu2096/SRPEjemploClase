using System;
using System.Collections.Generic;
using System.Text;

namespace SRPejemplos
{
    class Cuadrado
    {
        //1 responsabilidad
        public float Lado { get; set; }
        //1 
        public float PosicionX { get; set; }
        //1
        public float PosicionY { get; set; }
        //1
        public float Perimetro()
        {
            return Lado * 4;
        }
        //1
        public float Superficie()
        {
            return Lado * Lado;
        }
        //2
        public void Dibujar()
        {
            //dibujar el cuadrado
        }
        //3
        public void Guardar()

        {
            //guardar
        }
    }
}
