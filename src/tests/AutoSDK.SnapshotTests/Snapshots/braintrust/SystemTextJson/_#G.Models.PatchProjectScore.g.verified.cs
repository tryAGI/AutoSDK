//HintName: G.Models.PatchProjectScore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A project score is a user-configured score, which can be manually-labeled through the UI
    /// </summary>
    public sealed partial class PatchProjectScore
    {
        /// <summary>
        /// Name of the project score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Textual description of the project score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The type of the configured score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectScoreTypeJsonConverter))]
        public global::G.ProjectScoreType? ScoreType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectScoreCategoriesJsonConverter))]
        public global::G.ProjectScoreCategories? Categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.ProjectScoreConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectScore" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the project score
        /// </param>
        /// <param name="description">
        /// Textual description of the project score
        /// </param>
        /// <param name="scoreType">
        /// The type of the configured score
        /// </param>
        /// <param name="categories"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchProjectScore(
            string? name,
            string? description,
            global::G.ProjectScoreType? scoreType,
            global::G.ProjectScoreCategories? categories,
            global::G.ProjectScoreConfig? config)
        {
            this.Name = name;
            this.Description = description;
            this.ScoreType = scoreType;
            this.Categories = categories;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchProjectScore" /> class.
        /// </summary>
        public PatchProjectScore()
        {
        }
    }
}