//HintName: G.Models.VoicePreviewsRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicePreviewsRequestModel
    {
        /// <summary>
        /// Description to use for the created voice.<br/>
        /// Example: A sassy squeaky mouse
        /// </summary>
        /// <example>A sassy squeaky mouse</example>
        [global::Newtonsoft.Json.JsonProperty("voice_description", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceDescription { get; set; } = default!;

        /// <summary>
        /// Text to generate, text length has to be between 100 and 1000.<br/>
        /// Example: Every act of kindness, no matter how small, carries value and can make a difference, as no gesture of goodwill is ever wasted.
        /// </summary>
        /// <example>Every act of kindness, no matter how small, carries value and can make a difference, as no gesture of goodwill is ever wasted.</example>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Whether to automatically generate a text suitable for the voice description.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_generate_text")]
        public bool? AutoGenerateText { get; set; }

        /// <summary>
        /// Controls the volume level of the generated voice. -1 is quietest, 1 is loudest, 0 corresponds to roughly -24 LUFS.<br/>
        /// Default Value: 0.5<br/>
        /// Example: 0.5
        /// </summary>
        /// <example>0.5</example>
        [global::Newtonsoft.Json.JsonProperty("loudness")]
        public double? Loudness { get; set; }

        /// <summary>
        /// Higher quality results in better voice output but less variety.<br/>
        /// Default Value: 0.9<br/>
        /// Example: 0.9
        /// </summary>
        /// <example>0.9</example>
        [global::Newtonsoft.Json.JsonProperty("quality")]
        public double? Quality { get; set; }

        /// <summary>
        /// Random number that controls the voice generation. Same seed with same inputs produces same voice.<br/>
        /// Example: 11
        /// </summary>
        /// <example>11</example>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Controls how closely the AI follows the prompt. Lower numbers give the AI more freedom to be creative, while higher numbers force it to stick more to the prompt. High numbers can cause voice to sound artificial or robotic. We recommend to use longer, more detailed prompts at lower Guidance Scale.<br/>
        /// Default Value: 5<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::Newtonsoft.Json.JsonProperty("guidance_scale")]
        public double? GuidanceScale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicePreviewsRequestModel" /> class.
        /// </summary>
        /// <param name="voiceDescription">
        /// Description to use for the created voice.<br/>
        /// Example: A sassy squeaky mouse
        /// </param>
        /// <param name="text">
        /// Text to generate, text length has to be between 100 and 1000.<br/>
        /// Example: Every act of kindness, no matter how small, carries value and can make a difference, as no gesture of goodwill is ever wasted.
        /// </param>
        /// <param name="autoGenerateText">
        /// Whether to automatically generate a text suitable for the voice description.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="loudness">
        /// Controls the volume level of the generated voice. -1 is quietest, 1 is loudest, 0 corresponds to roughly -24 LUFS.<br/>
        /// Default Value: 0.5<br/>
        /// Example: 0.5
        /// </param>
        /// <param name="quality">
        /// Higher quality results in better voice output but less variety.<br/>
        /// Default Value: 0.9<br/>
        /// Example: 0.9
        /// </param>
        /// <param name="seed">
        /// Random number that controls the voice generation. Same seed with same inputs produces same voice.<br/>
        /// Example: 11
        /// </param>
        /// <param name="guidanceScale">
        /// Controls how closely the AI follows the prompt. Lower numbers give the AI more freedom to be creative, while higher numbers force it to stick more to the prompt. High numbers can cause voice to sound artificial or robotic. We recommend to use longer, more detailed prompts at lower Guidance Scale.<br/>
        /// Default Value: 5<br/>
        /// Example: 5
        /// </param>
        public VoicePreviewsRequestModel(
            string voiceDescription,
            string? text,
            bool? autoGenerateText,
            double? loudness,
            double? quality,
            int? seed,
            double? guidanceScale)
        {
            this.VoiceDescription = voiceDescription ?? throw new global::System.ArgumentNullException(nameof(voiceDescription));
            this.Text = text;
            this.AutoGenerateText = autoGenerateText;
            this.Loudness = loudness;
            this.Quality = quality;
            this.Seed = seed;
            this.GuidanceScale = guidanceScale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicePreviewsRequestModel" /> class.
        /// </summary>
        public VoicePreviewsRequestModel()
        {
        }
    }
}