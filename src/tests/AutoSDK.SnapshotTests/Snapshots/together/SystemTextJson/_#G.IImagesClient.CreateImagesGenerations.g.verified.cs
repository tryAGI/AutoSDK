//HintName: G.IImagesClient.CreateImagesGenerations.g.cs
#nullable enable

namespace G
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Create image<br/>
        /// Use an image model to generate an image for a given prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ImageResponse> CreateImagesGenerationsAsync(
            global::G.Request request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create image<br/>
        /// Use an image model to generate an image for a given prompt.
        /// </summary>
        /// <param name="prompt">
        /// A description of the desired images. Maximum length varies by model.<br/>
        /// Default Value: cat floating in space, cinematic<br/>
        /// Example: cat floating in space, cinematic
        /// </param>
        /// <param name="model">
        /// The model to use for image generation.<br/>
        /// Default Value: stabilityai/stable-diffusion-xl-base-1.0<br/>
        /// Example: stabilityai/stable-diffusion-xl-base-1.0
        /// </param>
        /// <param name="steps">
        /// Number of generation steps.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="seed">
        /// Seed used for generation. Can be used to reproduce image generations.
        /// </param>
        /// <param name="n">
        /// Number of image results to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="height">
        /// Height of the image to generate in number of pixels.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="width">
        /// Width of the image to generate in number of pixels.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="negativePrompt">
        /// The prompt or prompts not to guide the image generation.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ImageResponse> CreateImagesGenerationsAsync(
            string prompt,
            string model,
            int? steps = default,
            int? seed = default,
            int? n = default,
            int? height = default,
            int? width = default,
            string? negativePrompt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}