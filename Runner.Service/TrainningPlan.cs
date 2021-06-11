using System;

namespace Runner.Service
{
    public class TrainningPlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date{ get; set; }
        public int Distance { get; set; }
    }
}