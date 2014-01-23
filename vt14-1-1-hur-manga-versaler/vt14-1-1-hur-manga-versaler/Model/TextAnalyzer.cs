using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vt14_1_1_hur_manga_versaler.Model {
    public static class TextAnalyzer {
        public static int GetNumberOfCapitals(string text) {
            int i = 0;
            foreach (char c in text) {
                if (Char.IsUpper(c)) {
                    i++;
                }
            }
            return i;
        }
    }
}