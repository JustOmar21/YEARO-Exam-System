using System;
using System.Collections.Generic;

namespace Desktop.Models;

public partial class Question
{
    public int ID { get; set; }

    public string Body { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int Degree { get; set; }

    public string CorrectChoice { get; set; } = null!;

    public virtual ICollection<Answer_Exam> Answer_Exams { get; set; } = new List<Answer_Exam>();

    public virtual ICollection<Choice> Choices { get; set; } = new List<Choice>();
}
