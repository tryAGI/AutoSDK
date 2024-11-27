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
        [global::Newtonsoft.Json.JsonProperty("userId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid UserId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastRevievedProjectMessageId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid? LastRevievedProjectMessageId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastRecievedGlobalMessageId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid? LastRecievedGlobalMessageId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChatMessagesRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="lastRevievedProjectMessageId"></param>
        /// <param name="lastRecievedGlobalMessageId"></param>
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