//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant2Label.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookIssueCommentDeletedIssueVariant2Label
    {
        /// <summary>
        /// 6-character hex code, without the leading #, identifying the color
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color", Required = global::Newtonsoft.Json.Required.Always)]
        public string Color { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Default { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The name of the label.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// URL for the label
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssueCommentDeletedIssueVariant2Label" /> class.
        /// </summary>
        /// <param name="color">
        /// 6-character hex code, without the leading #, identifying the color
        /// </param>
        /// <param name="default"></param>
        /// <param name="description"></param>
        /// <param name="id"></param>
        /// <param name="name">
        /// The name of the label.
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="url">
        /// URL for the label
        /// </param>
        public WebhookIssueCommentDeletedIssueVariant2Label(
            string color,
            bool @default,
            string? description,
            int id,
            string name,
            string nodeId,
            string url)
        {
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
            this.Default = @default;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookIssueCommentDeletedIssueVariant2Label" /> class.
        /// </summary>
        public WebhookIssueCommentDeletedIssueVariant2Label()
        {
        }
    }
}