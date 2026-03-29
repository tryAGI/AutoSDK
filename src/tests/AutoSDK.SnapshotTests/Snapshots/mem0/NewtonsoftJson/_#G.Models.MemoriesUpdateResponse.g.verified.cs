//HintName: G.Models.MemoriesUpdateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesUpdateResponse
    {
        /// <summary>
        /// The unique identifier of the updated memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The updated text content of the memory
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The user ID associated with the memory, if any
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// The agent ID associated with the memory, if any
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// The app ID associated with the memory, if any
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// The run ID associated with the memory, if any
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// Hash of the memory content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hash")]
        public string? Hash { get; set; }

        /// <summary>
        /// Additional metadata associated with the memory
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Timestamp of when the memory was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of when the memory was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesUpdateResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the updated memory.
        /// </param>
        /// <param name="text">
        /// The updated text content of the memory
        /// </param>
        /// <param name="userId">
        /// The user ID associated with the memory, if any
        /// </param>
        /// <param name="agentId">
        /// The agent ID associated with the memory, if any
        /// </param>
        /// <param name="appId">
        /// The app ID associated with the memory, if any
        /// </param>
        /// <param name="runId">
        /// The run ID associated with the memory, if any
        /// </param>
        /// <param name="hash">
        /// Hash of the memory content
        /// </param>
        /// <param name="metadata">
        /// Additional metadata associated with the memory
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of when the memory was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of when the memory was last updated.
        /// </param>
        public MemoriesUpdateResponse(
            global::System.Guid? id,
            string? text,
            string? userId,
            string? agentId,
            string? appId,
            string? runId,
            string? hash,
            object? metadata,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Text = text;
            this.UserId = userId;
            this.AgentId = agentId;
            this.AppId = appId;
            this.RunId = runId;
            this.Hash = hash;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesUpdateResponse" /> class.
        /// </summary>
        public MemoriesUpdateResponse()
        {
        }
    }
}