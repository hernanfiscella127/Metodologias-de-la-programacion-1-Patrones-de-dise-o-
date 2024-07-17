using System;
using System.Collections.Generic;
using System.Text;

namespace tp1
{
	public class ProxyAlumno : IAlumno
	{
		protected IAlumno alumnoReal = null;
		protected string nombre;
		protected int dni;
		protected int legajo;
		protected int promedio;
		protected int calificacion;

		public ProxyAlumno(string nom, int d, int l, int p)
		{
			nombre = nom;
			dni = d;
			legajo = l;
			promedio = p;
		}

		public string mostrarCalificacion()
		{
			if (alumnoReal != null)
			{
				return alumnoReal.mostrarCalificacion();
			}
			else
			{
				return null;
			}
		}
		public void SetCalificacion(int valor)
		{

			if (alumnoReal == null)
			{
				alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(3);
				alumnoReal.SetCalificacion(valor);
			}
			else
			{
				alumnoReal.SetCalificacion(valor);
			}
		}
		public virtual int ResponderPregunta(int pregunta)
		{

			if (alumnoReal == null)
			{
				alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(3);
				return alumnoReal.ResponderPregunta(pregunta);
			}
			else
			{
				return alumnoReal.ResponderPregunta(pregunta);
			}
		}
		public string GetNombre()
		{
			return nombre;
		}
		public int GetLegajo()
		{
			return legajo;
		}
		public int GetPromedio()
		{
			return promedio;
		}
		public int GetDni()
		{
			return dni;
		}
		public int GetCalificacion()
		{
			return calificacion;
		}
		public bool sosIgual(Comparable comparable)
		{
			return alumnoReal.sosIgual(comparable);
		}
		public bool sosMayor(Comparable comparable)
		{
			return alumnoReal.sosMayor(comparable);
		}
		public bool sosMenor(Comparable comparable)
		{
			return alumnoReal.sosMenor(comparable);
		}
	}
	public class ProxyAlumnoEstudioso : ProxyAlumno
	{
		public ProxyAlumnoEstudioso(string nombre, int dni, int legajo, int promedio) : base(nombre, dni, legajo, promedio)
		{

		}

		public override int ResponderPregunta(int pregunta)
		{
			if (alumnoReal == null)
			{
				alumnoReal = (IAlumno)FabricaDeComparables.crearAleatorio(3);
			}

			return alumnoReal.ResponderPregunta(pregunta);
		}
	}
}
    
    
