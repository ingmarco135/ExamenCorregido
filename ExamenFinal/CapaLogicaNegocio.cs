using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class LogicaNegocio
    {
        public decimal CalcularAumento(decimal sueldoBruto)
        {
            decimal porcentajeAumento = 0;
            if (sueldoBruto <= 1000)
                porcentajeAumento = 0.1m;
            else if (sueldoBruto > 1000 && sueldoBruto <= 2000)
                porcentajeAumento = 0.2m;
            else if (sueldoBruto > 2000 && sueldoBruto <= 4000)
                porcentajeAumento = 0.3m;
            else
                porcentajeAumento = 0.4m;
            return porcentajeAumento * sueldoBruto;
        }

        public decimal CalcularSueldoNeto(decimal sueldoBruto)
        {
            decimal aumento = CalcularAumento(sueldoBruto);
            return sueldoBruto + aumento;
        }
    }
}
