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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ColumnName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous_column_name")]
        public string? PreviousColumnName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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