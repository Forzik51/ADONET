using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityIntro21._01._22.Data.Models
{
    public class FootballTeam
    {
        
            public int Id { get; set; }
            public string Name { get; set; }
            public string City { get; set; }
            public short? Win { get; set; }
            public short? Loss { get; set; }
            public short? GoalsScored { get; set; }
            public short? GoalsConceded { get; set; }
        

    }
}
