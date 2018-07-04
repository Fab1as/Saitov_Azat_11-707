using System;

namespace OpinionApp.Core
{
    public class Opinion : Identity
    {
        public string Text { get; set; }

        public Objective Objective { get; set; }

        //public Participant Participant { get; set; }

       // public ICollection<Comment> Comments { get; set; }


        public static Opinion CreateOpinion(string text, Objective obj)
        {
            return new Opinion
            {
                Text = text,
                Id = Guid.NewGuid(),
                Objective = obj,
                //Participant = participant,
                //Comments = new List<Comment>()
            };
        }

        //public void AddComment(Comment comment)
        //{
        //    Comments.Add(comment);
        //}

        //public void AddComment(Participant participant, string text)
        //{
        //    AddComment(new Comment(participant, text));
        //}

        //public override string ToString()
        //{
        //    var builder = new StringBuilder();
        //    builder.Append($"{Participant}\n{Text}");

        //    foreach (var comment in Comments)
        //    {
        //        builder.Append($"\n\n\t{comment}");
        //    }

        //    return builder.ToString();
        //}
    }
}
