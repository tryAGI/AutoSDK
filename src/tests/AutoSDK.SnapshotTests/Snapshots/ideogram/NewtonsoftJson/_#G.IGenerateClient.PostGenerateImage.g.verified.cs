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
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GenerateImageResponse> PostGenerateImageAsync(
            global::G.GenerateImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates images synchronously based on a given prompt and optional parameters.<br/>
        /// A request to generate an image with Ideogram.
        /// </summary>
        /// <param name="imageRequest">
        /// Example: {"aspect_ratio":"ASPECT_10_16","magic_prompt_option":"AUTO","model":"V_2","prompt":"A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there is an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset."}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GenerateImageResponse> PostGenerateImageAsync(
            global::G.ImageRequest imageRequest,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}