using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Domain.Helper
{
    public static class Helper
    {
        public static bool ContainsIgnoreCase(
            this string p_strSentence,
            string p_strWord)
        {
            return p_strSentence.IndexOf(p_strWord, StringComparison.OrdinalIgnoreCase) > 0;
        }
    }
}
