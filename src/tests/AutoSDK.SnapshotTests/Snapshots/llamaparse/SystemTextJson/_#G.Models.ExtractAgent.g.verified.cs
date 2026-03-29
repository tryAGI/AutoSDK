//HintName: G.Models.ExtractAgent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema and configuration for an extraction agent.
    /// </summary>
    public sealed partial class ExtractAgent
    {
        /// <summary>
        /// The id of the extraction agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The name of the extraction agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The ID of the project that the extraction agent belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// The schema of the data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object DataSchema { get; set; }

        /// <summary>
        /// The configuration parameters for the extraction agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtractConfig Config { get; set; }

        /// <summary>
        /// Custom configuration type for the extraction agent. Currently supports 'default'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_configuration")]
        public string? CustomConfiguration { get; set; }

        /// <summary>
        /// The creation time of the extraction agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The last update time of the extraction agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractAgent" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the extraction agent.
        /// </param>
        /// <param name="name">
        /// The name of the extraction agent.
        /// </param>
        /// <param name="projectId">
        /// The ID of the project that the extraction agent belongs to.
        /// </param>
        /// <param name="dataSchema">
        /// The schema of the data.
        /// </param>
        /// <param name="config">
        /// The configuration parameters for the extraction agent.
        /// </param>
        /// <param name="customConfiguration">
        /// Custom configuration type for the extraction agent. Currently supports 'default'.
        /// </param>
        /// <param name="createdAt">
        /// The creation time of the extraction agent.
        /// </param>
        /// <param name="updatedAt">
        /// The last update time of the extraction agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractAgent(
            global::System.Guid id,
            string name,
            global::System.Guid projectId,
            object dataSchema,
            global::G.ExtractConfig config,
            string? customConfiguration,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectId = projectId;
            this.DataSchema = dataSchema ?? throw new global::System.ArgumentNullException(nameof(dataSchema));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.CustomConfiguration = customConfiguration;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractAgent" /> class.
        /// </summary>
        public ExtractAgent()
        {
        }
    }
}