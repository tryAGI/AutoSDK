//HintName: G.ITextureClient.GetTextureGenerationById.g.cs
#nullable enable

namespace G
{
    public partial interface ITextureClient
    {
        /// <summary>
        /// Get Texture Generation by ID<br/>
        /// This endpoint gets the specific texture generation.
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
        global::System.Threading.Tasks.Task<global::G.GetTextureGenerationByIdResponse> GetTextureGenerationByIdAsync(
            string id,
            global::G.GetTextureGenerationByIdRequest request,
            int offset = 0,
            int limit = 10,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Texture Generation by ID<br/>
        /// This endpoint gets the specific texture generation.
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
        global::System.Threading.Tasks.Task<global::G.GetTextureGenerationByIdResponse> GetTextureGenerationByIdAsync(
            string id,
            int offset = 0,
            int limit = 10,
            string? requestId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}