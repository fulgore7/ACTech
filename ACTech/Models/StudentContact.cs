﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACTech.Models
{
    [Table("Student Contact")]
    public partial class StudentContact
    {
        [Key]
        public int Id { get; set; }
        [Column("STUDENT_ID")]
        [StringLength(11)]
        public string StudentId { get; set; }
        [Column("HOME PHONE")]
        [StringLength(14)]
        public string HomePhone { get; set; }
        [Column("CELL PHONE")]
        [StringLength(14)]
        public string CellPhone { get; set; }
        [Column("OTHER PHONE")]
        [StringLength(14)]
        public string OtherPhone { get; set; }
        [Column("EMAIL")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("EMERGENCY CONTACT")]
        [StringLength(50)]
        public string EmergencyContact { get; set; }
        [Column("EMERGENCY CONTACT RELATION")]
        [StringLength(50)]
        public string EmergencyContactRelation { get; set; }
        [Column("EMERGENCY CONTACT PHONE")]
        [StringLength(14)]
        public string EmergencyContactPhone { get; set; }
        [Column("EMERGENCY CONTACT ADDRESS")]
        [StringLength(50)]
        public string EmergencyContactAddress { get; set; }

        [ForeignKey(nameof(StudentId))]
        [InverseProperty("StudentContacts")]
        public virtual Student Student { get; set; }
    }
}