using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectReviewManagement
{
    public class ProjectReviewList
    {
        public static List<ProjectReview> Retrieve()
        {
            return ProjectList;
        }
        public  ProjectReviewList()
        {
            ProjectList = new List<ProjectReview>()
            {
                new ProjectReview(){ProjectId=1,StudentId=1,RatingOutof10=4,Review="Good",ProjectType="web based"},
                new ProjectReview(){ProjectId=2,StudentId=2,RatingOutof10=4,Review="Good",ProjectType="mobile app"},
                new ProjectReview(){ProjectId=2,StudentId=2,RatingOutof10=4,Review="Good",ProjectType="web based"},
                new ProjectReview(){ProjectId=3,StudentId=3,RatingOutof10=5,Review="Good",ProjectType="mobile app"},
                new ProjectReview(){ProjectId=4,StudentId=4,RatingOutof10=6,Review="Good",ProjectType="mobile app"},
                new ProjectReview(){ProjectId=5,StudentId=5,RatingOutof10=2,Review="nice",ProjectType="web based"},
                new ProjectReview(){ProjectId=6,StudentId=6,RatingOutof10=1,Review="bad",ProjectType="web based"},
                new ProjectReview(){ProjectId=7,StudentId=7,RatingOutof10=1,Review="Good",ProjectType="web based"},
                new ProjectReview(){ProjectId=8,StudentId=8,RatingOutof10=9,Review="nice",ProjectType="mobile app"},
                new ProjectReview(){ProjectId=9,StudentId=9,RatingOutof10=10,Review="nice",ProjectType="mobile app"},
                new ProjectReview(){ProjectId=10,StudentId=10,RatingOutof10=8,Review="nice",ProjectType="web based"},
                new ProjectReview(){ProjectId=11,StudentId=11,RatingOutof10=3,Review="nice",ProjectType="web based"}
            };
            
        }
        public static List<ProjectReview> ProjectList;
    }
}
