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
    
    public partial class CompetitionQuestion
    {
        public CompetitionQuestion()
        {
            this.ANSWERs = new HashSet<ANSWER>();
            this.CompetitionEntries = new HashSet<CompetitionEntry>();
        }
    
        public int CMQ_ID { get; set; }
        public string QUESTION { get; set; }
        public Nullable<int> COMP_ID { get; set; }
        public Nullable<int> CORRECT_ANSWER_ID { get; set; }
    
        public virtual ICollection<ANSWER> ANSWERs { get; set; }
        public virtual ANSWER ANSWER { get; set; }
        public virtual Competition Competition { get; set; }
        public virtual ICollection<CompetitionEntry> CompetitionEntries { get; set; }
    }
}