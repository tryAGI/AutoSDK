//HintName: G.Models.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A video file containing dialogue to be processed.
    /// </summary>
    public sealed partial class CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"video"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "video";

        /// <summary>
        /// A HTTPS URL, Runway or data URI containing an encoded video. See [our docs](/assets/inputs#videos) on video inputs for more information.<br/>
        /// Example: https://example.com/video.mp4
        /// </summary>
        /// <example>https://example.com/video.mp4</example>
        [global::Newtonsoft.Json.JsonProperty("uri", Required = global::Newtonsoft.Json.Required.Always)]
        public string Uri { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded video. See [our docs](/assets/inputs#videos) on video inputs for more information.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
        public CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo(
            string uri,
            string type = "video")
        {
            this.Uri = uri;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo" /> class.
        /// </summary>
        public CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechVideo()
        {
        }
    }
}