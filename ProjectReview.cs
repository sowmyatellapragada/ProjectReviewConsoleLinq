using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectReviewManagement
{
    
        public class ProjectReview
        {
            public int ProjectId { get; set; }
            public int StudentId { get; set; }
            public double RatingOutof10 { get; set; }
            public string Review { get; set; }
            public string ProjectType { get; set; }
        }
    

}
