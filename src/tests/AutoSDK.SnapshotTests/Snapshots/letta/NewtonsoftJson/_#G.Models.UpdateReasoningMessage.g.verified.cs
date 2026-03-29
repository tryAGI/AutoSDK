//HintName: G.Models.UpdateReasoningMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateReasoningMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning", Required = global::Newtonsoft.Json.Required.Always)]
        public string Reasoning { get; set; } = default!;

        /// <summary>
        /// Default Value: reasoning_message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        public string? MessageType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateReasoningMessage" /> class.
        /// </summary>
        /// <param name="reasoning"></param>
        /// <param name="messageType">
        /// Default Value: reasoning_message
        /// </param>
        public UpdateReasoningMessage(
            string reasoning,
            string? messageType)
        {
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
            this.MessageType = messageType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateReasoningMessage" /> class.
        /// </summary>
        public UpdateReasoningMessage()
        {
        }
    }
}