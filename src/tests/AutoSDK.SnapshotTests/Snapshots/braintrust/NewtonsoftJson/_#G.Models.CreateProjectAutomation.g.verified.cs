//HintName: G.Models.CreateProjectAutomation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectAutomation
    {
        /// <summary>
        /// Unique identifier for the project that the project automation belongs under
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

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
        public global::G.AnyOf<global::G.CreateProjectAutomationConfigVariant1, global::G.CreateProjectAutomationConfigVariant2, global::G.CreateProjectAutomationConfigVariant3, global::G.CreateProjectAutomationConfigVariant4, global::G.TopicAutomationConfig> Config { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectAutomation" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the project automation belongs under
        /// </param>
        /// <param name="name">
        /// Name of the project automation
        /// </param>
        /// <param name="config">
        /// The configuration for the automation rule
        /// </param>
        /// <param name="description">
        /// Textual description of the project automation
        /// </param>
        public CreateProjectAutomation(
            global::System.Guid projectId,
            string name,
            global::G.AnyOf<global::G.CreateProjectAutomationConfigVariant1, global::G.CreateProjectAutomationConfigVariant2, global::G.CreateProjectAutomationConfigVariant3, global::G.CreateProjectAutomationConfigVariant4, global::G.TopicAutomationConfig> config,
            string? description)
        {
            this.ProjectId = projectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectAutomation" /> class.
        /// </summary>
        public CreateProjectAutomation()
        {
        }
    }
}