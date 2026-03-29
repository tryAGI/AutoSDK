//HintName: G.IV1GenerationClient.UpscaleImage.g.cs
#nullable enable

namespace G
{
    public partial interface IV1GenerationClient
    {
        /// <summary>
        /// image-to-image/upscale<br/>
        /// Create a higher resolution version of an input image.<br/>
        /// This operation outputs an image with a maximum pixel count of **4,194,304**. This is equivalent to dimensions such as `2048x2048` and `4096x1024`.<br/>
        /// By default, the input image will be upscaled by a factor of 2.  For additional control over the output dimensions, a `width` or `height` parameter may be specified.
        /// </summary>
        /// <param name="engineId"></param>
        /// <param name="accept">
        /// Default Value: application/json
        /// </param>
        /// <param name="organization"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// if [ -z "$STABILITY_API_KEY" ]; then<br/>
        ///     echo "STABILITY_API_KEY environment variable is not set"<br/>
        ///     exit 1<br/>
        /// fi<br/>
        /// OUTPUT_FILE=./out/v1_upscaled_image.png<br/>
        /// BASE_URL=${API_HOST:-https://api.stability.ai}<br/>
        /// URL="$BASE_URL/v1/generation/esrgan-v1-x2plus/image-to-image/upscale"<br/>
        /// curl -f -sS -X POST "$URL" \<br/>
        ///   -H 'Content-Type: multipart/form-data' \<br/>
        ///   -H 'Accept: image/png' \<br/>
        ///   -H "Authorization: Bearer $STABILITY_API_KEY" \<br/>
        ///   -F 'image=@"../init_image.png"' \<br/>
        ///   -F 'width=1024' \<br/>
        ///   -o "$OUTPUT_FILE"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Image>> UpscaleImageAsync(
            string engineId,

            global::G.UpscaleImageRequestBody request,
            global::G.UpscaleImageAccept? accept = default,
            string? organization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// image-to-image/upscale<br/>
        /// Create a higher resolution version of an input image.<br/>
        /// This operation outputs an image with a maximum pixel count of **4,194,304**. This is equivalent to dimensions such as `2048x2048` and `4096x1024`.<br/>
        /// By default, the input image will be upscaled by a factor of 2.  For additional control over the output dimensions, a `width` or `height` parameter may be specified.
        /// </summary>
        /// <param name="engineId"></param>
        /// <param name="accept">
        /// Default Value: application/json
        /// </param>
        /// <param name="organization"></param>
        /// <param name="image">
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="imagename">
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="width">
        /// Desired width of the output image.  Only one of `width` or `height` may be specified.
        /// </param>
        /// <param name="height">
        /// Desired height of the output image.  Only one of `width` or `height` may be specified.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Image>> UpscaleImageAsync(
            string engineId,
            byte[] image,
            string imagename,
            global::G.UpscaleImageAccept? accept = default,
            string? organization = default,
            int? width = default,
            int? height = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}