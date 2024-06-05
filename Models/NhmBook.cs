using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NhmLesson06CF.Models
{
    public class NhmBook
    {
        [Key]
        public int NhmID { get; set; }
        public string NhmBookId { get; set; }
        public string NhmTitle { get; set; }
        public string NhmAuthor { get; set; }
        public int NhmYear { get; set; }
        public string NhmPulisher { get; set; }
        public string NhmPicture { get; set; }
        public int NhmCategoryId { get; set; }
        //thuoc tinh quan he
        public virtual NhmCategory NhmCategory { get; set; }
    }
}