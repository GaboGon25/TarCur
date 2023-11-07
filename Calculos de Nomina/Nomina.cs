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

        public virtual double CalculaINSS()
        {
            return SalarioBruto()*0.07;

        }

        public virtual double SalarioRestado()
        {
            return SalarioBruto()-CalculaINSS();
        }

        public virtual double SalarioAnual()
        {
            return SalarioRestado() * 12;
        }

        

        public virtual double CalculaIR()
        {
            double Anual = SalarioAnual();
            double IR = 0;

            if (Anual>0.01 || Anual<100000.00 ) 
            {
                IR = 0;
            }

            else if(Anual > 100000.01 || Anual<200000.00)
            {
                double SobreExceso = 100000.00;
                double Deducir1 = Anual - SobreExceso;
                IR = (Deducir1 * 0.15)/12;
            }
            else if(Anual > 200000.01 || Anual<350000.00)
            {
                double SobreExceso2 = 200000.00;
                double Deducir2 = Anual-SobreExceso2;
                IR = ((Deducir2 * 0.2) + 15000.00) / 12;
            }
            else if(Anual > 350000.01 || Anual<500000.00)
            {
                double SobreExceso3 = 350000.00;
                double Deducir3 = Anual-SobreExceso3;
                IR = ((Deducir3 * 0.25) + 45000.00) / 12;
            }
            else if (Anual > 500000.01)
            {
                double SobreExceso4 = 500000.00;
                double Deducir4 = Anual-SobreExceso4;
                IR = ((Deducir4 * 0.3) + 82500)/12;
            }
            return IR;
        }

        public virtual double CalculaTotalDeducciones()
        {
            double totalDeducciones = CalculaINSS()+CalculaIR();
            return totalDeducciones;
        }

        public virtual double SalarioNeto()
        {
            double salarioNeto = SalarioBruto() - CalculaTotalDeducciones();
            return salarioNeto;
        }

        
        
            
                
         
    }
}
