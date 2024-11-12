//HintName: G.IImageClient.GenerateImage.g.cs
#nullable enable

namespace G
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Generate image from prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GenerateImageResponse> GenerateImageAsync(
            global::G.GenerateImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate image from prompt
        /// </summary>
        /// <param name="controls"></param>
        /// <param name="model"></param>
        /// <param name="n"></param>
        /// <param name="prompt"></param>
        /// <param name="randomSeed"></param>
        /// <param name="responseFormat"></param>
        /// <param name="size"></param>
        /// <param name="style"></param>
        /// <param name="styleId"></param>
        /// <param name="substyle"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GenerateImageResponse> GenerateImageAsync(
            string prompt,
            global::G.UserControls? controls = default,
            global::G.TransformModel? model = default,
            int? n = default,
            int? randomSeed = default,
            global::G.ResponseFormat? responseFormat = default,
            global::G.ImageSize? size = default,
            global::G.ImageStyle? style = default,
            global::System.Guid? styleId = default,
            global::G.ImageSubStyle? substyle = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}