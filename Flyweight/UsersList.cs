namespace Flyweight
{
    public class UsersList
    {
        private List<User> _usersList = new List<User>();
        private TermsFactory _termsFactory = new TermsFactory();

        public void Add(string name, string termsType,
            string termsContent, string termsColor)
        {
            TermsData data = _termsFactory.GetTerms(termsType, termsContent, termsColor);
            _usersList.Add(new User()
            {
                Name = name,
                TermsType = termsType,
                Terms = data
            });
        }

        public void StandardAdd(string name, string termsType,
            string termsContent, string termsColor)
        {
            _usersList.Add(new User()
            {
                Name = name,
                TermsType = termsType,
                Terms = new TermsData() { 
                    TermsColor = termsColor, 
                    TermsContent = termsContent 
                }
            });
        }

        public int GetCount()
        {
            return _usersList.Count;
        }
    }
}
