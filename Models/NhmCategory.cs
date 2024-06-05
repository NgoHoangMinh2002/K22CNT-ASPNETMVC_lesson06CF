using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NhmLesson06CF.Models
{
    public class NhmCategory
    {
        [Key]
        public int NhmId { get; set; }
        public string NhmCategoryName { get; set; }
        //thuoc tinh quan he
        public virtual ICollection<NhmBook> NhmBooks { get; set; }

    }
}