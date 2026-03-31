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
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// Name of the project automation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Textual description of the project automation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The configuration for the automation rule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.CreateProjectAutomationConfigVariant1, global::G.CreateProjectAutomationConfigVariant2, global::G.CreateProjectAutomationConfigVariant3, global::G.CreateProjectAutomationConfigVariant4, global::G.TopicAutomationConfig>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.CreateProjectAutomationConfigVariant1, global::G.CreateProjectAutomationConfigVariant2, global::G.CreateProjectAutomationConfigVariant3, global::G.CreateProjectAutomationConfigVariant4, global::G.TopicAutomationConfig> Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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