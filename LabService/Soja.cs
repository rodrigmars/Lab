using LabService.DAL;
using LabService.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabService
{
    public class Soja
    {

        public IList<ClientesDTO> clientes { get; set; }
        
        public Soja()
        { 
        
        }

        /// <summary>
        /// Método criado para testar método contendo retorno de select para objeto lista ValoresDTO
        /// </summary>
        /// <returns>list ValoresDTO </returns>
        public IList<ValoresDTO> GetQuantidadeProdutos()
        {
            var sw = Stopwatch.StartNew();

            var clientes = GetAllProdutos();

            sw.Stop();

            Debug.WriteLine("Tempo consumo:=" + sw.Elapsed.TotalMilliseconds);

            return clientes;
        }

        /// <summary>
        /// Retorna lista para objeto ValoresDTO
        /// </summary>
        /// <returns>list ValoresDTO</returns>
        public IList<ValoresDTO> GetAllProdutos()
        {
            var clientes = Produtos.GetValores().Where(x => x.maxValor > 7.0M).ToList();

            return clientes;
        }
    }
}
