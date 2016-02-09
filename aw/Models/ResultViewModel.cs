using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aw.Models
{
    public class ResultViewModel
    {
        public bool ShowResults { get; set; }
        public List<Result> Results { get; set; }
    }

    public class Result
    {
        public string Contestant { get; set; }
        public Dictionary<string, string> Answers { get; set; }
        public int Total { get; set; }
    }
}