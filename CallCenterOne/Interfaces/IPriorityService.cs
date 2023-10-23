using CallCenterOne.Models;

namespace CallCenterOne.Interfaces
{
    public interface IPriorityService
    {
        Priority GetPriorityById(int id);
        ICollection<Priority> GetAllPriorities();
        bool CreatePriority();
        bool UpdatePriority(int id);
        bool DeletePriority(int id);
    }
}
