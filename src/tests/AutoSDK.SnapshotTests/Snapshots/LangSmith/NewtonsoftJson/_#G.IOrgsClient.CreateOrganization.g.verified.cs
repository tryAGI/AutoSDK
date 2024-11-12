//HintName: G.IOrgsClient.CreateOrganization.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Create Organization
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrganizationPGSchemaSlim> CreateOrganizationAsync(
            global::G.OrganizationCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Organization
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="isPersonal"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrganizationPGSchemaSlim> CreateOrganizationAsync(
            string displayName,
            bool isPersonal,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}