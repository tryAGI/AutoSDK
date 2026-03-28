//HintName: G.Models.CreateCharacterPerformanceRequestActTwoCharacterCharacterVideo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A video of your character. In the output, the character will use the reference video performance in its original animated environment and some of the character's own movements.
    /// </summary>
    public sealed partial class CreateCharacterPerformanceRequestActTwoCharacterCharacterVideo
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
        /// Initializes a new instance of the <see cref="CreateCharacterPerformanceRequestActTwoCharacterCharacterVideo" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded video. See [our docs](/assets/inputs#videos) on video inputs for more information.<br/>
        /// Example: https://example.com/video.mp4
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCharacterPerformanceRequestActTwoCharacterCharacterVideo(
            string uri,
            string type = "video")
        {
            this.Type = type;
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCharacterPerformanceRequestActTwoCharacterCharacterVideo" /> class.
        /// </summary>
        public CreateCharacterPerformanceRequestActTwoCharacterCharacterVideo()
        {
        }
    }
}