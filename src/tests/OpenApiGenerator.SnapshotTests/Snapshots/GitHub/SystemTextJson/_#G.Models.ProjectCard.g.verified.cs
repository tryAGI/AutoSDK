//HintName: G.Models.ProjectCard.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Project cards represent a scope of work.
    /// </summary>
    public sealed partial class ProjectCard
    {
        /// <summary>
        /// <br/>Example: https://api.github.com/projects/columns/cards/1478
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The project card's ID
        /// <br/>Example: 42
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// <br/>Example: MDExOlByb2plY3RDYXJkMTQ3OA==
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// <br/>Example: Add payload for delete Project column
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Note { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required NullableSimpleUser? Creator { get; set; }

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Whether or not the card is archived
        /// <br/>Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool Archived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_name")]
        public string? ColumnName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/projects/columns/367
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColumnUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/repos/api-playground/projects-test/issues/3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_url")]
        public string? ContentUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/projects/120
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}