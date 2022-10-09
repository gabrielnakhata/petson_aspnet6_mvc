﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetsOn.Entities
{
    public class OrdemServico
    {
        [Key]
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Observacao { get; set; }

        [ForeignKey("Animal")]
        public int Id_Animal { get; set; }
        public Animal Animal { get; set; }

        [ForeignKey("Cliente")]
        public int Id_Cliente { get; set; }
        public Cliente Cliente { get; set; }

        [ForeignKey("Servico")]
        public int Id_Servico { get; set; }
        public Servico Servico { get; set; }


    }
}