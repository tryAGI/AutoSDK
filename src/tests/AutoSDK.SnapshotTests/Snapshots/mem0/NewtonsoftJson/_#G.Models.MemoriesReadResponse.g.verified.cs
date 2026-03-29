//HintName: G.Models.MemoriesReadResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesReadResponse
    {
        /// <summary>
        /// Unique identifier for the memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The content of the memory
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memory")]
        public string? Memory { get; set; }

        /// <summary>
        /// Identifier of the user associated with this memory
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
        /// Initializes a new instance of the <see cref="MemoriesReadResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the memory.
        /// </param>
        /// <param name="memory">
        /// The content of the memory
        /// </param>
        /// <param name="userId">
        /// Identifier of the user associated with this memory
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
        public MemoriesReadResponse(
            global::System.Guid? id,
            string? memory,
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
            this.Memory = memory;
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
        /// Initializes a new instance of the <see cref="MemoriesReadResponse" /> class.
        /// </summary>
        public MemoriesReadResponse()
        {
        }
    }
}