//HintName: G.IGenerateClient.PostGenerateImage.g.cs
#nullable enable

namespace G
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Generates images synchronously based on a given prompt and optional parameters.<br/>
        /// A request to generate an image with Ideogram.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GenerateImageResponse> PostGenerateImageAsync(
            global::G.GenerateImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates images synchronously based on a given prompt and optional parameters.<br/>
        /// A request to generate an image with Ideogram.
        /// </summary>
        /// <param name="imageRequest"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GenerateImageResponse> PostGenerateImageAsync(
            global::G.ImageRequest imageRequest,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}