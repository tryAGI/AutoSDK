//HintName: G.IMigrationsClient.MigrationsStartImport.g.cs
#nullable enable

namespace G
{
    public partial interface IMigrationsClient
    {
        /// <summary>
        /// Start an import<br/>
        /// Start a source import to a GitHub repository using GitHub Importer.<br/>
        /// Importing into a GitHub repository with GitHub Actions enabled is not supported and will<br/>
        /// return a status `422 Unprocessable Entity` response.<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Import> MigrationsStartImportAsync(
            string owner,
            string repo,
            global::G.MigrationsStartImportRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Start an import<br/>
        /// Start a source import to a GitHub repository using GitHub Importer.<br/>
        /// Importing into a GitHub repository with GitHub Actions enabled is not supported and will<br/>
        /// return a status `422 Unprocessable Entity` response.<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="vcsUrl">
        /// The URL of the originating repository.
        /// </param>
        /// <param name="vcs">
        /// The originating VCS type. Without this parameter, the import job will take additional time to detect the VCS type before beginning the import. This detection step will be reflected in the response.
        /// </param>
        /// <param name="vcsUsername">
        /// If authentication is required, the username to provide to `vcs_url`.
        /// </param>
        /// <param name="vcsPassword">
        /// If authentication is required, the password to provide to `vcs_url`.
        /// </param>
        /// <param name="tfvcProject">
        /// For a tfvc import, the name of the project that is being imported.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Import> MigrationsStartImportAsync(
            string owner,
            string repo,
            string vcsUrl,
            global::G.MigrationsStartImportRequestVcs? vcs = default,
            string? vcsUsername = default,
            string? vcsPassword = default,
            string? tfvcProject = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}