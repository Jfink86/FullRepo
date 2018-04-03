using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcSampleProject.Models
{
    public class Class1
    {
        [Key]
        public int SuggsID { get; set; }

        public string Topic { get; set; }
        public string Suggs { get; set; }

        [Key]
        public int CommentId { get; set; }

        public string Location { get; set; }
        public string Comments { get; set; }

        [Key]
        public int ReviewsId { get; set; }

        public string Description { get; set; }
        public string Reviews { get; set; }

        [Key]
        public int SurveyId { get; set; }

        public string Feedback { get; set; }
        public string Survey { get; set; }

    }
}