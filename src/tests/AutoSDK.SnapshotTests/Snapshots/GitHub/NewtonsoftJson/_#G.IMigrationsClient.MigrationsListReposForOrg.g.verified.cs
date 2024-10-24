//HintName: G.IMigrationsClient.MigrationsListReposForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IMigrationsClient
    {
        /// <summary>
        /// List repositories in an organization migration<br/>
        /// List all the repositories for this organization migration.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="migrationId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MinimalRepository>> MigrationsListReposForOrgAsync(
            string org,
            int migrationId,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}