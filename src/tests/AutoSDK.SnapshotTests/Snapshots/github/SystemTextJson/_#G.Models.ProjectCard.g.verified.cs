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
        /// Example: https://api.github.com/projects/columns/cards/1478
        /// </summary>
        /// <example>https://api.github.com/projects/columns/cards/1478</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The project card's ID<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// Example: MDExOlByb2plY3RDYXJkMTQ3OA==
        /// </summary>
        /// <example>MDExOlByb2plY3RDYXJkMTQ3OA==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Example: Add payload for delete Project column
        /// </summary>
        /// <example>Add payload for delete Project column</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Note { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? Creator { get; set; }

        /// <summary>
        /// Example: 2016-09-05T14:21:06Z
        /// </summary>
        /// <example>2016-09-05T14:21:06Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Example: 2016-09-05T14:20:22Z
        /// </summary>
        /// <example>2016-09-05T14:20:22Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Whether or not the card is archived<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

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
        /// Example: https://api.github.com/projects/columns/367
        /// </summary>
        /// <example>https://api.github.com/projects/columns/367</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColumnUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/repos/api-playground/projects-test/issues/3
        /// </summary>
        /// <example>https://api.github.com/repos/api-playground/projects-test/issues/3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_url")]
        public string? ContentUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/projects/120
        /// </summary>
        /// <example>https://api.github.com/projects/120</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCard" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/projects/columns/cards/1478
        /// </param>
        /// <param name="id">
        /// The project card's ID<br/>
        /// Example: 42
        /// </param>
        /// <param name="nodeId">
        /// Example: MDExOlByb2plY3RDYXJkMTQ3OA==
        /// </param>
        /// <param name="note">
        /// Example: Add payload for delete Project column
        /// </param>
        /// <param name="creator">
        /// A GitHub user.
        /// </param>
        /// <param name="createdAt">
        /// Example: 2016-09-05T14:21:06Z
        /// </param>
        /// <param name="updatedAt">
        /// Example: 2016-09-05T14:20:22Z
        /// </param>
        /// <param name="archived">
        /// Whether or not the card is archived<br/>
        /// Example: false
        /// </param>
        /// <param name="columnName"></param>
        /// <param name="projectId"></param>
        /// <param name="columnUrl">
        /// Example: https://api.github.com/projects/columns/367
        /// </param>
        /// <param name="contentUrl">
        /// Example: https://api.github.com/repos/api-playground/projects-test/issues/3
        /// </param>
        /// <param name="projectUrl">
        /// Example: https://api.github.com/projects/120
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectCard(
            string url,
            long id,
            string nodeId,
            string? note,
            global::G.NullableSimpleUser? creator,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string columnUrl,
            string projectUrl,
            bool? archived,
            string? columnName,
            string? projectId,
            string? contentUrl)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Note = note ?? throw new global::System.ArgumentNullException(nameof(note));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ColumnUrl = columnUrl ?? throw new global::System.ArgumentNullException(nameof(columnUrl));
            this.ProjectUrl = projectUrl ?? throw new global::System.ArgumentNullException(nameof(projectUrl));
            this.Archived = archived;
            this.ColumnName = columnName;
            this.ProjectId = projectId;
            this.ContentUrl = contentUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCard" /> class.
        /// </summary>
        public ProjectCard()
        {
        }
    }
}