//HintName: G.IOrganizationsClient.Get3.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Get organization member details<br/>
        /// Get organization member details by user ID.
        /// </summary>
        /// <param name="contributedToProjects"></param>
        /// <param name="id"></param>
        /// <param name="userPk"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrganizationMember> Get3Async(
            int id,
            int userPk,
            bool? contributedToProjects = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}