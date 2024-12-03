//HintName: G.Ix3DModelAssetsClient.Get3DModelsByUserId.g.cs
#nullable enable

namespace G
{
    public partial interface Ix3DModelAssetsClient
    {
        /// <summary>
        /// Get 3D models by user ID<br/>
        /// This endpoint returns all 3D models by a specific user
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Get3DModelsByUserIdResponse> Get3DModelsByUserIdAsync(
            string userId,
            global::G.Get3DModelsByUserIdRequest request,
            int? offset = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get 3D models by user ID<br/>
        /// This endpoint returns all 3D models by a specific user
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="userId"></param>
        /// <param name="requestUserId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Get3DModelsByUserIdResponse> Get3DModelsByUserIdAsync(
            string userId,
            int? offset = default,
            int? limit = default,
            string? requestUserId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}