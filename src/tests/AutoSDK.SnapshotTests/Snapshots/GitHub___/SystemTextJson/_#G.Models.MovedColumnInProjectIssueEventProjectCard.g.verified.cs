//HintName: G.Models.MovedColumnInProjectIssueEventProjectCard.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MovedColumnInProjectIssueEventProjectCard
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectUrl { get; set; }

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
        /// Initializes a new instance of the <see cref="MovedColumnInProjectIssueEventProjectCard" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="projectId"></param>
        /// <param name="projectUrl"></param>
        /// <param name="columnName"></param>
        /// <param name="previousColumnName"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MovedColumnInProjectIssueEventProjectCard(
            int id,
            string url,
            int projectId,
            string projectUrl,
            string columnName,
            string? previousColumnName)
        {
            this.Id = id;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ProjectId = projectId;
            this.ProjectUrl = projectUrl ?? throw new global::System.ArgumentNullException(nameof(projectUrl));
            this.ColumnName = columnName ?? throw new global::System.ArgumentNullException(nameof(columnName));
            this.PreviousColumnName = previousColumnName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MovedColumnInProjectIssueEventProjectCard" /> class.
        /// </summary>
        public MovedColumnInProjectIssueEventProjectCard()
        {
        }
    }
}