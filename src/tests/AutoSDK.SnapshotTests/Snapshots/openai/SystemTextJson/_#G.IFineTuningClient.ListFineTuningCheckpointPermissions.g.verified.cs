//HintName: G.IFineTuningClient.ListFineTuningCheckpointPermissions.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// **NOTE:** This endpoint requires an [admin API key](../admin-api-keys).<br/>
        /// Organization owners can use this endpoint to view all permissions for a fine-tuned model checkpoint.
        /// </summary>
        /// <param name="fineTunedModelCheckpoint">
        /// Example: ft-AF1WoRqd3aJAHsqc9NY7iL8F
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="order">
        /// Default Value: descending
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListFineTuningCheckpointPermissionResponse> ListFineTuningCheckpointPermissionsAsync(
            string fineTunedModelCheckpoint,
            string? projectId = default,
            string? after = default,
            int? limit = default,
            global::G.ListFineTuningCheckpointPermissionsOrder? order = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}