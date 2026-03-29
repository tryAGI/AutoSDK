//HintName: G.IV1GenerationClient.ImageToImage.g.cs
#nullable enable

namespace G
{
    public partial interface IV1GenerationClient
    {
        /// <summary>
        /// image-to-image<br/>
        /// Modify an image based on a text prompt
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
        /// OUTPUT_FILE=./out/v1_img2img.png<br/>
        /// BASE_URL=${API_HOST:-https://api.stability.ai}<br/>
        /// URL="$BASE_URL/v1/generation/stable-diffusion-v1-5/image-to-image"<br/>
        /// curl -f -sS -X POST "$URL" \<br/>
        ///   -H 'Content-Type: multipart/form-data' \<br/>
        ///   -H 'Accept: image/png' \<br/>
        ///   -H "Authorization: Bearer $STABILITY_API_KEY" \<br/>
        ///   -F 'init_image=@"../init_image.png"' \<br/>
        ///   -F 'init_image_mode=IMAGE_STRENGTH' \<br/>
        ///   -F 'image_strength=0.35' \<br/>
        ///   -F 'text_prompts[0][text]=A galactic dog in space' \<br/>
        ///   -F 'cfg_scale=7' \<br/>
        ///   -F 'clip_guidance_preset=FAST_BLUE' \<br/>
        ///   -F 'samples=1' \<br/>
        ///   -F 'steps=30' \<br/>
        ///   -o "$OUTPUT_FILE"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Image>> ImageToImageAsync(
            string engineId,

            global::G.ImageToImageRequestBody request,
            global::G.ImageToImageAccept? accept = default,
            string? organization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// image-to-image<br/>
        /// Modify an image based on a text prompt
        /// </summary>
        /// <param name="engineId">
        /// Example: stable-diffusion-v1-5
        /// </param>
        /// <param name="accept">
        /// Default Value: application/json
        /// </param>
        /// <param name="organization"></param>
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
        /// <param name="initImage">
        /// Image used to initialize the diffusion process, in lieu of random noise.<br/>
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="initImagename">
        /// Image used to initialize the diffusion process, in lieu of random noise.<br/>
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="imageStrength">
        /// How much influence the `init_image` has on the diffusion process. Values close to `1` will yield images very similar to the `init_image` while values close to `0` will yield images wildly different than the `init_image`. The behavior of this is meant to mirror DreamStudio's "Image Strength" slider.  &lt;br/&gt; &lt;br/&gt; This parameter is just an alternate way to set `step_schedule_start`, which is done via the calculation `1 - image_strength`. For example, passing in an Image Strength of 35% (`0.35`) would result in a `step_schedule_start` of `0.65`.<br/>
        /// Default Value: 0.35F<br/>
        /// Example: 0.4F
        /// </param>
        /// <param name="stepScheduleStart">
        /// Skips a proportion of the start of the diffusion steps, allowing the init_image to influence the final generated image.  Lower values will result in more influence from the init_image, while higher values will result in more influence from the diffusion steps.  (e.g. a value of `0` would simply return you the init_image, where a value of `1` would return you a completely different image.)<br/>
        /// Default Value: 0.65F<br/>
        /// Example: 0.4F
        /// </param>
        /// <param name="stepScheduleEnd">
        /// Skips a proportion of the end of the diffusion steps, allowing the init_image to influence the final generated image.  Lower values will result in more influence from the init_image, while higher values will result in more influence from the diffusion steps.<br/>
        /// Example: 0.01F
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Image>> ImageToImageAsync(
            string engineId,
            global::System.Collections.Generic.IList<global::G.TextPrompt> textPrompts,
            byte[] initImage,
            string initImagename,
            global::G.ImageToImageAccept? accept = default,
            string? organization = default,
            float? imageStrength = default,
            double? stepScheduleStart = default,
            double? stepScheduleEnd = default,
            double? cfgScale = default,
            global::G.ClipGuidancePreset? clipGuidancePreset = default,
            global::G.Sampler? sampler = default,
            int? samples = default,
            long? seed = default,
            int? steps = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}