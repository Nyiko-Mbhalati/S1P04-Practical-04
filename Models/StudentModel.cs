using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace nyikoStudyGroup.Models
{
	public class StudentModel
	{
		[Display(Name = "Student Number")]
		public string _studentNumber { get; set; }

		[Display(Name = "Name")]
		public string _name { get; set; }

        [Display(Name = "Surname")]
        public string _surname { get; set; }

        [Display(Name = "Email Address")]
        public string _emailAddress { get; set; }

		[Display(Name = "Link to Personal Page")]
		public string myLink { get; set; }
    }
}