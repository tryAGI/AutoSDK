//HintName: G.IV1GenerationClient.TextToImage.g.cs
#nullable enable

namespace G
{
    public partial interface IV1GenerationClient
    {
        /// <summary>
        /// text-to-image<br/>
        /// Generate a new image from a text prompt
        /// </summary>
        /// <param name="engineId">
        /// Example: stable-diffusion-v1-5
        /// </param>
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
        /// OUTPUT_FILE=./out/v1_txt2img.png<br/>
        /// BASE_URL=${API_HOST:-https://api.stability.ai}<br/>
        /// URL="$BASE_URL/v1/generation/stable-diffusion-v1-5/text-to-image"<br/>
        /// curl -f -sS -X POST "$URL" \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -H 'Accept: image/png' \<br/>
        ///   -H "Authorization: Bearer $STABILITY_API_KEY" \<br/>
        ///   --data-raw '{<br/>
        ///     "text_prompts": [<br/>
        ///       {<br/>
        ///         "text": "A lighthouse on a cliff"<br/>
        ///       }<br/>
        ///     ],<br/>
        ///     "cfg_scale": 7,<br/>
        ///     "clip_guidance_preset": "FAST_BLUE",<br/>
        ///     "height": 512,<br/>
        ///     "width": 512,<br/>
        ///     "samples": 1,<br/>
        ///     "steps": 30<br/>
        ///   }' \<br/>
        ///   -o "$OUTPUT_FILE"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Image>> TextToImageAsync(
            string engineId,

            global::G.TextToImageRequestBody request,
            global::G.TextToImageAccept? accept = default,
            string? organization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// text-to-image<br/>
        /// Generate a new image from a text prompt
        /// </summary>
        /// <param name="engineId">
        /// Example: stable-diffusion-v1-5
        /// </param>
        /// <param name="accept">
        /// Default Value: application/json
        /// </param>
        /// <param name="organization"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Image>> TextToImageAsync(
            string engineId,
            global::G.TextToImageAccept? accept = default,
            string? organization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}