namespace appointmentQueueApi.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QueuesDB : DbContext
    {
        public QueuesDB()
            : base("name=QueuesDB")
        {
        }

        public virtual DbSet<Queue> Queues { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Queue>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
