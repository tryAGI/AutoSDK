//HintName: G.IDatasetsClient.CreateDatasetGroup.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create Dataset Group
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateDatasetGroupResponse> CreateDatasetGroupAsync(

            global::G.CreateDatasetGroupRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Dataset Group
        /// </summary>
        /// <param name="name">
        /// Name of the dataset group. Must be unique within the workspace.
        /// </param>
        /// <param name="workspaceId">
        /// Optional: ID of the workspace where the dataset group will be created. If not provided, uses the workspace associated with your API key.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateDatasetGroupResponse> CreateDatasetGroupAsync(
            string name,
            int? workspaceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}