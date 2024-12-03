//HintName: G.Models.WebhooksDeployKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The [`deploy key`](https://docs.github.com/rest/deploy-keys/deploy-keys#get-a-deploy-key) resource.
    /// </summary>
    public sealed partial class WebhooksDeployKey
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("added_by")]
        public string? AddedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_used")]
        public string? LastUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("read_only", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ReadOnly { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verified", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Verified { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksDeployKey" /> class.
        /// </summary>
        /// <param name="addedBy"></param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="key"></param>
        /// <param name="lastUsed"></param>
        /// <param name="readOnly"></param>
        /// <param name="title"></param>
        /// <param name="url"></param>
        /// <param name="verified"></param>
        public WebhooksDeployKey(
            string createdAt,
            int id,
            string key,
            bool readOnly,
            string title,
            string url,
            bool verified,
            string? addedBy,
            string? lastUsed)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Id = id;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.ReadOnly = readOnly;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Verified = verified;
            this.AddedBy = addedBy;
            this.LastUsed = lastUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksDeployKey" /> class.
        /// </summary>
        public WebhooksDeployKey()
        {
        }
    }
}