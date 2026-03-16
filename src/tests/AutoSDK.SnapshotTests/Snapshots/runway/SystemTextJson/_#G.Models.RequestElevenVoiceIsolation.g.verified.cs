//HintName: G.Models.RequestElevenVoiceIsolation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestElevenVoiceIsolation
    {
        /// <summary>
        /// A HTTPS URL, Runway or data URI containing an encoded audio. See [our docs](/assets/inputs#audio) on audio inputs for more information.<br/>
        /// Example: https://example.com/audio.mp3
        /// </summary>
        /// <example>https://example.com/audio.mp3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioUri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"eleven_voice_isolation"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "eleven_voice_isolation";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestElevenVoiceIsolation" /> class.
        /// </summary>
        /// <param name="audioUri">
        /// A HTTPS URL, Runway or data URI containing an encoded audio. See [our docs](/assets/inputs#audio) on audio inputs for more information.<br/>
        /// Example: https://example.com/audio.mp3
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestElevenVoiceIsolation(
            string audioUri,
            string model = "eleven_voice_isolation")
        {
            this.AudioUri = audioUri;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestElevenVoiceIsolation" /> class.
        /// </summary>
        public RequestElevenVoiceIsolation()
        {
        }
    }
}