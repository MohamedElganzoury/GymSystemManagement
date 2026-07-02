using GymManagementSystem.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementSystem.DAL.Models
{
    public class Trainer:GymUser
    {
        //Create Class Common Between Member & Trainer >> XXX Dublication
        public Specialty specialty{  get; set; }
        //HireDate=>>CreatedAT 
    }
}
