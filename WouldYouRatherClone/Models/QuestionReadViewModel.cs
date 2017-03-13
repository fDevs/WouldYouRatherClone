using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WouldYouRatherClone.Models
{
    public class QuestionReadViewModel
    {
        public string QuestionText { get; set; }
        public string Answer1Text { get; set; }
        public int Answer1Score { get; set; }
        public string Answer2Text { get; set; }
        public int Answer2Score { get; set; }
    }
}

