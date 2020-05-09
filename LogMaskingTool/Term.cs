using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogMaskingTool
{
    class Term
    {
        public Term(string originalTerm, string replacedTerm)
        {
            OriginalTerm = originalTerm;
            ReplacedTerm = replacedTerm;
        }

        public string OriginalTerm { get; set; }
        public string ReplacedTerm { get; set; }

    }



}
