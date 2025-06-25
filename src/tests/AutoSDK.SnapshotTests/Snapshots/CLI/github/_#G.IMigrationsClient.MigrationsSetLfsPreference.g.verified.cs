//HintName: G.IMigrationsClient.MigrationsSetLfsPreference.g.cs
#nullable enable

namespace G
{
    public partial interface IMigrationsClient
    {
        /// <summary>
        /// Update Git LFS preference<br/>
        /// You can import repositories from Subversion, Mercurial, and TFS that include files larger than 100MB. This ability<br/>
        /// is powered by [Git LFS](https://git-lfs.com).<br/>
        /// You can learn more about our LFS feature and working with large files [on our help<br/>
        /// site](https://docs.github.com/repositories/working-with-files/managing-large-files).<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Import> MigrationsSetLfsPreferenceAsync(
            string owner,
            string repo,
            global::G.MigrationsSetLfsPreferenceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Git LFS preference<br/>
        /// You can import repositories from Subversion, Mercurial, and TFS that include files larger than 100MB. This ability<br/>
        /// is powered by [Git LFS](https://git-lfs.com).<br/>
        /// You can learn more about our LFS feature and working with large files [on our help<br/>
        /// site](https://docs.github.com/repositories/working-with-files/managing-large-files).<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="useLfs">
        /// Whether to store large files during the import. `opt_in` means large files will be stored using Git LFS. `opt_out` means large files will be removed during the import.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Import> MigrationsSetLfsPreferenceAsync(
            string owner,
            string repo,
            global::G.MigrationsSetLfsPreferenceRequestUseLfs useLfs,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}