//HintName: recraft.IImageClient.GenerateImage.g.cs
#nullable enable

namespace recraft
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Generate image from prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::recraft.GenerateImageResponse> GenerateImageAsync(
            global::recraft.GenerateImageRequest request,
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
        global::System.Threading.Tasks.Task<global::recraft.GenerateImageResponse> GenerateImageAsync(
            string prompt,
            global::recraft.UserControls? controls = default,
            global::recraft.TransformModel? model = default,
            int? n = default,
            int? randomSeed = default,
            global::recraft.ResponseFormat? responseFormat = default,
            global::recraft.ImageSize? size = default,
            global::recraft.ImageStyle? style = default,
            global::System.Guid? styleId = default,
            global::recraft.ImageSubStyle? substyle = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}