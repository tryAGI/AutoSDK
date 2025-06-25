//HintName: G.IFineTuningClient.DeleteFineTuningCheckpointPermission.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// **NOTE:** This endpoint requires an [admin API key](../admin-api-keys).<br/>
        /// Organization owners can use this endpoint to delete a permission for a fine-tuned model checkpoint.
        /// </summary>
        /// <param name="fineTunedModelCheckpoint">
        /// Example: ft:gpt-4o-mini-2024-07-18:org:weather:B7R9VjQd
        /// </param>
        /// <param name="permissionId">
        /// Example: cp_zc4Q7MP6XxulcVzj4MZdwsAB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteFineTuningCheckpointPermissionResponse> DeleteFineTuningCheckpointPermissionAsync(
            string fineTunedModelCheckpoint,
            string permissionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}