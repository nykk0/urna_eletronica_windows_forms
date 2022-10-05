using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna_eletronica
{
    internal class Candidatos
    {
        public string msg = "", nome = "", img = "" , partido = "" , existente= "";

        public int candidato(int numero) 
        {
           

            switch (numero) 
            {
                case 22:
                    nome = "Bolsonaro";
                    img = "C:\\Users\\yanni\\source\\repos\\Urna_eletronica\\bolsonaro.jfif";
                    msg = "Voto computado";
                    partido = "PL";
                    return numero;
                    break;

                case 13:
                    nome = "Luiz Inácio Lula da Silva";
                    img = "C:\\Users\\yanni\\source\\repos\\Urna_eletronica\\lula.jfif";
                    msg = "Voto computado";
                    partido = "PT";
                    return numero;
                    break;

                case 15:
                    nome = "Simone Tebet";
                    img = "C:\\Users\\yanni\\source\\repos\\Urna_eletronica\\simone_tebet.jpg";
                    msg = "Voto computado";
                    partido = "PDB";
                    return numero;
                    break;

                case 12:
                    nome = "Ciro Gomes";
                    img = "C:\\Users\\yanni\\source\\repos\\Urna_eletronica\\ciro.jpg";
                    msg = "Voto computado";
                    partido = "PDT";
                    return numero;
                    break;


                default:
                    img = null;
                    existente = "Candidato não existente";
                    return numero;
                    break;
            }
        }
    }
}
