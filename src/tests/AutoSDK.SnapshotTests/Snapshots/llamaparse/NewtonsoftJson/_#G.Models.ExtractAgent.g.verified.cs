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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The name of the extraction agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The ID of the project that the extraction agent belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// The schema of the data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public object DataSchema { get; set; } = default!;

        /// <summary>
        /// The configuration parameters for the extraction agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtractConfig Config { get; set; } = default!;

        /// <summary>
        /// Custom configuration type for the extraction agent. Currently supports 'default'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_configuration")]
        public string? CustomConfiguration { get; set; }

        /// <summary>
        /// The creation time of the extraction agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The last update time of the extraction agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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