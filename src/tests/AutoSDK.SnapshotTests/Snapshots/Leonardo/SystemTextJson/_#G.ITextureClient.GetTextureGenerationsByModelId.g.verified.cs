//HintName: G.ITextureClient.GetTextureGenerationsByModelId.g.cs
#nullable enable

namespace G
{
    public partial interface ITextureClient
    {
        /// <summary>
        /// Get texture generations by 3D Model ID<br/>
        /// This endpoint gets the specific texture generations by the 3d model id.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTextureGenerationsByModelIdResponse> GetTextureGenerationsByModelIdAsync(
            string modelId,
            global::G.GetTextureGenerationsByModelIdRequest request,
            int? offset = 0,
            int? limit = 10,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get texture generations by 3D Model ID<br/>
        /// This endpoint gets the specific texture generations by the 3d model id.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="requestLimit"></param>
        /// <param name="requestModelId"></param>
        /// <param name="requestOffset"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTextureGenerationsByModelIdResponse> GetTextureGenerationsByModelIdAsync(
            string modelId,
            int? offset = 0,
            int? limit = 10,
            int? requestLimit = default,
            string? requestModelId = default,
            int? requestOffset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}