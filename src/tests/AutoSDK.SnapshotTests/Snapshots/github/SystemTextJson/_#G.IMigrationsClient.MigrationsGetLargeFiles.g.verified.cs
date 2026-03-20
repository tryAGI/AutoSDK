//HintName: G.IMigrationsClient.MigrationsGetLargeFiles.g.cs
#nullable enable

namespace G
{
    public partial interface IMigrationsClient
    {
        /// <summary>
        /// Get large files<br/>
        /// List files larger than 100MB found during the import<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PorterLargeFile>> MigrationsGetLargeFilesAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}