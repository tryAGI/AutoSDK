//HintName: G.Models.WebhookProjectCardMovedProjectCardProjectCard1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectCardMovedProjectCardProjectCard1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("after_id")]
        public int? AfterId { get; set; }

        /// <summary>
        /// Whether or not the card is archived
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archived", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Archived { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ColumnId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ColumnUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_url")]
        public string? ContentUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator")]
        public global::G.WebhookProjectCardMovedProjectCardProjectCard1Creator? Creator { get; set; }

        /// <summary>
        /// The project card's ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("note")]
        public string? Note { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectCardMovedProjectCardProjectCard1" /> class.
        /// </summary>
        /// <param name="afterId"></param>
        /// <param name="archived">
        /// Whether or not the card is archived
        /// </param>
        /// <param name="columnId"></param>
        /// <param name="columnUrl"></param>
        /// <param name="contentUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="creator"></param>
        /// <param name="id">
        /// The project card's ID
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="note"></param>
        /// <param name="projectUrl"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url"></param>
        public WebhookProjectCardMovedProjectCardProjectCard1(
            bool archived,
            int columnId,
            string columnUrl,
            global::System.DateTime createdAt,
            int id,
            string nodeId,
            string projectUrl,
            global::System.DateTime updatedAt,
            string url,
            int? afterId,
            string? contentUrl,
            global::G.WebhookProjectCardMovedProjectCardProjectCard1Creator? creator,
            string? note)
        {
            this.Archived = archived;
            this.ColumnId = columnId;
            this.ColumnUrl = columnUrl ?? throw new global::System.ArgumentNullException(nameof(columnUrl));
            this.CreatedAt = createdAt;
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.ProjectUrl = projectUrl ?? throw new global::System.ArgumentNullException(nameof(projectUrl));
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.AfterId = afterId;
            this.ContentUrl = contentUrl;
            this.Creator = creator;
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectCardMovedProjectCardProjectCard1" /> class.
        /// </summary>
        public WebhookProjectCardMovedProjectCardProjectCard1()
        {
        }
    }
}