namespace Project_Server
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataMember(Name = "SSN", Order = 0)]
        public int SSN { get; set; }

        [Required]
        [StringLength(50)]
        [DataMember(Name = "Name", Order = 1)]
        public string Name { get; set; }

        [StringLength(50)]
        [DataMember(Name = "Phone", Order = 2)]
        public string Phone { get; set; }

        [DataMember(Name = "Salary", Order = 3)]
        public decimal? Salary { get; set; }

        [DataMember(Name = "Department", Order = 4)]
        public int? DP_ID { get; set; }

        public virtual Department Department { get; set; }
    }
}