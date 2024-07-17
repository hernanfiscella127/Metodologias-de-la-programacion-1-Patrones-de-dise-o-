using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
    public class Vendedor : Persona , IObservado
    {
        double sueldoBasico;
        double ultimaventa;
        double bonus;
        string nombre;
        int dni;

        public Vendedor(string nombre,int dni,double sueldoBasico) : base(nombre, dni)
        {
            this.nombre = nombre;
            this.sueldoBasico = sueldoBasico;
            this.dni = dni;
            bonus = 1;
        }
        public override String ToString()
        {
            return " nombre " + GetNombre() + "dni " + GetDni() + " sueldo basico " + sueldoBasico + "  bonus " + bonus+ "ultima venta: " + getUltimaVenta();
        }
        public void setUltimaventa(double a)
        {
            ultimaventa = a;
        }
        public double getUltimaVenta()
        {
            return ultimaventa;
        }
        public void Venta(int monto)
        {
            ultimaventa = monto;
            //Console.WriteLine(monto);
            this.notificar();
        }


        public void aumentaBonus()
        {
            double aumenta = (this.bonus * 0.1) / 100;
            double resultado = bonus + aumenta;
            
        }

        List<IObservador> observadores = new List<IObservador>(); // el observado va a necesitar un lista de los que lo estan mirando, los metodos siguiente se los van a agregar/sacar:
        public void agregarObservador(IObservador i)// empezar a mirar
        {
            observadores.Add(i);
        } 
        public void quitarObservador(IObservador i)// dejar de mirar
        {
            observadores.Remove(i);
        } 
        public void notificar()
        {
            foreach(IObservador i in observadores) //le avisa a todos los observadores que estan en la lista que paso algo (el actualizar lo tiene implementado los observadores)
            {
                i.actualizar(this);
            }
        } // notifica si pasa algo
    }
}
