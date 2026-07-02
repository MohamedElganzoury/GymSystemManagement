using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementSystem.DAL.Models
{
    public class HealthRecord:BaseEntity
    {
        public decimal Height {  get; set; }
        public decimal Weight {  get; set; }
        public string? Note {  get; set; }
        public string BloodType {  get; set; }
        //LastUpdate=Updated At in BaseEntity >>changeName At Configuration
    }
}
