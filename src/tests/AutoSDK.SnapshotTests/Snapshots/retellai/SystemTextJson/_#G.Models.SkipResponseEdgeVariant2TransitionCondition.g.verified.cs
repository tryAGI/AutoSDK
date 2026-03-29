//HintName: G.Models.SkipResponseEdgeVariant2TransitionCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SkipResponseEdgeVariant2TransitionCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SkipResponseEdgeVariant2TransitionConditionTypeJsonConverter))]
        public global::G.SkipResponseEdgeVariant2TransitionConditionType Type { get; set; }

        /// <summary>
        /// Must be "Skip response" for skip response edge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SkipResponseEdgeVariant2TransitionConditionPromptJsonConverter))]
        public global::G.SkipResponseEdgeVariant2TransitionConditionPrompt Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkipResponseEdgeVariant2TransitionCondition" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="prompt">
        /// Must be "Skip response" for skip response edge
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkipResponseEdgeVariant2TransitionCondition(
            global::G.SkipResponseEdgeVariant2TransitionConditionType type,
            global::G.SkipResponseEdgeVariant2TransitionConditionPrompt prompt)
        {
            this.Type = type;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkipResponseEdgeVariant2TransitionCondition" /> class.
        /// </summary>
        public SkipResponseEdgeVariant2TransitionCondition()
        {
        }
    }
}