//HintName: G.IMigrationsClient.MigrationsUpdateImport.g.cs
#nullable enable

namespace G
{
    public partial interface IMigrationsClient
    {
        /// <summary>
        /// Update an import<br/>
        /// An import can be updated with credentials or a project choice by passing in the appropriate parameters in this API<br/>
        /// request. If no parameters are provided, the import will be restarted.<br/>
        /// Some servers (e.g. TFS servers) can have several projects at a single URL. In those cases the import progress will<br/>
        /// have the status `detection_found_multiple` and the Import Progress response will include a `project_choices` array.<br/>
        /// You can select the project to import by providing one of the objects in the `project_choices` array in the update request.<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Import> MigrationsUpdateImportAsync(
            string owner,
            string repo,
            global::G.MigrationsUpdateImportRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an import<br/>
        /// An import can be updated with credentials or a project choice by passing in the appropriate parameters in this API<br/>
        /// request. If no parameters are provided, the import will be restarted.<br/>
        /// Some servers (e.g. TFS servers) can have several projects at a single URL. In those cases the import progress will<br/>
        /// have the status `detection_found_multiple` and the Import Progress response will include a `project_choices` array.<br/>
        /// You can select the project to import by providing one of the objects in the `project_choices` array in the update request.<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="vcsUsername">
        /// The username to provide to the originating repository.
        /// </param>
        /// <param name="vcsPassword">
        /// The password to provide to the originating repository.
        /// </param>
        /// <param name="vcs">
        /// The type of version control system you are migrating from.<br/>
        /// Example: "git"
        /// </param>
        /// <param name="tfvcProject">
        /// For a tfvc import, the name of the project that is being imported.<br/>
        /// Example: "project1"
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Import> MigrationsUpdateImportAsync(
            string owner,
            string repo,
            string? vcsUsername = default,
            string? vcsPassword = default,
            global::G.MigrationsUpdateImportRequestVcs? vcs = default,
            string? tfvcProject = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}