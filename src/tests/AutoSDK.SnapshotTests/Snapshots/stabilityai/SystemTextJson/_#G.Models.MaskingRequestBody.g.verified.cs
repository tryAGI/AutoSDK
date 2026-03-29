//HintName: G.Models.MaskingRequestBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonPolymorphic(
        TypeDiscriminatorPropertyName = "mask_source",
        IgnoreUnrecognizedTypeDiscriminators = true,
        UnknownDerivedTypeHandling = global::System.Text.Json.Serialization.JsonUnknownDerivedTypeHandling.FallBackToBaseType)]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.MaskingUsingInitImageAlphaRequestBody), typeDiscriminator: "INIT_IMAGE_ALPHA")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.MaskingUsingMaskImageRequestBody), typeDiscriminator: "MASK_IMAGE_BLACK")]
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof(global::G.MaskingUsingMaskImageRequestBody), typeDiscriminator: "MASK_IMAGE_WHITE")]
    public partial class MaskingRequestBody
    {
        /// <summary>
        /// Image used to initialize the diffusion process, in lieu of random noise.<br/>
        /// Example: &lt;image binary&gt;
        /// </summary>
        /// <example>&lt;image binary&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("init_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] InitImage { get; set; }

        /// <summary>
        /// Image used to initialize the diffusion process, in lieu of random noise.<br/>
        /// Example: &lt;image binary&gt;
        /// </summary>
        /// <example>&lt;image binary&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("init_imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InitImagename { get; set; }

        /// <summary>
        /// Optional grayscale mask that allows for influence over which pixels are eligible for diffusion and at what strength. Must be the same dimensions as the `init_image`. Use the `mask_source` option to specify whether the white or black pixels should be inpainted.<br/>
        /// Example: &lt;image binary&gt;
        /// </summary>
        /// <example>&lt;image binary&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_image")]
        public byte[]? MaskImage { get; set; }

        /// <summary>
        /// Optional grayscale mask that allows for influence over which pixels are eligible for diffusion and at what strength. Must be the same dimensions as the `init_image`. Use the `mask_source` option to specify whether the white or black pixels should be inpainted.<br/>
        /// Example: &lt;image binary&gt;
        /// </summary>
        /// <example>&lt;image binary&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_imagename")]
        public string? MaskImagename { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("text_prompts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TextPrompt> TextPrompts { get; set; }

        /// <summary>
        /// How strictly the diffusion process adheres to the prompt text (higher values keep your image closer to your prompt)<br/>
        /// Default Value: 7<br/>
        /// Example: 7
        /// </summary>
        /// <example>7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cfg_scale")]
        public double? CfgScale { get; set; }

        /// <summary>
        /// Default Value: NONE<br/>
        /// Example: FAST_BLUE
        /// </summary>
        /// <example>FAST_BLUE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clip_guidance_preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClipGuidancePresetJsonConverter))]
        public global::G.ClipGuidancePreset? ClipGuidancePreset { get; set; }

        /// <summary>
        /// Which sampler to use for the diffusion process. If this value is omitted we'll automatically select an appropriate sampler for you.<br/>
        /// Example: K_DPM_2_ANCESTRAL
        /// </summary>
        /// <example>K_DPM_2_ANCESTRAL</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampler")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SamplerJsonConverter))]
        public global::G.Sampler? Sampler { get; set; }

        /// <summary>
        /// Number of images to generate<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        public int? Samples { get; set; }

        /// <summary>
        /// Random noise seed (omit this option or use `0` for a random seed)<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public long? Seed { get; set; }

        /// <summary>
        /// Number of diffusion steps to run<br/>
        /// Default Value: 50<br/>
        /// Example: 75
        /// </summary>
        /// <example>75</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public int? Steps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MaskingRequestBody" /> class.
        /// </summary>
        /// <param name="initImage">
        /// Image used to initialize the diffusion process, in lieu of random noise.<br/>
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="initImagename">
        /// Image used to initialize the diffusion process, in lieu of random noise.<br/>
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
        /// <param name="maskImage">
        /// Optional grayscale mask that allows for influence over which pixels are eligible for diffusion and at what strength. Must be the same dimensions as the `init_image`. Use the `mask_source` option to specify whether the white or black pixels should be inpainted.<br/>
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="maskImagename">
        /// Optional grayscale mask that allows for influence over which pixels are eligible for diffusion and at what strength. Must be the same dimensions as the `init_image`. Use the `mask_source` option to specify whether the white or black pixels should be inpainted.<br/>
        /// Example: &lt;image binary&gt;
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MaskingRequestBody(
            byte[] initImage,
            string initImagename,
            global::System.Collections.Generic.IList<global::G.TextPrompt> textPrompts,
            byte[]? maskImage,
            string? maskImagename,
            double? cfgScale,
            global::G.ClipGuidancePreset? clipGuidancePreset,
            global::G.Sampler? sampler,
            int? samples,
            long? seed,
            int? steps)
        {
            this.InitImage = initImage ?? throw new global::System.ArgumentNullException(nameof(initImage));
            this.InitImagename = initImagename ?? throw new global::System.ArgumentNullException(nameof(initImagename));
            this.MaskImage = maskImage;
            this.MaskImagename = maskImagename;
            this.TextPrompts = textPrompts ?? throw new global::System.ArgumentNullException(nameof(textPrompts));
            this.CfgScale = cfgScale;
            this.ClipGuidancePreset = clipGuidancePreset;
            this.Sampler = sampler;
            this.Samples = samples;
            this.Seed = seed;
            this.Steps = steps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaskingRequestBody" /> class.
        /// </summary>
        public MaskingRequestBody()
        {
        }
    }
}