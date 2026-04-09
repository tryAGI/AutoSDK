//HintName: G.IV1GenerationClient.Masking.g.cs
#nullable enable

namespace G
{
    public partial interface IV1GenerationClient
    {
        /// <summary>
        /// image-to-image/masking<br/>
        /// Selectively modify portions of an image using a mask
        /// </summary>
        /// <param name="engineId"></param>
        /// <param name="accept">
        /// Default Value: application/json
        /// </param>
        /// <param name="organization"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// #!/bin/sh<br/>
        /// set -e<br/>
        /// if [ -z "$STABILITY_API_KEY" ]; then<br/>
        ///     echo "STABILITY_API_KEY environment variable is not set"<br/>
        ///     exit 1<br/>
        /// fi<br/>
        /// OUTPUT_FILE=./out/v1_img2img_masking.png<br/>
        /// BASE_URL=${API_HOST:-https://api.stability.ai}<br/>
        /// URL="$BASE_URL/v1/generation/stable-inpainting-512-v2-0/image-to-image/masking"<br/>
        /// curl -f -sS -X POST "$URL" \<br/>
        ///   -H 'Content-Type: multipart/form-data' \<br/>
        ///   -H 'Accept: image/png' \<br/>
        ///   -H "Authorization: Bearer $STABILITY_API_KEY" \<br/>
        ///   -F 'init_image=@"../init_image.png"' \<br/>
        ///   -F 'mask_image=@"../mask_image_white.png"' \<br/>
        ///   -F 'mask_source=MASK_IMAGE_WHITE' \<br/>
        ///   -F 'text_prompts[0][text]=A large spiral galaxy with a bright central bulge and a ring of stars around it' \<br/>
        ///   -F 'cfg_scale=7' \<br/>
        ///   -F 'clip_guidance_preset=FAST_BLUE' \<br/>
        ///   -F 'samples=1' \<br/>
        ///   -F 'steps=30' \<br/>
        ///   -o "$OUTPUT_FILE"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Image>> MaskingAsync(
            string engineId,

            global::G.MaskingRequestBody request,
            global::G.MaskingAccept? accept = default,
            string? organization = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// image-to-image/masking<br/>
        /// Selectively modify portions of an image using a mask
        /// </summary>
        /// <param name="engineId"></param>
        /// <param name="accept">
        /// Default Value: application/json
        /// </param>
        /// <param name="organization"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// #!/bin/sh<br/>
        /// set -e<br/>
        /// if [ -z "$STABILITY_API_KEY" ]; then<br/>
        ///     echo "STABILITY_API_KEY environment variable is not set"<br/>
        ///     exit 1<br/>
        /// fi<br/>
        /// OUTPUT_FILE=./out/v1_img2img_masking.png<br/>
        /// BASE_URL=${API_HOST:-https://api.stability.ai}<br/>
        /// URL="$BASE_URL/v1/generation/stable-inpainting-512-v2-0/image-to-image/masking"<br/>
        /// curl -f -sS -X POST "$URL" \<br/>
        ///   -H 'Content-Type: multipart/form-data' \<br/>
        ///   -H 'Accept: image/png' \<br/>
        ///   -H "Authorization: Bearer $STABILITY_API_KEY" \<br/>
        ///   -F 'init_image=@"../init_image.png"' \<br/>
        ///   -F 'mask_image=@"../mask_image_white.png"' \<br/>
        ///   -F 'mask_source=MASK_IMAGE_WHITE' \<br/>
        ///   -F 'text_prompts[0][text]=A large spiral galaxy with a bright central bulge and a ring of stars around it' \<br/>
        ///   -F 'cfg_scale=7' \<br/>
        ///   -F 'clip_guidance_preset=FAST_BLUE' \<br/>
        ///   -F 'samples=1' \<br/>
        ///   -F 'steps=30' \<br/>
        ///   -o "$OUTPUT_FILE"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::G.Image>>> MaskingAsResponseAsync(
            string engineId,

            global::G.MaskingRequestBody request,
            global::G.MaskingAccept? accept = default,
            string? organization = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// image-to-image/masking<br/>
        /// Selectively modify portions of an image using a mask
        /// </summary>
        /// <param name="engineId"></param>
        /// <param name="accept">
        /// Default Value: application/json
        /// </param>
        /// <param name="organization"></param>
        /// <param name="initImage">
        /// Image used to initialize the diffusion process, in lieu of random noise.<br/>
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="initImagename">
        /// Image used to initialize the diffusion process, in lieu of random noise.<br/>
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="maskImage">
        /// Optional grayscale mask that allows for influence over which pixels are eligible for diffusion and at what strength. Must be the same dimensions as the `init_image`. Use the `mask_source` option to specify whether the white or black pixels should be inpainted.<br/>
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="maskImagename">
        /// Optional grayscale mask that allows for influence over which pixels are eligible for diffusion and at what strength. Must be the same dimensions as the `init_image`. Use the `mask_source` option to specify whether the white or black pixels should be inpainted.<br/>
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="textPrompts">
        /// An array of text prompts to use for generation.<br/>
        /// Due to how arrays are represented in `multipart/form-data` requests, prompts must adhear to the format `text_prompts[index][text|weight]`,<br/>
        /// where `index` is some integer used to tie the text and weight together.  While `index` does not have to be sequential, duplicate entries <br/>
        /// will override previous entries, so it is recommended to use sequential indices.<br/>
        /// Given a text prompt with the text `A lighthouse on a cliff` and a weight of `0.5`, it would be represented as:<br/>
        /// ```<br/>
        /// text_prompts[0][text]: "A lighthouse on a cliff"<br/>
        /// text_prompts[0][weight]: 0.5<br/>
        /// ```<br/>
        /// To add another prompt to that request simply provide the values under a new `index`:<br/>
        /// ```<br/>
        /// text_prompts[0][text]: "A lighthouse on a cliff"<br/>
        /// text_prompts[0][weight]: 0.5<br/>
        /// text_prompts[1][text]: "land, ground, dirt, grass"<br/>
        /// text_prompts[1][weight]: -0.9<br/>
        /// ```
        /// </param>
        /// <param name="cfgScale">
        /// How strictly the diffusion process adheres to the prompt text (higher values keep your image closer to your prompt)<br/>
        /// Default Value: 7<br/>
        /// Example: 7
        /// </param>
        /// <param name="clipGuidancePreset">
        /// Default Value: NONE<br/>
        /// Example: FAST_BLUE
        /// </param>
        /// <param name="sampler">
        /// Which sampler to use for the diffusion process. If this value is omitted we'll automatically select an appropriate sampler for you.<br/>
        /// Example: K_DPM_2_ANCESTRAL
        /// </param>
        /// <param name="samples">
        /// Number of images to generate<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="seed">
        /// Random noise seed (omit this option or use `0` for a random seed)<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="steps">
        /// Number of diffusion steps to run<br/>
        /// Default Value: 50<br/>
        /// Example: 75
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Image>> MaskingAsync(
            string engineId,
            byte[] initImage,
            string initImagename,
            global::System.Collections.Generic.IList<global::G.TextPrompt> textPrompts,
            global::G.MaskingAccept? accept = default,
            string? organization = default,
            byte[]? maskImage = default,
            string? maskImagename = default,
            double? cfgScale = default,
            global::G.ClipGuidancePreset? clipGuidancePreset = default,
            global::G.Sampler? sampler = default,
            int? samples = default,
            long? seed = default,
            int? steps = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}