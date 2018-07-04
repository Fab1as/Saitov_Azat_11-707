using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpinionApp.Core
{
    public class Comment : ValueObject<Comment>
    {
        public string Text { get; set; }

        public Participant Participant { get; set; }

        public Comment(Participant participant, string text)
        {
            Text = text;
            Participant = participant;
        }

        public override string ToString()
        {
            return $"{Participant}\n{Text}";
        }
    }
}
