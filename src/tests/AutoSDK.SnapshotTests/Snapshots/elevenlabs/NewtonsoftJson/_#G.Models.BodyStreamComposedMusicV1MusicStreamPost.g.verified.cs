//HintName: G.Models.BodyStreamComposedMusicV1MusicStreamPost.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyStreamComposedMusicV1MusicStreamPost
    {
        /// <summary>
        /// A simple text prompt to generate a song from. Cannot be used in conjunction with `composition_plan`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// A music prompt. Deprecated. Use `composition_plan` instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("music_prompt")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.MusicPrompt? MusicPrompt { get; set; }

        /// <summary>
        /// A detailed composition plan to guide music generation. Cannot be used in conjunction with `prompt`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("composition_plan")]
        public global::G.MusicPrompt? CompositionPlan { get; set; }

        /// <summary>
        /// The length of the song to generate in milliseconds. Used only in conjunction with `prompt`. Must be between 3000ms and 600000ms. Optional - if not provided, the model will choose a length based on the prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("music_length_ms")]
        public int? MusicLengthMs { get; set; }

        /// <summary>
        /// The model to use for the generation.<br/>
        /// Default Value: music_v1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id")]
        public global::G.BodyStreamComposedMusicV1MusicStreamPostModelId? ModelId { get; set; }

        /// <summary>
        /// Random seed to initialize the music generation process. Providing the same seed with the same parameters can help achieve more consistent results, but exact reproducibility is not guaranteed and outputs may change across system updates. Cannot be used in conjunction with prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// If true, guarantees that the generated song will be instrumental. If false, the song may or may not be instrumental depending on the `prompt`. Can only be used with `prompt`.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("force_instrumental")]
        public bool? ForceInstrumental { get; set; }

        /// <summary>
        /// The ID of the finetune to use for the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finetune_id")]
        public string? FinetuneId { get; set; }

        /// <summary>
        /// If true, proper names in the prompt will be phonetically spelled in the lyrics for better pronunciation by the music model. The original names will be restored in word timestamps.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_phonetic_names")]
        public bool? UsePhoneticNames { get; set; }

        /// <summary>
        /// Whether to store the generated song for inpainting. Only available to enterprise clients with access to the inpainting feature.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("store_for_inpainting")]
        public bool? StoreForInpainting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyStreamComposedMusicV1MusicStreamPost" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A simple text prompt to generate a song from. Cannot be used in conjunction with `composition_plan`.
        /// </param>
        /// <param name="compositionPlan">
        /// A detailed composition plan to guide music generation. Cannot be used in conjunction with `prompt`.
        /// </param>
        /// <param name="musicLengthMs">
        /// The length of the song to generate in milliseconds. Used only in conjunction with `prompt`. Must be between 3000ms and 600000ms. Optional - if not provided, the model will choose a length based on the prompt.
        /// </param>
        /// <param name="modelId">
        /// The model to use for the generation.<br/>
        /// Default Value: music_v1
        /// </param>
        /// <param name="seed">
        /// Random seed to initialize the music generation process. Providing the same seed with the same parameters can help achieve more consistent results, but exact reproducibility is not guaranteed and outputs may change across system updates. Cannot be used in conjunction with prompt.
        /// </param>
        /// <param name="forceInstrumental">
        /// If true, guarantees that the generated song will be instrumental. If false, the song may or may not be instrumental depending on the `prompt`. Can only be used with `prompt`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="finetuneId">
        /// The ID of the finetune to use for the generation
        /// </param>
        /// <param name="usePhoneticNames">
        /// If true, proper names in the prompt will be phonetically spelled in the lyrics for better pronunciation by the music model. The original names will be restored in word timestamps.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="storeForInpainting">
        /// Whether to store the generated song for inpainting. Only available to enterprise clients with access to the inpainting feature.<br/>
        /// Default Value: false
        /// </param>
        public BodyStreamComposedMusicV1MusicStreamPost(
            string? prompt,
            global::G.MusicPrompt? compositionPlan,
            int? musicLengthMs,
            global::G.BodyStreamComposedMusicV1MusicStreamPostModelId? modelId,
            int? seed,
            bool? forceInstrumental,
            string? finetuneId,
            bool? usePhoneticNames,
            bool? storeForInpainting)
        {
            this.Prompt = prompt;
            this.CompositionPlan = compositionPlan;
            this.MusicLengthMs = musicLengthMs;
            this.ModelId = modelId;
            this.Seed = seed;
            this.ForceInstrumental = forceInstrumental;
            this.FinetuneId = finetuneId;
            this.UsePhoneticNames = usePhoneticNames;
            this.StoreForInpainting = storeForInpainting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyStreamComposedMusicV1MusicStreamPost" /> class.
        /// </summary>
        public BodyStreamComposedMusicV1MusicStreamPost()
        {
        }
    }
}