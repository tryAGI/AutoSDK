//HintName: G.IOrgsClient.OrgsListMembershipsForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List organization memberships for the authenticated user<br/>
        /// Lists all of the authenticated user's organization memberships.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.OrgMembership>> OrgsListMembershipsForAuthenticatedUserAsync(
            global::G.OrgsListMembershipsForAuthenticatedUserState? state = default,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}