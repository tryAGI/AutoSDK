//HintName: G.Models.SfxSourceContext.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Context for sound effect clips.
    /// </summary>
    public sealed partial class SfxSourceContext
    {
        /// <summary>
        /// Default Value: sfx
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        public string? SourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sound_generation_history_item_id")]
        public string? SoundGenerationHistoryItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_config")]
        public object? GenerationConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SfxSourceContext" /> class.
        /// </summary>
        /// <param name="sourceType">
        /// Default Value: sfx
        /// </param>
        /// <param name="soundGenerationHistoryItemId"></param>
        /// <param name="text"></param>
        /// <param name="generationConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SfxSourceContext(
            string? sourceType,
            string? soundGenerationHistoryItemId,
            string? text,
            object? generationConfig)
        {
            this.SourceType = sourceType;
            this.SoundGenerationHistoryItemId = soundGenerationHistoryItemId;
            this.Text = text;
            this.GenerationConfig = generationConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SfxSourceContext" /> class.
        /// </summary>
        public SfxSourceContext()
        {
        }
    }
}