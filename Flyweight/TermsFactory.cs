using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class TermsFactory
    {
        private Dictionary<string, TermsData> _terms = new Dictionary<string, TermsData>();

        public TermsData GetTerms(string termsType, string termsContent, string termsColor)
        {
            if (!_terms.ContainsKey(termsType))
            {
                _terms.Add(termsType, new TermsData()
                {
                    TermsColor = termsColor,
                    TermsContent = termsContent
                });
            }

            return _terms[termsType];
        }
    }
}
