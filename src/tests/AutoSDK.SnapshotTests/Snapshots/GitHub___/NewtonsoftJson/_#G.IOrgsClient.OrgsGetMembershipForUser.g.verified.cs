//HintName: G.IOrgsClient.OrgsGetMembershipForUser.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get organization membership for a user<br/>
        /// In order to get a user's membership with an organization, the authenticated user must be an organization member. The `state` parameter in the response can be used to identify the user's membership status.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrgMembership> OrgsGetMembershipForUserAsync(
            string org,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}