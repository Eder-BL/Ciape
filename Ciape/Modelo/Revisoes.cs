using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ciape.Modelo;
using System.ComponentModel.DataAnnotations;

namespace Ciape.Modelo {
    public class Revisoes {

        public int Id { get; set; }

        [StringLength(70, MinimumLength = 5)]
        public string Descricao { get; set; }

        [StringLength(100, MinimumLength = 5)]
        public string Link { get; set; }

        public string Status { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }

    }


}
