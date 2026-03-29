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
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Project name. Either project_id or project_name must be provided
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Agent config ID. Generated automatically if not provided
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blueprint", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AgentBlueprintWrite Blueprint { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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