//HintName: G.Models.FeedsListMessagesResponseMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedsListMessagesResponseMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feed_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FeedId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sequence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Sequence { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_preview", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentPreview { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_truncated", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsTruncated { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_size_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public double ContentSizeBytes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExpiresAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsListMessagesResponseMessage" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="feedId"></param>
        /// <param name="sequence"></param>
        /// <param name="contentPreview"></param>
        /// <param name="isTruncated"></param>
        /// <param name="contentSizeBytes"></param>
        /// <param name="expiresAt"></param>
        /// <param name="createdAt"></param>
        public FeedsListMessagesResponseMessage(
            string id,
            string feedId,
            double sequence,
            string contentPreview,
            bool isTruncated,
            double contentSizeBytes,
            string expiresAt,
            string createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.FeedId = feedId ?? throw new global::System.ArgumentNullException(nameof(feedId));
            this.Sequence = sequence;
            this.ContentPreview = contentPreview ?? throw new global::System.ArgumentNullException(nameof(contentPreview));
            this.IsTruncated = isTruncated;
            this.ContentSizeBytes = contentSizeBytes;
            this.ExpiresAt = expiresAt ?? throw new global::System.ArgumentNullException(nameof(expiresAt));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsListMessagesResponseMessage" /> class.
        /// </summary>
        public FeedsListMessagesResponseMessage()
        {
        }
    }
}