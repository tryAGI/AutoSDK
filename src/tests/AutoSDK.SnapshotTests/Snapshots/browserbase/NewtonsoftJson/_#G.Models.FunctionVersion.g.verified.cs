//HintName: G.Models.FunctionVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionVersion
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
        [global::Newtonsoft.Json.JsonProperty("functionBuildId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid FunctionBuildId { get; set; } = default!;

        /// <summary>
        /// JSON object that can be stored in a JSONB column
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sessionCreateParams")]
        public object? SessionCreateParams { get; set; }

        /// <summary>
        /// JSON object that can be stored in a JSONB column
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userParamsSchema")]
        public object? UserParamsSchema { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionVersion" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="functionId"></param>
        /// <param name="functionBuildId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="sessionCreateParams">
        /// JSON object that can be stored in a JSONB column
        /// </param>
        /// <param name="userParamsSchema">
        /// JSON object that can be stored in a JSONB column
        /// </param>
        public FunctionVersion(
            global::System.Guid id,
            global::System.Guid projectId,
            global::System.Guid functionId,
            global::System.Guid functionBuildId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            object? sessionCreateParams,
            object? userParamsSchema)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.FunctionId = functionId;
            this.FunctionBuildId = functionBuildId;
            this.SessionCreateParams = sessionCreateParams;
            this.UserParamsSchema = userParamsSchema;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionVersion" /> class.
        /// </summary>
        public FunctionVersion()
        {
        }
    }
}