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
    
    public partial class EvaluationDetail
    {
        public int EvaluationDetailId { get; set; }
        public int ItemId { get; set; }
        public Nullable<int> Score { get; set; }
        public byte[] RowVersion { get; set; }
    
        public virtual SurveyItems SurveyItems { get; set; }
    }
}
