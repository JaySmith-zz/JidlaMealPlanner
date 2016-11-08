﻿using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace Jidla.Web.Data
{
    public class PreperationStep
    {
        [Key]
        public int Id { get; set; }
        public int Sequence { get; set; }
        public string Description { get; set; } 
    }
}