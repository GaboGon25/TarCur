using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarCur
{
    public class NominaSemanal : Empleado
    {
        // Calculos de los ingresos
        public virtual double CalculaRiesgoLaboral()
        {
            RiesgoLaboral = SalarioBase * 0.2; // Riesgo laboral equivale al 20% del Salario Ordinario
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
       
        public virtual double CalculaTotalIngresos()
        {
            double totalIngresos = CalculaRiesgoLaboral() + CalculaNocturnidad() + CalculaPagoHorasExtras();
            return totalIngresos;
        }

        public virtual double SalarioBruto()
        {
            double salarioBruto = CalculaTotalIngresos() + SalarioBase;
            return salarioBruto;
        }
        // Calculos de las Deducciones

        public virtual double CalculaINSS()
        {
            return SalarioBruto() * 0.07;

        }

        public virtual double SalarioRestado()
        {
            return SalarioBruto() - CalculaINSS();
        }

        public virtual double SalarioAnual()
        {
            return SalarioRestado() * 12;
        }



        public virtual double CalculaIR()
        {
            double Anual = SalarioAnual();
            double IR = 0;

            if (Anual > 0.01 || Anual < 8333.33)
            {
                IR = 0;
            }

            else if (Anual > 8333.34 || Anual < 16666.66)
            {
                double SobreExceso = 8333.33;
                double Deducir1 = Anual - SobreExceso;
                IR = (Deducir1 * 0.15) / 12;
            }
            else if (Anual > 16666.67 || Anual < 29166.66)
            {
                double SobreExceso2 = 16666.66;
                double Deducir2 = Anual - SobreExceso2;
                IR = ((Deducir2 * 0.2) + 1250.00) / 12;
            }
            else if (Anual > 29166.67 || Anual < 41666.66)
            {
                double SobreExceso3 = 29666.67;
                double Deducir3 = Anual - SobreExceso3;
                IR = ((Deducir3 * 0.25) + 3750.00) / 12;
            }
            else if (Anual > 41666.67)
            {
                double SobreExceso4 = 41666.66;
                double Deducir4 = Anual - SobreExceso4;
                IR = ((Deducir4 * 0.3) + 6875)/12;
            }
            return IR;
        }

        public virtual double CalculaTotalDeducciones()
        {
            double totalDeducciones = CalculaINSS() + CalculaIR();
            return totalDeducciones;
        }

        public virtual double SalarioNeto()
        {
            double salarioNeto = SalarioBruto() - CalculaTotalDeducciones();
            return salarioNeto;
        }

    }
}
