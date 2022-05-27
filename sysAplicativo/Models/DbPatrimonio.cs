using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace SysAplicativo.Models
{
    [Table("patrimonio", Schema = "public")]
    public class DbPatrimonio
    {
        [Key]
        public int id { get; set; }
        public string numetiqueta { get; set; }

        public string nomepatrimonio { get; set; }

        public string descricaopatrimonio { get; set; }

        public int valorpatrimonio { get; set; }

        public int idcategoria { get; set; }

        public int idlocal { get; set; }

        public int iddepartamento { get; set; }

        public string marcaModelo { get; set; }

        public DateOnly dataaquisicao { get; set; }

        public DateOnly databaixa { get; set; }

        public int numNf { get; set; }

        public string numserie { get; set; }    

        public int idfornecedor { get; set; }   
        
        public DateOnly datagarantia { get; set; }






    }
}