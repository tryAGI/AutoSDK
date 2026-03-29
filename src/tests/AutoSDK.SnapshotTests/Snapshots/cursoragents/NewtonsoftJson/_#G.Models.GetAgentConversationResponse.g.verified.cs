//HintName: G.Models.GetAgentConversationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentConversationResponse
    {
        /// <summary>
        /// Unique identifier for the cloud agent<br/>
        /// Example: bc_abc123
        /// </summary>
        /// <example>bc_abc123</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Array of conversation messages ordered chronologically
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetAgentConversationResponseMessage> Messages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentConversationResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the cloud agent<br/>
        /// Example: bc_abc123
        /// </param>
        /// <param name="messages">
        /// Array of conversation messages ordered chronologically
        /// </param>
        public GetAgentConversationResponse(
            string id,
            global::System.Collections.Generic.IList<global::G.GetAgentConversationResponseMessage> messages)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentConversationResponse" /> class.
        /// </summary>
        public GetAgentConversationResponse()
        {
        }
    }
}