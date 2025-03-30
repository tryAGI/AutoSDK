//HintName: G.IStudioClient.GetStudioProjectsByProjectIdSnapshotsByProjectSnapshotId.g.cs
#nullable enable

namespace G
{
    public partial interface IStudioClient
    {
        /// <summary>
        /// Get Project Snapshot<br/>
        /// Returns the project snapshot.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="projectSnapshotId">
        /// The ID of the Studio project snapshot.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectSnapshotExtendedResponseModel> GetStudioProjectsByProjectIdSnapshotsByProjectSnapshotIdAsync(
            string projectId,
            string projectSnapshotId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}