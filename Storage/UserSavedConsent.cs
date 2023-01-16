using System.Collections.Generic;

namespace IdentityServer4
{
    public class UserSavedConsent
    {
        public string UserID { get; set; }
        public string ClientID { get; set; }
        public IEnumerable<string> Scopes { get; set; }
    }
}
