using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProjectReviewManagement
{
    public class Management
    {
        
        public static void TopProjects(List<ProjectReview> listProjectReview)
        {
            var recordedData = (from projectReviews in listProjectReview
                                orderby projectReviews.RatingOutof10 descending
                                select projectReviews).Take(4);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProjectId + " " + "StudentId:- " + list.StudentId
                    + " " + "RatingOutof10:- " + list.RatingOutof10 + " " + "Review:- " + list.Review + " " + "ProjectType:- " + list.ProjectType);
            }
        }
        public static void SelectedProjects(List<ProjectReview> listProjectReview)
        {
            var recordedData = from projectReviews in listProjectReview
                               where (projectReviews.ProjectId == 1 || projectReviews.ProjectId == 4 || projectReviews.ProjectId == 9)
                               && projectReviews.RatingOutof10 > 3
                               select projectReviews;
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:- " + list.ProjectId + " " + "StudentId:- " + list.StudentId
                    + " " + "RatingOutof10:- " + list.RatingOutof10 + " " + "Review:- " + list.Review + " " + "ProjectType:- " + list.ProjectType);
            }
        }
        public static void RetrieveCountOfProjectType(List<ProjectReview> listProjectReview)
        {
            var recordedData = listProjectReview.GroupBy(x => x.ProjectType).Select(x => new { ProjectType = x.Key, Count = x.Count() });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProjectType + "--------" + list.Count);
            }
        }
    }
}
