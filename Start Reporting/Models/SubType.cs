using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Start_Reporting.Models
{
        public enum SubType

    {
        //--
        //--
        //--
        //--
        //--Built 1--15-262--Hard Coded- Do Not Change the Lines
        Assessment,
        [Display(Name = "2 Month Assessment")]
        two_Month_Assessment,
        [Display(Name = "2 or 3 Month Assessment Email Discussion")]
        two_or_3_Month_Assessment_Email_Discussion,
        [Display(Name = "Attending 6 Month Assessment Call")]
        Attending_6_Month_Assessment_Call,
        [Display(Name = "Creating Adhoc reports & maintaining about project")]
        Creating_Adhoc_reports_and_maintaining_about_project,
        [Display(Name = "Shadowing for 6 Month Assessment")]
        Shadowing_for_6_Month_Assessment,
        [Display(Name = "Discussion of training set feedback written by TTT")]
        Discussion_of_training_set_feedback_written_by_TTT,
        [Display(Name = "Discussion of feedback with trainee")]
        Discussion_of_feedback_with_trainee,
        Feedback,
        [Display(Name = "Biweekly Feedback Discussion")]
        Biweekly_Feedback_Discussion,
        [Display(Name = "Discussion of Feedback Written")]
        Discussion_of_Feedback_Written,
        [Display(Name = "Review of Questionable tasks and providing feedback")]
        Review_of_Questionable_tasks_and_providing_feedback,
        [Display(Name = "Writing Feedback for Training Sets")]
        Writing_Feedback_for_Training_Sets,
        [Display(Name = "Feedback Tracker - M1")]
        Feedback_Tracker_M1,
        [Display(Name = "Feedback Tracker - M2")]
        Feedback_Tracker_M2,
        Meetings,
        [Display(Name = "Adhoc Discussion of Doubts")]
        Adhoc_Discussion_of_Doubts,
        [Display(Name = "Random Meetings (Twice a week)")]
        Random_Meetings_Twice_a_week,
        [Display(Name = "SME Meeting")]
        SME_Meeting,
        Mentoring
    }
}