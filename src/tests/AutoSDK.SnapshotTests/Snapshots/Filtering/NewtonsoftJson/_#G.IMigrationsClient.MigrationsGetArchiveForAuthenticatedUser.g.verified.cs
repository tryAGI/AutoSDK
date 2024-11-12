//HintName: G.IMigrationsClient.MigrationsGetArchiveForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IMigrationsClient
    {
        /// <summary>
        /// Download a user migration archive<br/>
        /// Fetches the URL to download the migration archive as a `tar.gz` file. Depending on the resources your repository uses, the migration archive can contain JSON files with data for these objects:<br/>
        /// *   attachments<br/>
        /// *   bases<br/>
        /// *   commit\_comments<br/>
        /// *   issue\_comments<br/>
        /// *   issue\_events<br/>
        /// *   issues<br/>
        /// *   milestones<br/>
        /// *   organizations<br/>
        /// *   projects<br/>
        /// *   protected\_branches<br/>
        /// *   pull\_request\_reviews<br/>
        /// *   pull\_requests<br/>
        /// *   releases<br/>
        /// *   repositories<br/>
        /// *   review\_comments<br/>
        /// *   schema<br/>
        /// *   users<br/>
        /// The archive will also contain an `attachments` directory that includes all attachment files uploaded to GitHub.com and a `repositories` directory that contains the repository's Git data.
        /// </summary>
        /// <param name="migrationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task MigrationsGetArchiveForAuthenticatedUserAsync(
            int migrationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}