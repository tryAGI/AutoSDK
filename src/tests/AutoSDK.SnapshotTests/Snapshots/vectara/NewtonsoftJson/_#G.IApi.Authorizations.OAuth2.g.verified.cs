//HintName: G.IApi.Authorizations.OAuth2.g.cs

#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Authorize using OAuth2 authentication with client credentials.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="scope"></param>
        /// <param name="cancellationToken"></param>
        public global::System.Threading.Tasks.Task AuthorizeUsingOAuth2WithCredentialsAsync(
            string clientId,
            string clientSecret,
            string scope,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}