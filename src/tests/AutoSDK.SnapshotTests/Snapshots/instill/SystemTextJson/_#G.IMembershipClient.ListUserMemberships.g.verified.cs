//HintName: G.IMembershipClient.ListUserMemberships.g.cs
#nullable enable

namespace G
{
    public partial interface IMembershipClient
    {
        /// <summary>
        /// List user memberships<br/>
        /// Returns the memberships of a user.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListUserMembershipsResponse> ListUserMembershipsAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}