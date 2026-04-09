//HintName: G.IApi.Authorizations.OrganizationId.g.cs

#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingOrganizationId(
            string apiKey);
    }
}