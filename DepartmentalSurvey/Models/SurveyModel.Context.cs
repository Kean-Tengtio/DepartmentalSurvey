﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DepartmentalSurvey.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DepartmentalSurveyEntities : DbContext
    {
        public DepartmentalSurveyEntities()
            : base("name=DepartmentalSurveyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Evaluation> Evaluation { get; set; }
        public virtual DbSet<SchoolYear> SchoolYear { get; set; }
        public virtual DbSet<EvaluationDetail> EvaluationDetail { get; set; }
        public virtual DbSet<EvaluationPeriod> EvaluationPeriod { get; set; }
        public virtual DbSet<SurveyItems> SurveyItems { get; set; }
    }
}
