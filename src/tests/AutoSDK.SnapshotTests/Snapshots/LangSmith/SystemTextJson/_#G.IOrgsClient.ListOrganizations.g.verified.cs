//HintName: G.IOrgsClient.ListOrganizations.g.cs
#nullable enable

namespace G
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List Organizations<br/>
        /// Get all orgs visible to this auth
        /// </summary>
        /// <param name="skipCreate">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.OrganizationPGSchemaSlim>> ListOrganizationsAsync(
            bool? skipCreate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}