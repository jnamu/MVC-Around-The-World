using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcAroundTheWorld.Models
{
    [MetadataType(typeof(SchoolMetaData))]
    public partial class School
    {
    }

    [MetadataType(typeof(CompetitionEntryMetaData))]
    public partial class CompetitionEntry
    {
    }
}