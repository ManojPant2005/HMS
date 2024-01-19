using HMS.Model.DatabaseModel;
using Microsoft.EntityFrameworkCore;

namespace HMS.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        #region Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        #endregion

        #region Fields
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        #endregion
    }
}
