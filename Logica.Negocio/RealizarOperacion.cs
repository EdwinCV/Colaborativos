﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Negocio
{
    public class RealizarOperacion
    {
        
        double Calcular(double operandoUno, double operandoDos,
                        string operador)
        {
            double elResultado = 0.0;

            // invoque al método correspondiente
            switch (operador)
            {
                case "+":
                    var laSuma = new Suma();
                    elResultado = laSuma.Operar(operandoUno, operandoDos);
                    break;

                /*
                                case "-":
                                    elResultado = Resta.Operar(operandoUno, operandoDos);
                                    break;

                                case "*":
                                    elResultado = Multiplicacion.Operar(operandoUno, operandoDos);
                                    break;

                                case "/":
                                    elResultado = Division.Operar(operandoUno, operandoDos);
                                    break;
                */
                case "-":
                    var laResta = new Resta();
                    elResultado = laResta.Operar(operandoUno, operandoDos);
                    break;

/*
                case "-":
                    elResultado = Resta.Operar(operandoUno, operandoDos);
                    break;

                case "*":
                    elResultado = Multiplicacion.Operar(operandoUno, operandoDos);
                    break;

                case "/":
                    elResultado = Division.Operar(operandoUno, operandoDos);
                    break;
            }
            return (elResultado);
/*
*/
     case "*":
                    var laMultiplicación = new Multiplicación();
                    elResultado = laMultiplicación.Operar(operandoUno, operandoDos);
                    break;
                /*

                             case "-":
                                 elResultado = Resta.Operar(operandoUno, operandoDos);
                                 break;

                             case "*":
                                 elResultado = Multiplicación.Operar(operandoUno, operandoDos);
                                 break;

                             case "/":
                                 elResultado = División.Operar(operandoUno, operandoDos);
                                 break;

                 return (elResultado);
                 /*
                 */
                case "/":
                    var laDivisión = new División();
                    elResultado = laDivisión.Operar(operandoUno, operandoDos);
                    break;
/*
                case "-":
                    elResultado = Resta.Operar(operandoUno, operandoDos);
                    break;

                case "*":
                    elResultado = Multiplicación.Operar(operandoUno, operandoDos);
                    break;

                case "/":
                    elResultado = División.Operar(operandoUno, operandoDos);
                    break;
            }
            return (elResultado);

        }
    }
}
