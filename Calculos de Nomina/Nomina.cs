using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarCur
{
    public class Nomina: Empleado
    {
        // Calculos de los ingresos
        public virtual double CalculaRiesgoLaboral()
        {
            RiesgoLaboral = SalarioBase * 0.2; // Riesgo laboral equeivale al 20% del Salario Ordinario
            return RiesgoLaboral;
        }

        public virtual double CalculaNocturnidad()
        {
            Nocturnidad = SalarioBase * 0.2; // Nocturnidad equivale al 20% del Salario Ordinario
            return Nocturnidad;
        }

        public virtual double CalculaSalarioPorDia()
        {
            double SalarioporDia = SalarioBase / 30;
            return SalarioporDia;

        }

        public virtual double CalculaSalarioPorHora()
        {
            double SalarioporHora = CalculaSalarioPorDia() / 8;
            return SalarioporHora;
        }
                                                                          // Realizamos tres metodos para calcular el pago
                                                                          // de las horas extras trabajadas
        public virtual double CalculaPagoHorasExtras()
        {
            if (HorasExtras != 0)
            {
                double pagoHorasExtras = CalculaSalarioPorHora() * HorasExtras * 2;
                return pagoHorasExtras;
            }
            else
                return 0;
        }

        public virtual double CalculaAntiguedad()
        {
            if (AñosTrabajados > 0 || AñosTrabajados <= 3)
            {
                return 0;
            }
            if (AñosTrabajados > 3 || AñosTrabajados <= 5)
            {
                double antiguedad_1 = (CalculaSalarioPorDia() * 5) / 12;
                return antiguedad_1;
            }
            if (AñosTrabajados > 5 || AñosTrabajados <= 7)
            {
                double antiguedad_2 = (CalculaSalarioPorDia() * 10) / 12;
                return antiguedad_2;
            }
            if(AñosTrabajados > 8)
            {
                double antiguedad_3 = (CalculaSalarioPorDia()*15) / 12;
                return antiguedad_3;
            }
            else
                return 0;

        }

        public virtual double CalculaTotalIngresos()
        {
            double totalIngresos = CalculaRiesgoLaboral() + CalculaNocturnidad() + CalculaPagoHorasExtras() + CalculaAntiguedad();
            return totalIngresos;
        }

        public virtual double SalarioBruto()
        {
            double salarioBruto = CalculaTotalIngresos()+ SalarioBase;
            return salarioBruto;
        }

        // Calculos de las Deducciones

        
        
            
                
         
    }
}
