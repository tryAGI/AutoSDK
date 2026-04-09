//HintName: G.IOrgsClient.OrgsCheckPublicMembershipForUser.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Check public organization membership for a user<br/>
        /// Check if the provided user is a public member of the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OrgsCheckPublicMembershipForUserAsync(
            string org,
            string username,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}