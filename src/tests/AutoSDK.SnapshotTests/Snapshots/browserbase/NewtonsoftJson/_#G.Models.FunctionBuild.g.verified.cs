//HintName: G.Models.FunctionBuild.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionBuild
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
        [global::Newtonsoft.Json.JsonProperty("request", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FunctionBuildRequest Request { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FunctionBuildStatus Status { get; set; } = default!;

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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("builtFunctions")]
        public global::System.Collections.Generic.IList<global::G.AllOf<global::G.Function, global::G.FunctionBuildBuiltFunction>>? BuiltFunctions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cause")]
        public global::G.FunctionBuildCause? Cause { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionBuild" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="startedAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="builtFunctions"></param>
        /// <param name="cause"></param>
        public FunctionBuild(
            global::System.Guid id,
            global::System.Guid projectId,
            global::G.FunctionBuildRequest request,
            global::G.FunctionBuildStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime startedAt,
            global::System.DateTime expiresAt,
            global::System.DateTime? endedAt,
            global::System.Collections.Generic.IList<global::G.AllOf<global::G.Function, global::G.FunctionBuildBuiltFunction>>? builtFunctions,
            global::G.FunctionBuildCause? cause)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.ExpiresAt = expiresAt;
            this.BuiltFunctions = builtFunctions;
            this.Cause = cause;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionBuild" /> class.
        /// </summary>
        public FunctionBuild()
        {
        }
    }
}