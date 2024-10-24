//HintName: G.Ix3DModelAssetsClient.Get3DModelById.g.cs
#nullable enable

namespace G
{
    public partial interface Ix3DModelAssetsClient
    {
        /// <summary>
        /// Get 3D Model by ID<br/>
        /// This endpoint gets the specific 3D model
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Get3DModelByIdResponse> Get3DModelByIdAsync(
            string id,
            global::G.Get3DModelByIdRequest request,
            int? offset = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get 3D Model by ID<br/>
        /// This endpoint gets the specific 3D model
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="id"></param>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Get3DModelByIdResponse> Get3DModelByIdAsync(
            string id,
            int? offset = default,
            int? limit = default,
            string? requestId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}