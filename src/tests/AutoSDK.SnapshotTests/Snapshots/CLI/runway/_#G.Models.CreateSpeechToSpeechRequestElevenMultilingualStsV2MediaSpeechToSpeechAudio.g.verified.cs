//HintName: G.Models.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An audio file containing dialogue to be processed.
    /// </summary>
    public sealed partial class CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"audio"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "audio";

        /// <summary>
        /// A HTTPS URL, Runway or data URI containing an encoded audio. See [our docs](/assets/inputs#audio) on audio inputs for more information.<br/>
        /// Example: https://example.com/audio.mp3
        /// </summary>
        /// <example>https://example.com/audio.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded audio. See [our docs](/assets/inputs#audio) on audio inputs for more information.<br/>
        /// Example: https://example.com/audio.mp3
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio(
            string uri,
            string type = "audio")
        {
            this.Type = type;
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio" /> class.
        /// </summary>
        public CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaSpeechToSpeechAudio()
        {
        }
    }
}