using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCalculadora
{
    public class ServicioCalculadora : IServicioCalculadora
    {
        public float Division(float num1, float num2)
        {
            if (num2 == 0)
                throw new FaultException<ExcepcionPersonalizada>(new ExcepcionPersonalizada("División por cero", 100));
            else
                return num1 / num2;
        }

        public float Multiplicacion(float num1, float num2)
        {
            return num1 * num2;
        }

        public float Resta(float num1, float num2)
        {
            return num1 - num2;
        }

        public float Suma(float num1, float num2)
        {
            return num1 + num2;
        }
    }
}
