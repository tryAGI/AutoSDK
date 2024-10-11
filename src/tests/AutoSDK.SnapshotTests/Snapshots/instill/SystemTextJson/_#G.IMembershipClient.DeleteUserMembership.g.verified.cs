//HintName: G.IMembershipClient.DeleteUserMembership.g.cs
#nullable enable

namespace G
{
    public partial interface IMembershipClient
    {
        /// <summary>
        /// Delete a user membership<br/>
        /// Accesses and deletes a user membership by parent and membership IDs.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="organizationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<object> DeleteUserMembershipAsync(
            string userId,
            string organizationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}