using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace yaxsi_elyire_m.quiz
{
    internal class Quiz
    {
        public int NumberOfQuestions { get; set; }
        public string Name { get; set; }
        public List<Question> Questions { get; set; }

        public Quiz(int id, string name)
        {

            Name = name;

            Questions = new List<Question>();
        }


    }
}
