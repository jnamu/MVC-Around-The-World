//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcAroundTheWorld.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompetitionEntry
    {
        public int CompEntry_ID { get; set; }
        public string Email { get; set; }
        public string CLASSROOM { get; set; }
        public Nullable<int> SCHOOL_ID { get; set; }
        public Nullable<int> GIVEN_ANSWER_ID { get; set; }
        public Nullable<int> COMP_ID { get; set; }
        public Nullable<int> CMQ_ID { get; set; }
    
        public virtual ANSWER ANSWER { get; set; }
        public virtual Competition Competition { get; set; }
        public virtual CompetitionQuestion CompetitionQuestion { get; set; }
        public virtual School School { get; set; }
    }
}
