﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACTech.Models
{
    [Table("Student")]
    public partial class Student
    {
        public Student()
        {
            Grades = new HashSet<Grade>();
            StudentAddresses = new HashSet<StudentAddress>();
            StudentCompanies = new HashSet<StudentCompany>();
            StudentContacts = new HashSet<StudentContact>();
        }

        [Key]
        [Column("STUDENT_ID")]
        [StringLength(11)]
        public string StudentId { get; set; }
        [Column("FNAME")]
        [StringLength(17)]
        public string Fname { get; set; }
        [Column("MI")]
        [StringLength(2)]
        public string Mi { get; set; }
        [Column("LNAME")]
        [StringLength(23)]
        public string Lname { get; set; }
        [Column("DOB", TypeName = "date")]
        public DateTime? Dob { get; set; }
        [Column("Marital Status")]
        public int? MaritalStatus { get; set; }
        public int? Sex { get; set; }
        public int? Ethic { get; set; }
        public int? Education { get; set; }
        public int? Disability { get; set; }
        [Column("Disability Description")]
        [StringLength(30)]
        public string DisabilityDescription { get; set; }
        public int? Citizen { get; set; }
        public int? Veteran { get; set; }
        public bool? Financial { get; set; }
        [StringLength(8)]
        public string Advertisement { get; set; }
        [Column(TypeName = "image")]
        public byte[] Picture { get; set; }
        [Column("High School Transcript", TypeName = "text")]
        public string HighSchoolTranscript { get; set; }
        [Column(TypeName = "text")]
        public string Release { get; set; }
        [Column("High School Name")]
        [StringLength(50)]
        public string HighSchoolName { get; set; }
        [Column("High School Location")]
        [StringLength(50)]
        public string HighSchoolLocation { get; set; }
        [Column("CHE StudentID")]
        [StringLength(11)]
        public string CheStudentId { get; set; }
        [Column("CHE Student SS")]
        [StringLength(10)]
        public string CheStudentSs { get; set; }
        [Column("CHE DOB")]
        [StringLength(255)]
        public string CheDob { get; set; }
        [Column("CHE Sex")]
        public int? CheSex { get; set; }
        [Column("CHE Race")]
        public int? CheRace { get; set; }
        [Column("CHE HS Code")]
        public int? CheHsCode { get; set; }
        [Column("CHE Date Graduated")]
        [StringLength(11)]
        public string CheDateGraduated { get; set; }

        [InverseProperty(nameof(Grade.Student))]
        public virtual ICollection<Grade> Grades { get; set; }
        [InverseProperty(nameof(StudentAddress.Student))]
        public virtual ICollection<StudentAddress> StudentAddresses { get; set; }
        [InverseProperty(nameof(StudentCompany.Student))]
        public virtual ICollection<StudentCompany> StudentCompanies { get; set; }
        [InverseProperty(nameof(StudentContact.Student))]
        public virtual ICollection<StudentContact> StudentContacts { get; set; }
    }
}