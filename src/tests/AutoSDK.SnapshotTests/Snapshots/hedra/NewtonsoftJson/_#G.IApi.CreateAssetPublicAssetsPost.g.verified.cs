//HintName: G.IApi.CreateAssetPublicAssetsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create Asset
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateAssetResponse> CreateAssetPublicAssetsPostAsync(

            global::G.CreateAssetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Asset
        /// </summary>
        /// <param name="name">
        /// Name of the asset. Default to user-provided file name.
        /// </param>
        /// <param name="type">
        /// The type of the asset.
        /// </param>
        /// <param name="workspaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateAssetResponse> CreateAssetPublicAssetsPostAsync(
            string name,
            global::G.AssetType type,
            string? workspaceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}