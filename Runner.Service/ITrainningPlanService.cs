using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Runner.Service
{
    [ServiceContract]
    public interface ITrainningPlanService
    {
        [OperationContract]
        TrainningPlan Add(TrainningPlan trainningPlan);
        [OperationContract]
        List<TrainningPlan> GetByDate(string date);
        [OperationContract]
        List<TrainningPlan> GetAll();

        [OperationContract]
        void Remove(int id);
    }

}
