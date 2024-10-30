//HintName: G.INamespaceClient.GetUserMembership.g.cs
#nullable enable

namespace G
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Get a user membership<br/>
        /// Returns the details of the relationship between a user and an<br/>
        /// organization. The authenticated must match the membership parent.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="organizationId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetUserMembershipResponse> GetUserMembershipAsync(
            string userId,
            string organizationId,
            global::G.GetUserMembershipView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}