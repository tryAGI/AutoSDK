//HintName: G.Models.VideoUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model for video URL validation.
    /// </summary>
    public sealed partial class VideoUrl
    {
        /// <summary>
        /// The video URL. Can be either a URL or a Data URI.
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
        /// Initializes a new instance of the <see cref="VideoUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// The video URL. Can be either a URL or a Data URI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoUrl(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoUrl" /> class.
        /// </summary>
        public VideoUrl()
        {
        }
    }
}