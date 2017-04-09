using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NinjaDomain.Classes
{
    public class Ninja 
    {
        public int Id  { get; set; }

        
        [StringLength(500, MinimumLength = 3)]
        public string Name { get; set; }
     
        public int ServedInOniwabanValue{ get; set; }

        public System.DateTime DateOfBirth { get; set; }

        [NotMapped]
        public bool ServedInOniwaban
        {
            get
            {
                return Convert.ToBoolean(ServedInOniwabanValue);
            }
            set
            {
                ServedInOniwabanValue = Convert.ToInt32(value);
            }
        }
   
        public Clan Clan  { get; set; }
        public int ClanId { get; set; }
        public List<NinjaEquipment> EquipmentOwned { get; set; }
    }

    public class Clan
    {
        public int Id { get; set; }
       
        [StringLength(100,MinimumLength =3)]
        public string ClanName { get; set; }
        
        public List<Ninja> Ninjas { get; set; }
    }

    public class NinjaEquipment
    {
        public int Id { get; set; }
        [StringLength(500, MinimumLength = 3)]
        public string Name  { get; set; }
     
        public EquipmentType Type { get; set; }

        [Required]
        public Ninja Ninja { get; set; }
       
    } 
}

