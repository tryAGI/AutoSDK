//HintName: G.INamespaceClient.GetOrganization.g.cs
#nullable enable

namespace G
{
    public partial interface INamespaceClient
    {
        /// <summary>
        /// Get an organization<br/>
        /// Returns the organization details by its ID.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="view"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetOrganizationResponse> GetOrganizationAsync(
            string organizationId,
            global::G.GetOrganizationView? view = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}