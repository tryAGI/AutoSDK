//HintName: G.Models.RequestElevenMultilingualStsV2MediaSpeechToSpeechVideo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A video file containing dialogue to be processed.
    /// </summary>
    public sealed partial class RequestElevenMultilingualStsV2MediaSpeechToSpeechVideo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"video"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "video";

        /// <summary>
        /// A HTTPS URL, Runway or data URI containing an encoded video. See [our docs](/assets/inputs#videos) on video inputs for more information.<br/>
        /// Example: https://example.com/video.mp4
        /// </summary>
        /// <example>https://example.com/video.mp4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestElevenMultilingualStsV2MediaSpeechToSpeechVideo" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded video. See [our docs](/assets/inputs#videos) on video inputs for more information.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestElevenMultilingualStsV2MediaSpeechToSpeechVideo(
            string uri,
            string type = "video")
        {
            this.Uri = uri;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestElevenMultilingualStsV2MediaSpeechToSpeechVideo" /> class.
        /// </summary>
        public RequestElevenMultilingualStsV2MediaSpeechToSpeechVideo()
        {
        }
    }
}