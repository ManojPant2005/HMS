using HMS.Model.DatabaseModel;

namespace HMS.Service.Interfaces
{
    public interface IAppointmentService
    {
        Task<Appointment> Insert(Appointment Appointment);
        Task<Appointment> Update(Appointment Appointment);
        Task<Appointment> GetById(string Id);
        Task<IEnumerable<Appointment>> GetByPatientId(string Id);
        Task<IEnumerable<Appointment>> GetByDoctorId(string Id);
        Task<IEnumerable<Appointment>> GetAll();



    }
}
