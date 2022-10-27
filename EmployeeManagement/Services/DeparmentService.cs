using EmployeeManagement.Shared;

namespace EmployeeManagement.Services
{
    public class DeparmentService : ServiceBase<Deparment>
    {
        public DeparmentService(ApplicationDbContext context) : base(context)
        {

        }
    }
}
