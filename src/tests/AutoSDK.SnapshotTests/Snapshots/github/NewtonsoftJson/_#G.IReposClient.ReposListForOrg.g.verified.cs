//HintName: G.IReposClient.ReposListForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List organization repositories<br/>
        /// Lists repositories for the specified organization.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; In order to see the `security_and_analysis` block for a repository you must have admin permissions for the repository or be an owner or security manager for the organization that owns the repository. For more information, see "[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization)."
        /// </summary>
        /// <param name="org"></param>
        /// <param name="type">
        /// Default Value: all
        /// </param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MinimalRepository>> ReposListForOrgAsync(
            string org,
            global::G.ReposListForOrgType? type = default,
            global::G.ReposListForOrgSort? sort = default,
            global::G.ReposListForOrgDirection? direction = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}