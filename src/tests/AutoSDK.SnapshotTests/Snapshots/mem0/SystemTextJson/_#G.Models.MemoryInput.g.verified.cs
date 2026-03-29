//HintName: G.Models.MemoryInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoryInput
    {
        /// <summary>
        /// An array of message objects representing the content of the memory. Each message object typically contains 'role' and 'content' fields, where 'role' indicates the sender either 'user' or 'assistant' and 'content' contains the actual message text. This structure allows for the representation of conversations or multi-part memories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string?>>? Messages { get; set; }

        /// <summary>
        /// The unique identifier of the agent associated with this memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// The unique identifier of the user associated with this memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// The unique identifier of the application associated with this memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// The unique identifier of the run associated with this memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// Additional metadata associated with the memory, which can be used to store any additional information or context about the memory. Best practice for incorporating additional information is through metadata (e.g. location, time, ids, etc.). During retrieval, you can either use these metadata alongside the query to fetch relevant memories or retrieve memories based on the query first and then refine the results using metadata during post-processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// String to include the specific preferences in the memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includes")]
        public string? Includes { get; set; }

        /// <summary>
        /// String to exclude the specific preferences in the memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludes")]
        public string? Excludes { get; set; }

        /// <summary>
        /// Whether to infer the memories or directly store the messages.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("infer")]
        public bool? Infer { get; set; }

        /// <summary>
        /// Controls the response format structure. `v1.0` (deprecated) returns a direct array of memory objects: `[{...}, {...}]`. `v1.1` (recommended) returns an object with a 'results' key containing the array: `{"results": [...]}`. The `v1.0` format will be removed in future versions.<br/>
        /// Default Value: v1.1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public string? OutputFormat { get; set; }

        /// <summary>
        /// A list of categories with category name and its description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_categories")]
        public object? CustomCategories { get; set; }

        /// <summary>
        /// Defines project-specific guidelines for handling and organizing memories. When set at the project level, they apply to all new memories in that project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_instructions")]
        public string? CustomInstructions { get; set; }

        /// <summary>
        /// Whether the memory is immutable.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("immutable")]
        public bool? Immutable { get; set; }

        /// <summary>
        /// Whether to add the memory completely asynchronously.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async_mode")]
        public bool? AsyncMode { get; set; }

        /// <summary>
        /// The timestamp of the memory. Format: Unix timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Timestamp { get; set; }

        /// <summary>
        /// The date and time when the memory will expire. Format: YYYY-MM-DD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_date")]
        public string? ExpirationDate { get; set; }

        /// <summary>
        /// The unique identifier of the organization associated with this memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// The unique identifier of the project associated with this memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The version of the memory to use. The default version is v1, which is deprecated. We recommend using v2 for new applications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryInput" /> class.
        /// </summary>
        /// <param name="messages">
        /// An array of message objects representing the content of the memory. Each message object typically contains 'role' and 'content' fields, where 'role' indicates the sender either 'user' or 'assistant' and 'content' contains the actual message text. This structure allows for the representation of conversations or multi-part memories.
        /// </param>
        /// <param name="agentId">
        /// The unique identifier of the agent associated with this memory.
        /// </param>
        /// <param name="userId">
        /// The unique identifier of the user associated with this memory.
        /// </param>
        /// <param name="appId">
        /// The unique identifier of the application associated with this memory.
        /// </param>
        /// <param name="runId">
        /// The unique identifier of the run associated with this memory.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata associated with the memory, which can be used to store any additional information or context about the memory. Best practice for incorporating additional information is through metadata (e.g. location, time, ids, etc.). During retrieval, you can either use these metadata alongside the query to fetch relevant memories or retrieve memories based on the query first and then refine the results using metadata during post-processing.
        /// </param>
        /// <param name="includes">
        /// String to include the specific preferences in the memory.
        /// </param>
        /// <param name="excludes">
        /// String to exclude the specific preferences in the memory.
        /// </param>
        /// <param name="infer">
        /// Whether to infer the memories or directly store the messages.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="outputFormat">
        /// Controls the response format structure. `v1.0` (deprecated) returns a direct array of memory objects: `[{...}, {...}]`. `v1.1` (recommended) returns an object with a 'results' key containing the array: `{"results": [...]}`. The `v1.0` format will be removed in future versions.<br/>
        /// Default Value: v1.1
        /// </param>
        /// <param name="customCategories">
        /// A list of categories with category name and its description.
        /// </param>
        /// <param name="customInstructions">
        /// Defines project-specific guidelines for handling and organizing memories. When set at the project level, they apply to all new memories in that project.
        /// </param>
        /// <param name="immutable">
        /// Whether the memory is immutable.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="asyncMode">
        /// Whether to add the memory completely asynchronously.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="timestamp">
        /// The timestamp of the memory. Format: Unix timestamp
        /// </param>
        /// <param name="expirationDate">
        /// The date and time when the memory will expire. Format: YYYY-MM-DD
        /// </param>
        /// <param name="orgId">
        /// The unique identifier of the organization associated with this memory.
        /// </param>
        /// <param name="projectId">
        /// The unique identifier of the project associated with this memory.
        /// </param>
        /// <param name="version">
        /// The version of the memory to use. The default version is v1, which is deprecated. We recommend using v2 for new applications.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoryInput(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string?>>? messages,
            string? agentId,
            string? userId,
            string? appId,
            string? runId,
            object? metadata,
            string? includes,
            string? excludes,
            bool? infer,
            string? outputFormat,
            object? customCategories,
            string? customInstructions,
            bool? immutable,
            bool? asyncMode,
            global::System.DateTimeOffset? timestamp,
            string? expirationDate,
            string? orgId,
            string? projectId,
            string? version)
        {
            this.Messages = messages;
            this.AgentId = agentId;
            this.UserId = userId;
            this.AppId = appId;
            this.RunId = runId;
            this.Metadata = metadata;
            this.Includes = includes;
            this.Excludes = excludes;
            this.Infer = infer;
            this.OutputFormat = outputFormat;
            this.CustomCategories = customCategories;
            this.CustomInstructions = customInstructions;
            this.Immutable = immutable;
            this.AsyncMode = asyncMode;
            this.Timestamp = timestamp;
            this.ExpirationDate = expirationDate;
            this.OrgId = orgId;
            this.ProjectId = projectId;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryInput" /> class.
        /// </summary>
        public MemoryInput()
        {
        }
    }
}