//HintName: G.Models.GetChatMessagesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetChatMessagesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastRevievedProjectMessageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid? LastRevievedProjectMessageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastRecievedGlobalMessageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid? LastRecievedGlobalMessageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChatMessagesRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="lastRevievedProjectMessageId"></param>
        /// <param name="lastRecievedGlobalMessageId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetChatMessagesRequest(
            global::System.Guid userId,
            global::System.Guid projectId,
            global::System.Guid? lastRevievedProjectMessageId,
            global::System.Guid? lastRecievedGlobalMessageId)
        {
            this.UserId = userId;
            this.ProjectId = projectId;
            this.LastRevievedProjectMessageId = lastRevievedProjectMessageId;
            this.LastRecievedGlobalMessageId = lastRecievedGlobalMessageId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChatMessagesRequest" /> class.
        /// </summary>
        public GetChatMessagesRequest()
        {
        }
    }
}