﻿//HintName: G.Models.WebhookProjectCardMovedProjectCardVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectCardMovedProjectCardVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("after_id", Required = global::Newtonsoft.Json.Required.Always)]
        public double? AfterId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column_id")]
        public int? ColumnId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column_url")]
        public string? ColumnUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator")]
        public global::G.WebhookProjectCardMovedProjectCardVariant2Creator? Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("note")]
        public string? Note { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_url")]
        public string? ProjectUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectCardMovedProjectCardVariant2" /> class.
        /// </summary>
        /// <param name="afterId"></param>
        /// <param name="archived"></param>
        /// <param name="columnId"></param>
        /// <param name="columnUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="creator"></param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="note"></param>
        /// <param name="projectUrl"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url"></param>
        public WebhookProjectCardMovedProjectCardVariant2(
            double? afterId,
            bool? archived,
            int? columnId,
            string? columnUrl,
            string? createdAt,
            global::G.WebhookProjectCardMovedProjectCardVariant2Creator? creator,
            int? id,
            string? nodeId,
            string? note,
            string? projectUrl,
            string? updatedAt,
            string? url)
        {
            this.AfterId = afterId;
            this.Archived = archived;
            this.ColumnId = columnId;
            this.ColumnUrl = columnUrl;
            this.CreatedAt = createdAt;
            this.Creator = creator;
            this.Id = id;
            this.NodeId = nodeId;
            this.Note = note;
            this.ProjectUrl = projectUrl;
            this.UpdatedAt = updatedAt;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectCardMovedProjectCardVariant2" /> class.
        /// </summary>
        public WebhookProjectCardMovedProjectCardVariant2()
        {
        }
    }
}