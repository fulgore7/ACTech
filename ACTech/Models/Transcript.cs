using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACTech.Models
{
    public class Transcript
    {
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
        [Column("ADDRESS")]
        [StringLength(30)]
        public string Address { get; set; }
        [Column("Citystatezip")]
        public string CityStateZip { get; set; }
        [Column("PHONE")]
        [StringLength(14)]
        public string Phone { get; set; }
        [Column("SEM")]
        public int Sem { get; set; }
        [Column("Course")]
        [StringLength(10)]
        public string CourseName { get; set; }
        [Column("PRE ASSESSMENT")]
        public int? PreAssessment { get; set; }
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
        [Column("ADJ")]
        public int? Adj { get; set; }
        [Column("OJT")]
        public int? Ojt { get; set; }
        public int? pts {
            get { return S1 + S2 + S3 + S4 + S5 + S6 + S7 + S8 + S9 + S10; } 
        }
        public int? csc
        {
            get { return pts/300-Adj; }
        }
        public int? fsc
        {
            get { return (pts + Ojt)/(400 - Adj); }
        }
        [Column("CERT")]
        [StringLength(50)]
        public string Cert { get; set; }

    }
}
