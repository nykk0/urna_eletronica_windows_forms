using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna_eletronica
{
    internal class Candidatos
    {
        public string  nome = "", img = "" , partido = "" , existente= "";
        public int num = 0;
        public bool existe = true;
        public int candidato(int numero) 
        {
           

            switch (numero) 
            {
                case 22:
                    nome = "Bolsonaro";
                    img = "C:\\Users\\yanni\\source\\repos\\Urna_eletronica\\img\\bolsonaro.jfif";
                    partido = "PL";
                    num = 22;
                    existe = true;
                    return numero;
                    break;

                case 13:
                    nome = "Luiz Inácio Lula da Silva";
                    img = "C:\\Users\\yanni\\source\\repos\\Urna_eletronica\\img\\lula.jfif";
                    partido = "PT";
                    num = 13;
                    existe = true;
                    return numero;
                    break;

                case 15:
                    nome = "Simone Tebet";
                    img = "C:\\Users\\yanni\\source\\repos\\Urna_eletronica\\img\\simone_tebet.jpg";
                    partido = "PDB";
                    num = 15;
                    existe = true;
                    return numero;
                    break;

                case 12:
                    nome = "Ciro Gomes";
                    img = "C:\\Users\\yanni\\source\\repos\\Urna_eletronica\\img\\ciro.jpg";
                    partido = "PDT";
                    num = 12;
                    existe = true;
                    return numero;
                    break;


                default:
                    img = null;
                    existe = false;
                    return numero;
                    break;
            }
        }
    }
}
