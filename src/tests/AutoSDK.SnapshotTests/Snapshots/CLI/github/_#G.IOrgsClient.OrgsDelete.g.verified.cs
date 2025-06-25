//HintName: G.IOrgsClient.OrgsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Delete an organization<br/>
        /// Deletes an organization and all its repositories.<br/>
        /// The organization login will be unavailable for 90 days after deletion.<br/>
        /// Please review the Terms of Service regarding account deletion before using this endpoint:<br/>
        /// https://docs.github.com/site-policy/github-terms/github-terms-of-service
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OrgsDeleteAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}