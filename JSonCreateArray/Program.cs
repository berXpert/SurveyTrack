using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSonCreateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var Surveys = new List<SurveytrackD>();

            Surveys.Add( new SurveytrackD { id = "26", appsurvey = "1", fk_curriculumid = "70", status = "Completed", learnerid = "240"  } );
            Surveys.Add( new SurveytrackD { id = "27", appsurvey = "1", fk_curriculumid = "71", status = "Completed", learnerid = "241" });


            foreach (var survey in Surveys)
            {
                survey.questions = new List<Question>();

                survey.questions.Add(new Question { questionid = "1", feedback = "0" });
                survey.questions.Add(new Question { questionid = "2", feedback = "1" });
            }

            var json = JsonConvert.SerializeObject(Surveys, Formatting.Indented);

            Console.WriteLine(json);
            Console.ReadLine();
        }
    }

    public class SurveytrackD
    {
        public string fk_clientid { get; set; }
        public string learnerid { get; set; }
        public string appsurvey { get; set; }
        public string id { get; set; }
        public string fk_curriculumid { get; set; }
        public string status { get; set; }
        public string lastaccessedon { get; set; }

        public List<Question> questions { get; set; }
    }

    public class Question
    {
        public string feedback { get; set; }
        public string questionid { get; set; }
    }
}
