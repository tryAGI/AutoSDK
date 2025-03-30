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
        [global::Newtonsoft.Json.JsonProperty("src", Required = global::Newtonsoft.Json.Required.Always)]
        public string Src { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucket_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string BucketName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("random_path_slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string RandomPathSlug { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public double DurationSecs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_audio", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsAudio { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="DubbingMediaReference" /> class.
        /// </summary>
        /// <param name="src"></param>
        /// <param name="contentType"></param>
        /// <param name="bucketName"></param>
        /// <param name="randomPathSlug"></param>
        /// <param name="durationSecs"></param>
        /// <param name="isAudio"></param>
        /// <param name="url"></param>
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