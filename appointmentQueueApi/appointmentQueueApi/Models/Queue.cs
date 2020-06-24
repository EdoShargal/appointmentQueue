namespace appointmentQueueApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Queue
    {
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public int? Status { get; set; }

        [Required]
        public DateTime? Hour { get; set; }
    }
}
