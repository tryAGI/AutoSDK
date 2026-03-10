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
        [global::System.Text.Json.Serialization.JsonPropertyName("after_id")]
        public int? AfterId { get; set; }

        /// <summary>
        /// Whether or not the card is archived
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Archived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ColumnId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColumnUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_url")]
        public string? ContentUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        public global::G.WebhookProjectCardMovedProjectCardProjectCard1Creator? Creator { get; set; }

        /// <summary>
        /// The project card's ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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