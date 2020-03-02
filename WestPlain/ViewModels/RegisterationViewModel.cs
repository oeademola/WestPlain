using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WestPlain.Models;

namespace WestPlain.ViewModels
{
    public class RegisterationViewModel
    {
        public IEnumerable<BusinessType> BusinessTypes { get; set; }
        public Register Register { get; set; }
    }
}