using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Estruturada
{
	public class Calculadora
	{
		//atributos
		private float _num1;
		private float _num2;

		//construct
		public Calculadora()
		{

		}

		public Calculadora(float num1, float num2)
		{
			_num1 = num1;
			_num2 = num2;
		}

		//methods
		public float Soma()
		{
			return _num1 + _num2;
		}

		public float Subtrair(float n1, float n2)
		{
			return n1 - n2;
		}

		public float Multiplicacao()
		{
			return _num1 * _num2;
		}

		public float Dividir()
		{
			return _num1 / _num2;
		}

	}
}
