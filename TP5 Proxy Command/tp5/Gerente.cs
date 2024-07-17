using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Gerente : Persona, IObservador
    {
        Pila bestSeller = new Pila();
        public Gerente(string nom , int identifiant) : base(nom, identifiant)
        {

        }

        public void Cerrar()
        {
            var iterador = bestSeller.crearIterador();
            Console.WriteLine("Mejores vendedores: ");
            while (!iterador.fin())
            {
                Console.WriteLine(iterador.actual());
                iterador.siguiente();
            }
        }
        public void Venta(double monto, Comparable vende)
        {
            if(monto > 3000)
            {
                if (!bestSeller.contiene(vende))
                {
                    bestSeller.agregar(vende);
                    
                }
                ((Vendedor)vende).aumentaBonus();

                
            }
        }
        public void actualizar(IObservado i)
        {
            this.Venta(((Vendedor)i).getUltimaVenta(), (Vendedor)i); // recibe un monto y un vendedor
        }

    }
}
