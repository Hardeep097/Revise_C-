using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public interface IScored
    {
        public float Score { get; set; }
        public float MaximumScore { get; set; }
    }
}
