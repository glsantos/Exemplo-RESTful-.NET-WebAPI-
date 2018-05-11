using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestAPI.Models {

    [Table("Tarefas")]
    public class Tarefa {

        [Key]
        public int id { get; set; }

        [MaxLength(50)]
        public string titulo { get; set; }

        [MaxLength(200)]
        public string Descricao { get; set; }
    }
}