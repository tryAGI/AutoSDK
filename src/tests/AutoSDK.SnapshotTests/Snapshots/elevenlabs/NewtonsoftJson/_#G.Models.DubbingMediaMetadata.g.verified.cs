//HintName: G.Models.DubbingMediaMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbingMediaMetadata
    {
        /// <summary>
        /// The content type of the media.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ContentType { get; set; } = default!;

        /// <summary>
        /// The duration of the media in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public double Duration { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingMediaMetadata" /> class.
        /// </summary>
        /// <param name="contentType">
        /// The content type of the media.
        /// </param>
        /// <param name="duration">
        /// The duration of the media in seconds.
        /// </param>
        public DubbingMediaMetadata(
            string contentType,
            double duration)
        {
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingMediaMetadata" /> class.
        /// </summary>
        public DubbingMediaMetadata()
        {
        }
    }
}