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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Unique identifier for the project that the project automation belongs under
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// Identifies the user who created the project automation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// Date of project automation creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.ProjectAutomationConfigVariant1, global::G.ProjectAutomationConfigVariant2, global::G.ProjectAutomationConfigVariant3, global::G.ProjectAutomationConfigVariant4, global::G.TopicAutomationConfig>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.ProjectAutomationConfigVariant1, global::G.ProjectAutomationConfigVariant2, global::G.ProjectAutomationConfigVariant3, global::G.ProjectAutomationConfigVariant4, global::G.TopicAutomationConfig> Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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