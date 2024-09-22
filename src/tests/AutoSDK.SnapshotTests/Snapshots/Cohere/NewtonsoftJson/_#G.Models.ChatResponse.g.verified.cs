//HintName: G.Models.ChatResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatResponse
    {
        /// <summary>
        /// Unique identifier for the generated reply. Useful for submitting feedback.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The reason a chat request has finished.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatFinishReason FinishReason { get; set; } = default!;

        /// <summary>
        /// A message from the assistant role can contain text and tool call information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public global::G.AssistantMessageResponse? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.Usage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}