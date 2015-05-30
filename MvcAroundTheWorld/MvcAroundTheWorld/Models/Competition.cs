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
    
    public partial class Competition
    {
        public Competition()
        {
            this.CompetitionEntries = new HashSet<CompetitionEntry>();
            this.CompetitionQuestions = new HashSet<CompetitionQuestion>();
        }
    
        public int COMP_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<System.DateTime> START_DATE { get; set; }
        public Nullable<System.DateTime> END_DATE { get; set; }
    
        public virtual ICollection<CompetitionEntry> CompetitionEntries { get; set; }
        public virtual ICollection<CompetitionQuestion> CompetitionQuestions { get; set; }
    }
}
