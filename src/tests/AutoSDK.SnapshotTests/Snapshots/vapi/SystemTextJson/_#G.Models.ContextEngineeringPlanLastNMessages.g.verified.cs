//HintName: G.Models.ContextEngineeringPlanLastNMessages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextEngineeringPlanLastNMessages
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ContextEngineeringPlanLastNMessagesTypeJsonConverter))]
        public global::G.ContextEngineeringPlanLastNMessagesType Type { get; set; }

        /// <summary>
        /// This is the maximum number of messages to include in the context engineering plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMessages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxMessages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextEngineeringPlanLastNMessages" /> class.
        /// </summary>
        /// <param name="maxMessages">
        /// This is the maximum number of messages to include in the context engineering plan.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContextEngineeringPlanLastNMessages(
            double maxMessages,
            global::G.ContextEngineeringPlanLastNMessagesType type)
        {
            this.Type = type;
            this.MaxMessages = maxMessages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextEngineeringPlanLastNMessages" /> class.
        /// </summary>
        public ContextEngineeringPlanLastNMessages()
        {
        }
    }
}