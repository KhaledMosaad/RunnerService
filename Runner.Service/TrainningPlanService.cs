using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner.Service
{
    public class TrainningPlanService : ITrainningPlanService
    {
        private static List<TrainningPlan> trainningPlans = new List<TrainningPlan>
        {
            new TrainningPlan{Date=DateTime.Parse("11/6/2021"),Distance=45,Id=1,Name="AlexMarthon"},
            new TrainningPlan{Date=DateTime.Parse("11/6/2021"),Distance=40,Id=2,Name="CairoMarthon"},
            new TrainningPlan{Date=DateTime.Parse("12/6/2021"),Distance=34,Id=3,Name="AlexMarthon"},
            new TrainningPlan{Date=DateTime.Parse("12/6/2021"),Distance=43,Id=4,Name="CairoMarthon"},
            new TrainningPlan{Date=DateTime.Parse("13/6/2021"),Distance=56,Id=5,Name="AlexMarthon"},
            new TrainningPlan{Date=DateTime.Parse("13/6/2021"),Distance=23,Id=6,Name="CairoMarthon"},
            new TrainningPlan{Date=DateTime.Parse("14/6/2021"),Distance=32,Id=7,Name="AlexMarthon"},
            new TrainningPlan{Date=DateTime.Parse("14/6/2021"),Distance=50,Id=8,Name="CairoMarthon"},
            new TrainningPlan{Date=DateTime.Parse("15/6/2021"),Distance=55,Id=9,Name="AlexMarthon"},
            new TrainningPlan{Date=DateTime.Parse("15/6/2021"),Distance=45,Id=10,Name="CairoMarthon"},
        };
        public TrainningPlan Add(TrainningPlan trainningPlan)
        {
           trainningPlans.Add(trainningPlan);
            return trainningPlan;
        }

        public List<TrainningPlan> GetAll()
        {
            return trainningPlans;
        }

        public List<TrainningPlan> GetByDate(string date)
        {
            return (List<TrainningPlan>)trainningPlans.Where(t => t.Date == DateTime.Parse(date));
        }

        public void Remove(int id)
        {
            trainningPlans.RemoveAll(t => t.Id == id);
        }
    }
}
