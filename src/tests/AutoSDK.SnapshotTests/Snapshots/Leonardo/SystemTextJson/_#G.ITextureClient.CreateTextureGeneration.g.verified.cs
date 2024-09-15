//HintName: G.ITextureClient.CreateTextureGeneration.g.cs
#nullable enable

namespace G
{
    public partial interface ITextureClient
    {
        /// <summary>
        /// Create Texture Generation<br/>
        /// This endpoint will generate a texture generation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTextureGenerationResponse> CreateTextureGenerationAsync(
            global::G.CreateTextureGenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Texture Generation<br/>
        /// This endpoint will generate a texture generation.
        /// </summary>
        /// <param name="frontRotationOffset"></param>
        /// <param name="modelAssetId"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="preview"></param>
        /// <param name="previewDirection"></param>
        /// <param name="prompt"></param>
        /// <param name="sdVersion"></param>
        /// <param name="seed"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTextureGenerationResponse> CreateTextureGenerationAsync(
            int? frontRotationOffset = default,
            string? modelAssetId = default,
            string? negativePrompt = default,
            bool? preview = default,
            string? previewDirection = default,
            string? prompt = default,
            string? sdVersion = default,
            int? seed = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}