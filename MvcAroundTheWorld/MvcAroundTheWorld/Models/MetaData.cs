using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcAroundTheWorld.Models
{
    public class CompetitionEntryMetaData
    {
        [Required(ErrorMessage = "Please enter an email address")]
        [EmailAddress(ErrorMessage = "Must contain @ and . eg. Hi@gmail.com or beka@hotmail.com")]
        public string Email;

        [Required(ErrorMessage = "Please enter a classroom")]
        [RegularExpression("^[A-Z]{2}[0-9]{2}$", ErrorMessage = "Please enter two capital letters followed by two numbers, eg. KK12 or AB54")]
        public string CLASSROOM;
    }

    public class SchoolMetaData
    {
        [Required(ErrorMessage = "Please enter a school name")]
        [RegularExpression("^[a-zA-Z_ ]*$", ErrorMessage = "School name can only contain letters, eg. Victory School or Nelson Intermediate")]
        public string NAME;

        [Required(ErrorMessage = "Please enter a telephone number")]
        [RegularExpression("^[+0-9_ ]*$", ErrorMessage = "Please enter a correct phone number, eg. 03 593 0050 or +64 27 780 8328")]
        public string TELEPHONE;



        [Required(ErrorMessage = "Please enter an address")]
        [RegularExpression("^[a-zA-Z0-9_ ]*$", ErrorMessage = "Please enter a valid address, eg. 42 Vanguard Street or 55 Toi Toi Street")]
        public string ADDRESS;
    }
}