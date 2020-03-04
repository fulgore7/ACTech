﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACTech.Models
{
    [Table("Grade")]
    public partial class Grade
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("STUDENT_ID")]
        [StringLength(11)]
        public string StudentId { get; set; }
        [Column("COURSE_ID")]
        public int CourseId { get; set; }
        [Column("SEM")]
        public int Sem { get; set; }
        [Column("SECTION")]
        [StringLength(3)]
        public string Section { get; set; }
        [Column("DATE", TypeName = "date")]
        public DateTime Date { get; set; }
        [Column("PAID", TypeName = "smallmoney")]
        public decimal? Paid { get; set; }
        [Column("REF")]
        [StringLength(30)]
        public string Ref { get; set; }
        [Column("MEMO")]
        [StringLength(50)]
        public string Memo { get; set; }
        public int? S1 { get; set; }
        public int? S2 { get; set; }
        public int? S3 { get; set; }
        public int? S4 { get; set; }
        public int? S5 { get; set; }
        public int? S6 { get; set; }
        public int? S7 { get; set; }
        public int? S8 { get; set; }
        public int? S9 { get; set; }
        public int? S10 { get; set; }
        [Column("EC")]
        public int? Ec { get; set; }
        [Column("ADJ")]
        public int? Adj { get; set; }
        [Column("OJT")]
        public int? Ojt { get; set; }
        [Column("CERT")]
        [StringLength(50)]
        public string Cert { get; set; }
        [Column("CERT NUMBER")]
        [StringLength(70)]
        public string CertNumber { get; set; }
        [StringLength(3)]
        public string A1 { get; set; }
        [StringLength(3)]
        public string A2 { get; set; }
        [StringLength(3)]
        public string A3 { get; set; }
        [StringLength(3)]
        public string A4 { get; set; }
        [StringLength(3)]
        public string A5 { get; set; }
        [StringLength(3)]
        public string A6 { get; set; }
        [StringLength(3)]
        public string A7 { get; set; }
        [StringLength(3)]
        public string A8 { get; set; }
        [StringLength(3)]
        public string A9 { get; set; }
        [StringLength(3)]
        public string A10 { get; set; }
        [Column("OJT Documentation")]
        public string OjtDocumentation { get; set; }
        [Column("LOC")]
        [StringLength(5)]
        public string Loc { get; set; }
        [Column("PRE ASSESSMENT")]
        public int? PreAssessment { get; set; }

        [ForeignKey(nameof(CourseId))]
        [InverseProperty("Grades")]
        public virtual Course Course { get; set; }
        [ForeignKey(nameof(StudentId))]
        [InverseProperty("Grades")]
        public virtual Student Student { get; set; }
    }
}