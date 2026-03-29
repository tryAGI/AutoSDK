//HintName: G.Models.AgentConfigCreateWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentConfigCreateWrite
    {
        /// <summary>
        /// Project ID. Either project_id or project_name must be provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Project name. Either project_id or project_name must be provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Agent config ID. Generated automatically if not provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blueprint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AgentBlueprintWrite Blueprint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigCreateWrite" /> class.
        /// </summary>
        /// <param name="blueprint"></param>
        /// <param name="projectId">
        /// Project ID. Either project_id or project_name must be provided
        /// </param>
        /// <param name="projectName">
        /// Project name. Either project_id or project_name must be provided
        /// </param>
        /// <param name="id">
        /// Agent config ID. Generated automatically if not provided
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentConfigCreateWrite(
            global::G.AgentBlueprintWrite blueprint,
            global::System.Guid? projectId,
            string? projectName,
            global::System.Guid? id)
        {
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.Id = id;
            this.Blueprint = blueprint ?? throw new global::System.ArgumentNullException(nameof(blueprint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentConfigCreateWrite" /> class.
        /// </summary>
        public AgentConfigCreateWrite()
        {
        }
    }
}