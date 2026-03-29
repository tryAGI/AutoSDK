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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feed_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FeedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Sequence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_preview")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentPreview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_truncated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsTruncated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ContentSizeBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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