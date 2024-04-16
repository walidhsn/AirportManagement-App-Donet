﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    [Owned] // installation d'un package Microsoft.EntityFrameworkCore Abstraction
    // 1 ere methode de config de type Complexe = detenu 
    public class FullName
    {

        public string FirstName { get; set; }
        [MaxLength(25)]
        [MinLength(3)]
        public string LastName { get; set; }

    }
}
