//HintName: G.Models.ImageToImageRequestBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ImageToImageRequestBody
    {
        /// <summary>
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
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_prompts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TextPrompt> TextPrompts { get; set; } = default!;

        /// <summary>
        /// Image used to initialize the diffusion process, in lieu of random noise.<br/>
        /// Example: &lt;image binary&gt;
        /// </summary>
        /// <example>&lt;image binary&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("init_image", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] InitImage { get; set; } = default!;

        /// <summary>
        /// Image used to initialize the diffusion process, in lieu of random noise.<br/>
        /// Example: &lt;image binary&gt;
        /// </summary>
        /// <example>&lt;image binary&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("init_imagename", Required = global::Newtonsoft.Json.Required.Always)]
        public string InitImagename { get; set; } = default!;

        /// <summary>
        /// How much influence the `init_image` has on the diffusion process. Values close to `1` will yield images very similar to the `init_image` while values close to `0` will yield images wildly different than the `init_image`. The behavior of this is meant to mirror DreamStudio's "Image Strength" slider.  &lt;br/&gt; &lt;br/&gt; This parameter is just an alternate way to set `step_schedule_start`, which is done via the calculation `1 - image_strength`. For example, passing in an Image Strength of 35% (`0.35`) would result in a `step_schedule_start` of `0.65`.<br/>
        /// Default Value: 0.35F<br/>
        /// Example: 0.4F
        /// </summary>
        /// <example>0.4F</example>
        [global::Newtonsoft.Json.JsonProperty("image_strength")]
        public float? ImageStrength { get; set; }

        /// <summary>
        /// Skips a proportion of the start of the diffusion steps, allowing the init_image to influence the final generated image.  Lower values will result in more influence from the init_image, while higher values will result in more influence from the diffusion steps.  (e.g. a value of `0` would simply return you the init_image, where a value of `1` would return you a completely different image.)<br/>
        /// Default Value: 0.65F<br/>
        /// Example: 0.4F
        /// </summary>
        /// <example>0.4F</example>
        [global::Newtonsoft.Json.JsonProperty("step_schedule_start")]
        public double? StepScheduleStart { get; set; }

        /// <summary>
        /// Skips a proportion of the end of the diffusion steps, allowing the init_image to influence the final generated image.  Lower values will result in more influence from the init_image, while higher values will result in more influence from the diffusion steps.<br/>
        /// Example: 0.01F
        /// </summary>
        /// <example>0.01F</example>
        [global::Newtonsoft.Json.JsonProperty("step_schedule_end")]
        public double? StepScheduleEnd { get; set; }

        /// <summary>
        /// How strictly the diffusion process adheres to the prompt text (higher values keep your image closer to your prompt)<br/>
        /// Default Value: 7<br/>
        /// Example: 7
        /// </summary>
        /// <example>7</example>
        [global::Newtonsoft.Json.JsonProperty("cfg_scale")]
        public double? CfgScale { get; set; }

        /// <summary>
        /// Default Value: NONE<br/>
        /// Example: FAST_BLUE
        /// </summary>
        /// <example>FAST_BLUE</example>
        [global::Newtonsoft.Json.JsonProperty("clip_guidance_preset")]
        public global::G.ClipGuidancePreset? ClipGuidancePreset { get; set; }

        /// <summary>
        /// Which sampler to use for the diffusion process. If this value is omitted we'll automatically select an appropriate sampler for you.<br/>
        /// Example: K_DPM_2_ANCESTRAL
        /// </summary>
        /// <example>K_DPM_2_ANCESTRAL</example>
        [global::Newtonsoft.Json.JsonProperty("sampler")]
        public global::G.Sampler? Sampler { get; set; }

        /// <summary>
        /// Number of images to generate<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("samples")]
        public int? Samples { get; set; }

        /// <summary>
        /// Random noise seed (omit this option or use `0` for a random seed)<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public long? Seed { get; set; }

        /// <summary>
        /// Number of diffusion steps to run<br/>
        /// Default Value: 50<br/>
        /// Example: 75
        /// </summary>
        /// <example>75</example>
        [global::Newtonsoft.Json.JsonProperty("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToImageRequestBody" /> class.
        /// </summary>
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
        public ImageToImageRequestBody(
            global::System.Collections.Generic.IList<global::G.TextPrompt> textPrompts,
            byte[] initImage,
            string initImagename,
            float? imageStrength,
            double? stepScheduleStart,
            double? stepScheduleEnd,
            double? cfgScale,
            global::G.ClipGuidancePreset? clipGuidancePreset,
            global::G.Sampler? sampler,
            int? samples,
            long? seed,
            int? steps)
        {
            this.TextPrompts = textPrompts ?? throw new global::System.ArgumentNullException(nameof(textPrompts));
            this.InitImage = initImage ?? throw new global::System.ArgumentNullException(nameof(initImage));
            this.InitImagename = initImagename ?? throw new global::System.ArgumentNullException(nameof(initImagename));
            this.ImageStrength = imageStrength;
            this.StepScheduleStart = stepScheduleStart;
            this.StepScheduleEnd = stepScheduleEnd;
            this.CfgScale = cfgScale;
            this.ClipGuidancePreset = clipGuidancePreset;
            this.Sampler = sampler;
            this.Samples = samples;
            this.Seed = seed;
            this.Steps = steps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToImageRequestBody" /> class.
        /// </summary>
        public ImageToImageRequestBody()
        {
        }
    }
}