//HintName: G.IOrganizationClient.DeleteOrganization.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// Delete an organization<br/>
        /// Accesses and deletes an organization by ID.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteOrganizationResponse> DeleteOrganizationAsync(
            string organizationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}