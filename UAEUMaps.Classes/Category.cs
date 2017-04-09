using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAEUMaps.Classes
{
    public class Category : IModificationHistory
    {
        public int Id { get; set; }

        [Required, StringLength(250), DataType(DataType.Text)]
        public string Title { get; set; }

        [Required, StringLength(250), DataType(DataType.Text)]
        public string TitleArabic  { get; set; }
         
        public int ParentCategoryId { get; set; }
        [ForeignKey("ParentCategoryId")]
        public Category ParentCategory  { get; set; }

        public ICollection<Category> ChildCategories { get; set; }
        public string Created { get; set; }
        public DateTime CreatedDate { get; set; }

        public string Modified { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Remarks { get; set; }


    }
}
