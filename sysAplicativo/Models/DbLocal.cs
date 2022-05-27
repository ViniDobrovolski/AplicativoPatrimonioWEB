using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace SysAplicativo.Models
{
    [Table("local", Schema = "public")]
    public class DbLocal
    {
        [Key]
        public int id { get; set; }
        public string nomelocal { get; set; }
        public string descricaolocal { get; set; }
        
    }
}