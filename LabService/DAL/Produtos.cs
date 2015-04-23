using LabService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabService.DAL
{
    public static class Produtos
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IList<ValoresDTO> GetValores()
        {
            return new List<ValoresDTO>(){  
                 
                new ValoresDTO {descProduto = "Bebida de Soja Ades Laranja 200 mlInfo", minValor = 1.59M, maxValor = 2.59M, numLojas = 7},
                 
                new ValoresDTO {descProduto = "Bebida de Soja Ades Uva 200 ml", minValor = 1.79M, maxValor = 2.32M, numLojas = 6},

                new ValoresDTO {descProduto = "Bebida de Soja Ades Abacaxi 1000 ml", minValor = 3.99M, maxValor = 7.05M, numLojas = 4},

                new ValoresDTO {descProduto = "Bebida de Soja Ades Laranja 1000 ml", minValor = 3.99M, maxValor = 6.19M, numLojas = 4},

                new ValoresDTO {descProduto = "Bebida de Soja Ades Laranja Zero 1000 ml", minValor = 4.99M, maxValor = 8.48M, numLojas = 4},

                new ValoresDTO {descProduto = "Bebida de Soja Ades Maçã 1000 ml", minValor = 3.99M, maxValor = 7.95M, numLojas = 4},

                new ValoresDTO {descProduto = "Bebida de Soja Ades Maçã 200 ml", minValor = 1.80M, maxValor = 2.59M, numLojas = 4},

                new ValoresDTO {descProduto = "Bebida de Soja Ades Maracujá 200 ml", minValor = 1.59M, maxValor = 2.01M, numLojas = 4},
            };
        }
    }
}
