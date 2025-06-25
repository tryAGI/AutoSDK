//HintName: G.Models.DubbingMediaReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbingMediaReference
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Src { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BucketName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("random_path_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RandomPathSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DurationSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAudio { get; set; }

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
        /// Initializes a new instance of the <see cref="DubbingMediaReference" /> class.
        /// </summary>
        /// <param name="src"></param>
        /// <param name="contentType"></param>
        /// <param name="bucketName"></param>
        /// <param name="randomPathSlug"></param>
        /// <param name="durationSecs"></param>
        /// <param name="isAudio"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingMediaReference(
            string src,
            string contentType,
            string bucketName,
            string randomPathSlug,
            double durationSecs,
            bool isAudio,
            string url)
        {
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.BucketName = bucketName ?? throw new global::System.ArgumentNullException(nameof(bucketName));
            this.RandomPathSlug = randomPathSlug ?? throw new global::System.ArgumentNullException(nameof(randomPathSlug));
            this.DurationSecs = durationSecs;
            this.IsAudio = isAudio;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingMediaReference" /> class.
        /// </summary>
        public DubbingMediaReference()
        {
        }
    }
}