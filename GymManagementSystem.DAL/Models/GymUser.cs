using GymManagementSystem.DAL.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementSystem.DAL.Models
{
    public abstract class GymUser:BaseEntity // abstract>> عشان محدش يكريت اوبجيكت من الكلاس ده دا تنظيم للكود بس
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public DateOnly DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Address address { get; set; }
        

    }
    [Owned]
    public class Address
    {
        public int BuildingNumber { get; set; }
        public string Street { get; set; } = default!;
        public string City { get; set; } = default!;

    }
}
}
