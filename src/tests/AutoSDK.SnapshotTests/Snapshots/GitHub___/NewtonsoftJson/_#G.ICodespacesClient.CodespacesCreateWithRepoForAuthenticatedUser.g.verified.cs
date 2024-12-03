//HintName: G.ICodespacesClient.CodespacesCreateWithRepoForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// Create a codespace in a repository<br/>
        /// Creates a codespace owned by the authenticated user in the specified repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Codespace> CodespacesCreateWithRepoForAuthenticatedUserAsync(
            string owner,
            string repo,
            global::G.CodespacesCreateWithRepoForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a codespace in a repository<br/>
        /// Creates a codespace owned by the authenticated user in the specified repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref">
        /// Git ref (typically a branch name) for this codespace
        /// </param>
        /// <param name="location">
        /// The requested location for a new codespace. Best efforts are made to respect this upon creation. Assigned by IP if not provided.
        /// </param>
        /// <param name="geo">
        /// The geographic area for this codespace. If not specified, the value is assigned by IP. This property replaces `location`, which is being deprecated.
        /// </param>
        /// <param name="clientIp">
        /// IP for location auto-detection when proxying a request
        /// </param>
        /// <param name="machine">
        /// Machine type to use for this codespace
        /// </param>
        /// <param name="devcontainerPath">
        /// Path to devcontainer.json config to use for this codespace
        /// </param>
        /// <param name="multiRepoPermissionsOptOut">
        /// Whether to authorize requested permissions from devcontainer.json
        /// </param>
        /// <param name="workingDirectory">
        /// Working directory for this codespace
        /// </param>
        /// <param name="idleTimeoutMinutes">
        /// Time in minutes before codespace stops from inactivity
        /// </param>
        /// <param name="displayName">
        /// Display name for this codespace
        /// </param>
        /// <param name="retentionPeriodMinutes">
        /// Duration in minutes after codespace has gone idle in which it will be deleted. Must be integer minutes between 0 and 43200 (30 days).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Codespace> CodespacesCreateWithRepoForAuthenticatedUserAsync(
            string owner,
            string repo,
            string? @ref = default,
            string? location = default,
            global::G.CodespacesCreateWithRepoForAuthenticatedUserRequestGeo? geo = default,
            string? clientIp = default,
            string? machine = default,
            string? devcontainerPath = default,
            bool? multiRepoPermissionsOptOut = default,
            string? workingDirectory = default,
            int? idleTimeoutMinutes = default,
            string? displayName = default,
            int? retentionPeriodMinutes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}