using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication16.Controllers;

namespace MvcApplication16.Models
{
    public class PersonViewModel : BaseViewModel
    {
        public Person Person { get; set; }
    }
}