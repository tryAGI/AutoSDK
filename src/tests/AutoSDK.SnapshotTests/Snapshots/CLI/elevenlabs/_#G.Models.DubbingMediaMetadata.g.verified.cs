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
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// The duration of the media in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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