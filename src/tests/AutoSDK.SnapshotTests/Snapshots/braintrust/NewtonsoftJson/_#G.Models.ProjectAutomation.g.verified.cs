//HintName: G.Models.ProjectAutomation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectAutomation
    {
        /// <summary>
        /// Unique identifier for the project automation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the project that the project automation belongs under
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// Identifies the user who created the project automation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// Date of project automation creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Name of the project automation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Textual description of the project automation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The configuration for the automation rule
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.ProjectAutomationConfigVariant1, global::G.ProjectAutomationConfigVariant2, global::G.ProjectAutomationConfigVariant3, global::G.ProjectAutomationConfigVariant4, global::G.TopicAutomationConfig> Config { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAutomation" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the project automation
        /// </param>
        /// <param name="projectId">
        /// Unique identifier for the project that the project automation belongs under
        /// </param>
        /// <param name="name">
        /// Name of the project automation
        /// </param>
        /// <param name="config">
        /// The configuration for the automation rule
        /// </param>
        /// <param name="userId">
        /// Identifies the user who created the project automation
        /// </param>
        /// <param name="created">
        /// Date of project automation creation
        /// </param>
        /// <param name="description">
        /// Textual description of the project automation
        /// </param>
        public ProjectAutomation(
            global::System.Guid id,
            global::System.Guid projectId,
            string name,
            global::G.AnyOf<global::G.ProjectAutomationConfigVariant1, global::G.ProjectAutomationConfigVariant2, global::G.ProjectAutomationConfigVariant3, global::G.ProjectAutomationConfigVariant4, global::G.TopicAutomationConfig> config,
            global::System.Guid? userId,
            global::System.DateTime? created,
            string? description)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.UserId = userId;
            this.Created = created;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAutomation" /> class.
        /// </summary>
        public ProjectAutomation()
        {
        }
    }
}