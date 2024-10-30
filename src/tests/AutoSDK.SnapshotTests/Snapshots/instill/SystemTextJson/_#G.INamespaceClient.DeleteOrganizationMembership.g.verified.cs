//HintName: G.INamespaceClient.DeleteOrganizationMembership.g.cs
#nullable enable

namespace G
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Delete an organization membership<br/>
        /// Deletes a user membership within an organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteOrganizationMembershipAsync(
            string organizationId,
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}