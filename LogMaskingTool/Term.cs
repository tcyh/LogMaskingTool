using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogMaskingTool
{
    internal class Term
    {
        
        public Term(string originalTerm, string replacedTerm, TermType termType)
        {
            
            OriginalTerm = originalTerm;
            ReplacedTerm = replacedTerm;
            
        }

        public string OriginalTerm { get; set; }
        public string ReplacedTerm { get; set; }
        public enum TermType { word , regex };
        

    }



}
