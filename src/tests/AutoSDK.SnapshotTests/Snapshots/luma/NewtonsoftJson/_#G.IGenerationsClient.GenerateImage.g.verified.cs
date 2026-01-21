//HintName: G.IGenerationsClient.GenerateImage.g.cs
#nullable enable

namespace G
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// Generate an image<br/>
        /// Generate an image with the provided prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Generation> GenerateImageAsync(
            global::G.ImageGenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate an image<br/>
        /// Generate an image with the provided prompt
        /// </summary>
        /// <param name="generationType">
        /// Default Value: image
        /// </param>
        /// <param name="model">
        /// The model used for the generation<br/>
        /// Default Value: photon-1
        /// </param>
        /// <param name="prompt">
        /// The prompt of the generation
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generation<br/>
        /// Default Value: 16:9<br/>
        /// Example: 16:9
        /// </param>
        /// <param name="callbackUrl">
        /// The callback URL for the generation
        /// </param>
        /// <param name="imageRef"></param>
        /// <param name="styleRef"></param>
        /// <param name="characterRef"></param>
        /// <param name="modifyImageRef">
        /// The modify image reference object
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Generation> GenerateImageAsync(
            global::G.ImageGenerationRequestGenerationType? generationType = default,
            global::G.ImageModel? model = default,
            string? prompt = default,
            global::G.AspectRatio? aspectRatio = default,
            string? callbackUrl = default,
            global::System.Collections.Generic.IList<global::G.ImageRef>? imageRef = default,
            global::System.Collections.Generic.IList<global::G.ImageRef>? styleRef = default,
            global::G.ImageGenerationRequestCharacterRef? characterRef = default,
            global::G.ModifyImageRef? modifyImageRef = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}