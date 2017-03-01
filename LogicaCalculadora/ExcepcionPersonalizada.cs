using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LogicaCalculadora
{
    [DataContract]
    class ExcepcionPersonalizada
    {
        public ExcepcionPersonalizada(string detail, int code)
        {
            DetailError = detail;
            InternalCodeError = code;
        }

        [DataMember]
        public int InternalCodeError { get; set; }
        [DataMember]
        public string DetailError { get; set; }
      
    }
}
