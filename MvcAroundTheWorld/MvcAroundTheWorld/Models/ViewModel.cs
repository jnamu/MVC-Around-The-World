using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcAroundTheWorld.Models
{
    public class ViewModel
    {
        public COMPETITIONEntities db = new COMPETITIONEntities();

        public void SaveEntry()
        {
            CompetitionEntry.CMQ_ID = CompetitionQuestion.CMQ_ID;
            CompetitionEntry.COMP_ID = COMP_ID;
            CompetitionEntry.GIVEN_ANSWER_ID = SelectedAnswer;
            db.CompetitionEntries.Add(CompetitionEntry);
            db.SaveChanges();
        }

        public List<string> GetSuggestion( string pStrSuggestion)
        {
            List<string> result = new List<string>();
            var suggestedNames = db.GetSuggestion(pStrSuggestion);
            foreach (var a in suggestedNames)
            {
                result.Add(a);
            }
            return result;
        }

        public ViewModel()
        {
            var result = db.GetQuestion().First();
            CompetitionQuestion = new CompetitionQuestion();
            CompetitionQuestion.CMQ_ID = result.CMQ_ID;
            CompetitionQuestion.QUESTION = result.QUESTION;
            COMP_ID = result.COMP_ID;
            var resultAnswers = db.GetAnswers(result.CMQ_ID).ToList();

            //ANSWERS
            Answers = new List<ANSWER>();
            foreach (GetAnswers_Result a in resultAnswers)
            {
                ANSWER Ans = new ANSWER();
                Ans.CMQ_ID = result.CMQ_ID;
                Ans.Answer_Text = a.Answer_Text;
                Ans.IS_CORRECT = a.IS_CORRECT;
                Ans.ID = a.ID;

                Answers.Add(Ans);
            }
        }

        public ANSWER Answer { get; set; }
        public Competition Competition { get; set; }
        public CompetitionQuestion CompetitionQuestion { get; set; }
        public CompetitionEntry CompetitionEntry { get; set; }
        public School School { get; set; }

        public Int32 SelectedAnswer { get; set; }
        public Int32 COMP_ID { get; set; }
        public virtual List<ANSWER> Answers { get; set; }
    }
}