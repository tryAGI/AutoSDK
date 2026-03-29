//HintName: G.Models.SmsSuccessEdgeVariant2TransitionCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SmsSuccessEdgeVariant2TransitionCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SmsSuccessEdgeVariant2TransitionConditionTypeJsonConverter))]
        public global::G.SmsSuccessEdgeVariant2TransitionConditionType Type { get; set; }

        /// <summary>
        /// Must be "sent successfully" for SMS success edge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SmsSuccessEdgeVariant2TransitionConditionPromptJsonConverter))]
        public global::G.SmsSuccessEdgeVariant2TransitionConditionPrompt Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsSuccessEdgeVariant2TransitionCondition" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="prompt">
        /// Must be "sent successfully" for SMS success edge
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SmsSuccessEdgeVariant2TransitionCondition(
            global::G.SmsSuccessEdgeVariant2TransitionConditionType type,
            global::G.SmsSuccessEdgeVariant2TransitionConditionPrompt prompt)
        {
            this.Type = type;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsSuccessEdgeVariant2TransitionCondition" /> class.
        /// </summary>
        public SmsSuccessEdgeVariant2TransitionCondition()
        {
        }
    }
}