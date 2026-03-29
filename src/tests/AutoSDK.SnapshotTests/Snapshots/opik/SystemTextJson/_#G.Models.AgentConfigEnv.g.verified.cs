//HintName: G.Models.AgentConfigEnv.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentConfigEnv
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blueprint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid BlueprintId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended_at")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigEnv" /> class.
        /// </summary>
        /// <param name="envName"></param>
        /// <param name="blueprintId"></param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="projectId">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="endedAt">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConfigEnv(
            string envName,
            global::System.Guid blueprintId,
            global::System.Guid? id,
            global::System.Guid? projectId,
            string? createdBy,
            global::System.DateTime? createdAt,
            global::System.DateTime? endedAt)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.EnvName = envName ?? throw new global::System.ArgumentNullException(nameof(envName));
            this.BlueprintId = blueprintId;
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
            this.EndedAt = endedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigEnv" /> class.
        /// </summary>
        public AgentConfigEnv()
        {
        }
    }
}