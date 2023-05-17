using FlightPlanApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlightPlanApi.Data
{
    public interface IDatabaseAdapter
    {
        Task<List<FlightPlan>> GetAllFlightPlans();

        Task<FlightPlan> GetFlightPlanById(string flightPlanId);

        Task<TransactionResult> FileFlightPlan(FlightPlan flightPlan);

        Task<TransactionResult> UpdateFlightPlan(string flightPlanId, FlightPlan flightPlan);

        Task<bool> DeleteFlightPlanById(string flightPlanId);
    }
}
