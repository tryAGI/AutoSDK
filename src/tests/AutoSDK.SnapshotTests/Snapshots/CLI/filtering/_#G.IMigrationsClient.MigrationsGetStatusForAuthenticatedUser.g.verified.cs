//HintName: G.IMigrationsClient.MigrationsGetStatusForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IMigrationsClient
    {
        /// <summary>
        /// Get a user migration status<br/>
        /// Fetches a single user migration. The response includes the `state` of the migration, which can be one of the following values:<br/>
        /// *   `pending` - the migration hasn't started yet.<br/>
        /// *   `exporting` - the migration is in progress.<br/>
        /// *   `exported` - the migration finished successfully.<br/>
        /// *   `failed` - the migration failed.<br/>
        /// Once the migration has been `exported` you can [download the migration archive](https://docs.github.com/rest/migrations/users#download-a-user-migration-archive).
        /// </summary>
        /// <param name="migrationId"></param>
        /// <param name="exclude"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Migration> MigrationsGetStatusForAuthenticatedUserAsync(
            int migrationId,
            global::System.Collections.Generic.IList<string>? exclude = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}