//HintName: G.IGenerationsClient.CreateGeneration.g.cs
#nullable enable

namespace G
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// Create a generation<br/>
        /// Initiate a new generation with the provided prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Generation> CreateGenerationAsync(
            global::G.GenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a generation<br/>
        /// Initiate a new generation with the provided prompt
        /// </summary>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generation<br/>
        /// Default Value: 16:9<br/>
        /// Example: 16:9
        /// </param>
        /// <param name="callbackUrl">
        /// The callback URL of the generation, a POST request with Generation object will be sent to the callback URL when the generation is dreaming, completed, or failed
        /// </param>
        /// <param name="generationType">
        /// Default Value: video
        /// </param>
        /// <param name="keyframes">
        /// The keyframes of the generation
        /// </param>
        /// <param name="loop">
        /// Whether to loop the video
        /// </param>
        /// <param name="prompt">
        /// The prompt of the generation
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Generation> CreateGenerationAsync(
            global::G.AspectRatio? aspectRatio = default,
            string? callbackUrl = default,
            global::G.GenerationRequestGenerationType? generationType = default,
            global::G.Keyframes? keyframes = default,
            bool? loop = default,
            string? prompt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}