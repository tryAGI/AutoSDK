//HintName: G.Models.CompactionSettingsInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for conversation compaction / summarization.<br/>
    /// Per-model settings (temperature,<br/>
    /// max tokens, etc.) are derived from the default configuration for that handle.
    /// </summary>
    public sealed partial class CompactionSettingsInput
    {
        /// <summary>
        /// Model handle to use for sliding_window/all summarization (format: provider/model-name). If None, uses lightweight provider-specific defaults.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Optional model settings used to override defaults for the summarizer model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_settings")]
        public global::G.ModelSettingsVariant12? ModelSettings { get; set; }

        /// <summary>
        /// The prompt to use for summarization. If None, uses mode-specific default.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Whether to include an acknowledgement post-prompt (helps prevent non-summary outputs).<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_acknowledgement")]
        public bool? PromptAcknowledgement { get; set; }

        /// <summary>
        /// The maximum length of the summary in characters. If none, no clipping is performed.<br/>
        /// Default Value: 50000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clip_chars")]
        public int? ClipChars { get; set; }

        /// <summary>
        /// The type of summarization technique use.<br/>
        /// Default Value: sliding_window
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public global::G.CompactionSettingsInputMode? Mode { get; set; }

        /// <summary>
        /// The percentage of the context window to keep post-summarization (only used in sliding window modes).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sliding_window_percentage")]
        public double? SlidingWindowPercentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionSettingsInput" /> class.
        /// </summary>
        /// <param name="model">
        /// Model handle to use for sliding_window/all summarization (format: provider/model-name). If None, uses lightweight provider-specific defaults.
        /// </param>
        /// <param name="modelSettings">
        /// Optional model settings used to override defaults for the summarizer model.
        /// </param>
        /// <param name="prompt">
        /// The prompt to use for summarization. If None, uses mode-specific default.
        /// </param>
        /// <param name="promptAcknowledgement">
        /// Whether to include an acknowledgement post-prompt (helps prevent non-summary outputs).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="clipChars">
        /// The maximum length of the summary in characters. If none, no clipping is performed.<br/>
        /// Default Value: 50000
        /// </param>
        /// <param name="mode">
        /// The type of summarization technique use.<br/>
        /// Default Value: sliding_window
        /// </param>
        /// <param name="slidingWindowPercentage">
        /// The percentage of the context window to keep post-summarization (only used in sliding window modes).
        /// </param>
        public CompactionSettingsInput(
            string? model,
            global::G.ModelSettingsVariant12? modelSettings,
            string? prompt,
            bool? promptAcknowledgement,
            int? clipChars,
            global::G.CompactionSettingsInputMode? mode,
            double? slidingWindowPercentage)
        {
            this.Model = model;
            this.ModelSettings = modelSettings;
            this.Prompt = prompt;
            this.PromptAcknowledgement = promptAcknowledgement;
            this.ClipChars = clipChars;
            this.Mode = mode;
            this.SlidingWindowPercentage = slidingWindowPercentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionSettingsInput" /> class.
        /// </summary>
        public CompactionSettingsInput()
        {
        }
    }
}