using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITMappingSystem.Models
{
    public class LifeCycle
    {
        public LifeCycle(string phase, DateTime startDate, DateTime endDate)
        {
            Phase = phase;
            StartDate = startDate;
            EndDate = endDate;
        }

        public string Phase { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}