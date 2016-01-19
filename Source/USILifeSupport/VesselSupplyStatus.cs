using System;

namespace LifeSupport
{
    public class VesselSupplyStatus
    {
        public string VesselId { get; set; }
        public string VesselName { get; set; }
        public double LastUpdate { get; set; }
        public int NumCrew { get; set; }
        public float RecyclerMultiplier { get; set; }
        public int CrewCap { get; set; }
        public double HabSpace { get; set; }
        public double HabMultiplier { get; set; }
        public double SuppliesLeft { get; set; }
        public double LastFeeding { get; set; }
    }
}