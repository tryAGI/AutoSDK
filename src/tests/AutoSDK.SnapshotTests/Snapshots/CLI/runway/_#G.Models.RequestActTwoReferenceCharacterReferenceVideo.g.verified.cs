//HintName: G.Models.RequestActTwoReferenceCharacterReferenceVideo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A video of a person performing in the manner that you would like your character to perform. The video must be between 3 and 30 seconds in duration.
    /// </summary>
    public sealed partial class RequestActTwoReferenceCharacterReferenceVideo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"video"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "video";

        /// <summary>
        /// A video of a person performing in the manner that you would like your character to perform. The video must be between 3 and 30 seconds in duration. See [our docs](/assets/inputs#videos) on video inputs for more information.<br/>
        /// Example: https://example.com/reference-performance.mp4
        /// </summary>
        /// <example>https://example.com/reference-performance.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestActTwoReferenceCharacterReferenceVideo" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="uri">
        /// A video of a person performing in the manner that you would like your character to perform. The video must be between 3 and 30 seconds in duration. See [our docs](/assets/inputs#videos) on video inputs for more information.<br/>
        /// Example: https://example.com/reference-performance.mp4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestActTwoReferenceCharacterReferenceVideo(
            string uri,
            string type = "video")
        {
            this.Uri = uri;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestActTwoReferenceCharacterReferenceVideo" /> class.
        /// </summary>
        public RequestActTwoReferenceCharacterReferenceVideo()
        {
        }
    }
}