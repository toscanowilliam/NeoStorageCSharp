using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NeoStorageCSharp.Database
{
    public class Location
    {

        [Key]
        public int Id { get; set; }
        public string Area { get; set; }
        public string Bin { get; set; }

    }
}