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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Array of conversation messages ordered chronologically
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetAgentConversationResponseMessage> Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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