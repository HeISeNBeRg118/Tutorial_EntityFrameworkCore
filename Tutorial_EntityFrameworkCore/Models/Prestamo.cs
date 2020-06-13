﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tutorial_EntityFrameworkCore.Models
{
    public class Prestamo
    {
        [Key]
        public int PrestamoId { get; set; }
        public int LibroId { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
    }
}