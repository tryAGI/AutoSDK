//HintName: G.Models.ImageToImageUsingStepScheduleRequestBodyVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageToImageUsingStepScheduleRequestBodyVariant1
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
        /// Whether to use `image_strength` or `step_schedule_*` to control how much influence the `init_image` has on the result.<br/>
        /// Default Value: IMAGE_STRENGTH
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("init_image_mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.InitImageModeJsonConverter))]
        public global::G.InitImageMode? InitImageMode { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToImageUsingStepScheduleRequestBodyVariant1" /> class.
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
        /// <param name="initImageMode">
        /// Whether to use `image_strength` or `step_schedule_*` to control how much influence the `init_image` has on the result.<br/>
        /// Default Value: IMAGE_STRENGTH
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
        public ImageToImageUsingStepScheduleRequestBodyVariant1(
            global::System.Collections.Generic.IList<global::G.TextPrompt> textPrompts,
            byte[] initImage,
            string initImagename,
            global::G.InitImageMode? initImageMode,
            double? stepScheduleStart,
            double? stepScheduleEnd)
        {
            this.TextPrompts = textPrompts ?? throw new global::System.ArgumentNullException(nameof(textPrompts));
            this.InitImage = initImage ?? throw new global::System.ArgumentNullException(nameof(initImage));
            this.InitImagename = initImagename ?? throw new global::System.ArgumentNullException(nameof(initImagename));
            this.InitImageMode = initImageMode;
            this.StepScheduleStart = stepScheduleStart;
            this.StepScheduleEnd = stepScheduleEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToImageUsingStepScheduleRequestBodyVariant1" /> class.
        /// </summary>
        public ImageToImageUsingStepScheduleRequestBodyVariant1()
        {
        }
    }
}