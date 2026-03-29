//HintName: G.Models.ProjectScore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A project score is a user-configured score, which can be manually-labeled through the UI
    /// </summary>
    public sealed partial class ProjectScore
    {
        /// <summary>
        /// Unique identifier for the project score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the project that the project score belongs under
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid UserId { get; set; } = default!;

        /// <summary>
        /// Date of project score creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public global::System.DateTime? Created { get; set; }

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
        /// An optional LexoRank-based string that sets the sort position for the score in the UI
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position")]
        public string? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectScore" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the project score
        /// </param>
        /// <param name="projectId">
        /// Unique identifier for the project that the project score belongs under
        /// </param>
        /// <param name="userId"></param>
        /// <param name="name">
        /// Name of the project score
        /// </param>
        /// <param name="scoreType">
        /// The type of the configured score
        /// </param>
        /// <param name="created">
        /// Date of project score creation
        /// </param>
        /// <param name="description">
        /// Textual description of the project score
        /// </param>
        /// <param name="categories"></param>
        /// <param name="config"></param>
        /// <param name="position">
        /// An optional LexoRank-based string that sets the sort position for the score in the UI
        /// </param>
        public ProjectScore(
            global::System.Guid id,
            global::System.Guid projectId,
            global::System.Guid userId,
            string name,
            global::G.ProjectScoreType scoreType,
            global::System.DateTime? created,
            string? description,
            global::G.ProjectScoreCategories? categories,
            global::G.ProjectScoreConfig? config,
            string? position)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.UserId = userId;
            this.Created = created;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ScoreType = scoreType;
            this.Categories = categories;
            this.Config = config;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectScore" /> class.
        /// </summary>
        public ProjectScore()
        {
        }
    }
}