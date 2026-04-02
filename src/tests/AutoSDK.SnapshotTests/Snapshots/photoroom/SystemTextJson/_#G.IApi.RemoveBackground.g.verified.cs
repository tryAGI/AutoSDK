//HintName: G.IApi.RemoveBackground.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Remove Background (Basic plan)<br/>
        /// Remove background from an image
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RemoveBackgroundResponse> RemoveBackgroundAsync(

            global::G.RemoveBackgroundPostParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Background (Basic plan)<br/>
        /// Remove background from an image
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.RemoveBackgroundResponse>> RemoveBackgroundAsResponseAsync(

            global::G.RemoveBackgroundPostParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Background (Basic plan)<br/>
        /// Remove background from an image
        /// </summary>
        /// <param name="imageFile">
        /// The image file to render
        /// </param>
        /// <param name="imageFilename">
        /// The image file to render
        /// </param>
        /// <param name="format">
        /// The format of the resulting image<br/>
        /// Default Value: png
        /// </param>
        /// <param name="channels">
        /// The channels of the resulting image<br/>
        /// Default Value: rgba
        /// </param>
        /// <param name="bgColor">
        /// The background color of the resulting image. Can be a hex code (`#FF00FF`) or a HTML color (`red`, `green`, etc.)
        /// </param>
        /// <param name="size">
        /// Will resize the output to the specified size. Can be `preview` (0.25 Megapixels), `medium` (1.5 MP), `hd` (4 MP) or `full` (36 MP, can be slower for large images). Useful for mobile apps that need smaller images.<br/>
        /// Default Value: full
        /// </param>
        /// <param name="crop">
        /// If `true`, the image returned is cropped to the cutout border. Transparent pixels are removed from the border<br/>
        /// Default Value: false
        /// </param>
        /// <param name="despill">
        /// If `true`, automatically removes colored reflections that have been left on the main subject by a green background.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RemoveBackgroundResponse> RemoveBackgroundAsync(
            byte[] imageFile,
            string imageFilename,
            global::G.RemoveBackgroundPostParamsFormat? format = default,
            global::G.RemoveBackgroundPostParamsChannels? channels = default,
            string? bgColor = default,
            global::G.RemoveBackgroundPostParamsSize? size = default,
            global::G.RemoveBackgroundPostParamsCrop? crop = default,
            global::G.RemoveBackgroundPostParamsDespill? despill = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}