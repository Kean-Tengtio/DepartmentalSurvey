//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Evaluation
    {
        public int EvaluationId { get; set; }
        public Nullable<System.DateTime> EvaluationDate { get; set; }
        public string Comment { get; set; }
        public int EvaluationPeriodId { get; set; }
    
        public virtual EvaluationPeriod EvaluationPeriod { get; set; }
    }
}
