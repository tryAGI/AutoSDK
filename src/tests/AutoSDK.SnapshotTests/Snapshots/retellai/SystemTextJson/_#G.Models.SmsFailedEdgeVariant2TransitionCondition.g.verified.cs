//HintName: G.Models.SmsFailedEdgeVariant2TransitionCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SmsFailedEdgeVariant2TransitionCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SmsFailedEdgeVariant2TransitionConditionTypeJsonConverter))]
        public global::G.SmsFailedEdgeVariant2TransitionConditionType Type { get; set; }

        /// <summary>
        /// Must be "failed to send" for SMS failed edge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SmsFailedEdgeVariant2TransitionConditionPromptJsonConverter))]
        public global::G.SmsFailedEdgeVariant2TransitionConditionPrompt Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsFailedEdgeVariant2TransitionCondition" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="prompt">
        /// Must be "failed to send" for SMS failed edge
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SmsFailedEdgeVariant2TransitionCondition(
            global::G.SmsFailedEdgeVariant2TransitionConditionType type,
            global::G.SmsFailedEdgeVariant2TransitionConditionPrompt prompt)
        {
            this.Type = type;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsFailedEdgeVariant2TransitionCondition" /> class.
        /// </summary>
        public SmsFailedEdgeVariant2TransitionCondition()
        {
        }
    }
}