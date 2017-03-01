using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace LogicaCalculadora
{
    [ServiceContract]
    public interface IServicioCalculadora
    {
        [OperationContract]
        [FaultContract(typeof(ExcepcionPersonalizada))] 
        float Division(float num1, float num2);
        [OperationContract]
        float Multiplicacion(float num1, float num2);
        [OperationContract]
        float Resta(float num1, float num2);
        [OperationContract]
        float Suma(float num1, float num2);

    }
}
