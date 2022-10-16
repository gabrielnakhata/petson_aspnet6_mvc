﻿using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace PetsOn.Entities
{
    public class Petshop
    {
        [Key]
        public int? Id { get; set; }
        public string Nome_Empresa { get; set; }
        public int Cnpj { get; set; }
        public string Web_Site { get; set; }
        public string Descricao { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
    }
}
