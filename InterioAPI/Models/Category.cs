﻿using System;
using System.Collections.Generic;

#nullable disable

namespace InterioAPI.Models
{
    public partial class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
