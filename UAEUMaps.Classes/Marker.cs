using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAEUMaps.Classes
{
    public class Marker : IModificationHistory
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int ParentCategoryId { get; set; }
        [ForeignKey("ParentCategoryId")]
        public Category Category  { get; set; }

        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string Description { get; set; }
        public string DescriptionArabic { get; set; }
        public int AccessListId { get; set; }
        [ForeignKey("AccessListId")]
        public AccessList AccessList { get; set; }

        public string Location  { get; set; }
        public string Contact { get; set; }
        public string ImageURL { get; set; }
        public string Link  { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string OtherInformation  { get; set; }
        public int Display  { get; set; }


        public int ParentMarkerId  { get; set; }
        [ForeignKey("ParentMarkerId")]
        public Marker ParentMarker { get; set; }

        public ICollection<Marker> ChildMarks  { get; set; }

        public string Created { get; set; }
        public DateTime CreatedDate { get; set; }

        public string Modified { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Remarks { get; set; }


    }
}
