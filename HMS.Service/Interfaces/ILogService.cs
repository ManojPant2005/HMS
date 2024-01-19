using HMS.Model.DatabaseModel;

namespace HMS.Service.Interfaces
{
    public interface ILogService
    {
        Task Info(string message);
        Task Error(Exception exception);
    }
}
