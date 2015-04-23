using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabService.DTO
{
    public class ValoresDTO
    {
        //public decimal pis { get; set; } //R$ 30.000,00 x (1,65% / 100) =  R$ 495,00
        
        //public decimal imposto { get; set; }:W
        
        public decimal totalVendas { get; set; }

        public decimal valorProduto { get; set; }

        public int numProdutos { get; set; }

        public string nomeProduto { get; set; }

        public string descProduto  { get; set; }
        
        public decimal minValor  { get; set; }
        
        public decimal maxValor  { get; set; }

        public int numLojas { get; set; }
       
    }
}
