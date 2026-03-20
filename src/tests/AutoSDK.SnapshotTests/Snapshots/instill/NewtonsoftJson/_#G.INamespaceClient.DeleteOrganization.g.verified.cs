//HintName: G.INamespaceClient.DeleteOrganization.g.cs
#nullable enable

namespace G
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Delete an organization<br/>
        /// Accesses and deletes an organization by ID.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteOrganizationAsync(
            string organizationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}