//HintName: G.Models.ZAIThinking.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Thinking configuration for ZAI GLM-4.5+ models.
    /// </summary>
    public sealed partial class ZAIThinking
    {
        /// <summary>
        /// Whether thinking is enabled or disabled.<br/>
        /// Default Value: enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ZAIThinkingTypeJsonConverter))]
        public global::G.ZAIThinkingType? Type { get; set; }

        /// <summary>
        /// If False, preserved thinking is used (recommended for agents).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clear_thinking")]
        public bool? ClearThinking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ZAIThinking" /> class.
        /// </summary>
        /// <param name="type">
        /// Whether thinking is enabled or disabled.<br/>
        /// Default Value: enabled
        /// </param>
        /// <param name="clearThinking">
        /// If False, preserved thinking is used (recommended for agents).<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ZAIThinking(
            global::G.ZAIThinkingType? type,
            bool? clearThinking)
        {
            this.Type = type;
            this.ClearThinking = clearThinking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZAIThinking" /> class.
        /// </summary>
        public ZAIThinking()
        {
        }
    }
}