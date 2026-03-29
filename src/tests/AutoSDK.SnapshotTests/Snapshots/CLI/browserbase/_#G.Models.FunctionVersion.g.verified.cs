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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid FunctionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionBuildId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid FunctionBuildId { get; set; }

        /// <summary>
        /// JSON object that can be stored in a JSONB column
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionCreateParams")]
        public object? SessionCreateParams { get; set; }

        /// <summary>
        /// JSON object that can be stored in a JSONB column
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userParamsSchema")]
        public object? UserParamsSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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