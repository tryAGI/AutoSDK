//HintName: G.Models.IssueEventProjectCard.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Issue Event Project Card
    /// </summary>
    public sealed partial class IssueEventProjectCard
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColumnName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_column_name")]
        public string? PreviousColumnName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueEventProjectCard" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="id"></param>
        /// <param name="projectUrl"></param>
        /// <param name="projectId"></param>
        /// <param name="columnName"></param>
        /// <param name="previousColumnName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssueEventProjectCard(
            string url,
            int id,
            string projectUrl,
            int projectId,
            string columnName,
            string? previousColumnName)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Id = id;
            this.ProjectUrl = projectUrl ?? throw new global::System.ArgumentNullException(nameof(projectUrl));
            this.ProjectId = projectId;
            this.ColumnName = columnName ?? throw new global::System.ArgumentNullException(nameof(columnName));
            this.PreviousColumnName = previousColumnName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueEventProjectCard" /> class.
        /// </summary>
        public IssueEventProjectCard()
        {
        }
    }
}