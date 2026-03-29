//HintName: G.Models.Invocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Invocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("functionId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid FunctionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("versionId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid VersionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sessionId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid SessionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region")]
        public string? Region { get; set; }

        /// <summary>
        /// JSON object that can be stored in a JSONB column
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("params")]
        public object? Params { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InvocationStatus Status { get; set; } = default!;

        /// <summary>
        /// JSON object that can be stored in a JSONB column
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results")]
        public object? Results { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endedAt")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expiresAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ExpiresAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Invocation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="functionId"></param>
        /// <param name="versionId"></param>
        /// <param name="sessionId"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="startedAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="region"></param>
        /// <param name="params">
        /// JSON object that can be stored in a JSONB column
        /// </param>
        /// <param name="results">
        /// JSON object that can be stored in a JSONB column
        /// </param>
        /// <param name="endedAt"></param>
        public Invocation(
            global::System.Guid id,
            global::System.Guid projectId,
            global::System.Guid functionId,
            global::System.Guid versionId,
            global::System.Guid sessionId,
            global::G.InvocationStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime startedAt,
            global::System.DateTime expiresAt,
            string? region,
            object? @params,
            object? results,
            global::System.DateTime? endedAt)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.FunctionId = functionId;
            this.VersionId = versionId;
            this.SessionId = sessionId;
            this.Region = region;
            this.Params = @params;
            this.Status = status;
            this.Results = results;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Invocation" /> class.
        /// </summary>
        public Invocation()
        {
        }
    }
}