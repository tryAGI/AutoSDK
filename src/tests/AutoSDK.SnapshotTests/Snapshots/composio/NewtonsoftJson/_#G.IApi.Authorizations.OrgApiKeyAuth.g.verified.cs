//HintName: G.IApi.Authorizations.OrgApiKeyAuth.g.cs

#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingOrgApiKeyAuth(
            string apiKey);
    }
}