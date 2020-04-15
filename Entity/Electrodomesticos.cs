using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodomestico
{
    public class Electrodomesticos
    {
        //Atributos

        public decimal precioBase { get; private set; }
        public Colores color { get; private set; }
        public ConsumoEnergetico consumoEnergetico { get;  private set; }
        public int peso { get; private set; }

        //Constantes
        private const decimal PRECIO_BASE = 100;
        private const Colores COLOR_BASE = Colores.blanco;
        private const ConsumoEnergetico CONSUMO_BASE = ConsumoEnergetico.F;
        private const int PESO_BASE = 5;

        public Electrodomesticos(decimal precioBase, Colores color, ConsumoEnergetico consumoEnergetico, int peso) :base()
        {
            this.precioBase = precioBase;
            this.color = color;
            this.consumoEnergetico = consumoEnergetico;
            this.peso = peso;
        }

        public Electrodomesticos()
        {
            this.precioBase = PRECIO_BASE;
            this.color = COLOR_BASE;
            this.consumoEnergetico = CONSUMO_BASE;
            this.peso = PESO_BASE;
        }

        public Electrodomesticos(decimal precioBase,int peso) : base()
        {
            this.precioBase = precioBase;
            this.peso = peso;
        }



        
       






    }
}
