//HintName: G.IMigrationsClient.MigrationsGetStatusForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IMigrationsClient
    {
        /// <summary>
        /// Get an organization migration status<br/>
        /// Fetches the status of a migration.<br/>
        /// The `state` of a migration can be one of the following values:<br/>
        /// *   `pending`, which means the migration hasn't started yet.<br/>
        /// *   `exporting`, which means the migration is in progress.<br/>
        /// *   `exported`, which means the migration finished successfully.<br/>
        /// *   `failed`, which means the migration failed.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="migrationId"></param>
        /// <param name="exclude"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Migration> MigrationsGetStatusForOrgAsync(
            string org,
            int migrationId,
            global::System.Collections.Generic.IList<global::G.MigrationsGetStatusForOrgExcludeItem>? exclude = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}