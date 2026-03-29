//HintName: G.Models.GenerationRequestOptionalParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents the optional parameters that can be passed to any generation request.
    /// </summary>
    public sealed partial class GenerationRequestOptionalParams
    {
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
        /// Initializes a new instance of the <see cref="GenerationRequestOptionalParams" /> class.
        /// </summary>
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
        public GenerationRequestOptionalParams(
            double? cfgScale,
            global::G.ClipGuidancePreset? clipGuidancePreset,
            global::G.Sampler? sampler,
            int? samples,
            long? seed,
            int? steps)
        {
            this.CfgScale = cfgScale;
            this.ClipGuidancePreset = clipGuidancePreset;
            this.Sampler = sampler;
            this.Samples = samples;
            this.Seed = seed;
            this.Steps = steps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequestOptionalParams" /> class.
        /// </summary>
        public GenerationRequestOptionalParams()
        {
        }
    }
}