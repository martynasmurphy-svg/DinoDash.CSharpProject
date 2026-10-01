using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trex_game
{
    // Custom Exception
    public class QuizLoadException : Exception
    {
        public QuizLoadException(string message) : base(message)
        {
        }
    }
}
