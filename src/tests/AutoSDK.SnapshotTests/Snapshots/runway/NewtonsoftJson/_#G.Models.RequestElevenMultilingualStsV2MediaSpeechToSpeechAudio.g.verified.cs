//HintName: G.Models.RequestElevenMultilingualStsV2MediaSpeechToSpeechAudio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An audio file containing dialogue to be processed.
    /// </summary>
    public sealed partial class RequestElevenMultilingualStsV2MediaSpeechToSpeechAudio
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"audio"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "audio";

        /// <summary>
        /// A HTTPS URL, Runway or data URI containing an encoded audio. See [our docs](/assets/inputs#audio) on audio inputs for more information.<br/>
        /// Example: https://example.com/audio.mp3
        /// </summary>
        /// <example>https://example.com/audio.mp3</example>
        [global::Newtonsoft.Json.JsonProperty("uri", Required = global::Newtonsoft.Json.Required.Always)]
        public string Uri { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestElevenMultilingualStsV2MediaSpeechToSpeechAudio" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded audio. See [our docs](/assets/inputs#audio) on audio inputs for more information.<br/>
        /// Example: https://example.com/audio.mp3
        /// </param>
        public RequestElevenMultilingualStsV2MediaSpeechToSpeechAudio(
            string uri,
            string type = "audio")
        {
            this.Uri = uri;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestElevenMultilingualStsV2MediaSpeechToSpeechAudio" /> class.
        /// </summary>
        public RequestElevenMultilingualStsV2MediaSpeechToSpeechAudio()
        {
        }
    }
}