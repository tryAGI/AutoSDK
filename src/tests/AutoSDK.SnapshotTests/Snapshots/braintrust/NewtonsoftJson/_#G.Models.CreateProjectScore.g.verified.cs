//HintName: G.Models.CreateProjectScore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A project score is a user-configured score, which can be manually-labeled through the UI
    /// </summary>
    public sealed partial class CreateProjectScore
    {
        /// <summary>
        /// Unique identifier for the project that the project score belongs under
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// Name of the project score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Textual description of the project score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The type of the configured score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ProjectScoreTypeJsonConverter))]
        public global::G.ProjectScoreType ScoreType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("categories")]
        public global::G.ProjectScoreCategories? Categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.ProjectScoreConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectScore" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the project score belongs under
        /// </param>
        /// <param name="name">
        /// Name of the project score
        /// </param>
        /// <param name="scoreType">
        /// The type of the configured score
        /// </param>
        /// <param name="description">
        /// Textual description of the project score
        /// </param>
        /// <param name="categories"></param>
        /// <param name="config"></param>
        public CreateProjectScore(
            global::System.Guid projectId,
            string name,
            global::G.ProjectScoreType scoreType,
            string? description,
            global::G.ProjectScoreCategories? categories,
            global::G.ProjectScoreConfig? config)
        {
            this.ProjectId = projectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ScoreType = scoreType;
            this.Categories = categories;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectScore" /> class.
        /// </summary>
        public CreateProjectScore()
        {
        }
    }
}