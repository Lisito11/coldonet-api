﻿using APIColdonet.DTOs.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIColdonet.DTOs.SubCategorias {
    public class SubCategoriaDTO:SubCategoriaCreacionDTO {
        public int Id { get; set; }
        public virtual ICollection<ProductoDTO> Productos { get; set; }

    }
}
