//HintName: G.Models.CreateVoiceIsolationRequestElevenVoiceIsolation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVoiceIsolationRequestElevenVoiceIsolation
    {
        /// <summary>
        /// A HTTPS URL, Runway or data URI containing an encoded audio. See [our docs](/assets/inputs#audio) on audio inputs for more information.<br/>
        /// Example: https://example.com/audio.mp3
        /// </summary>
        /// <example>https://example.com/audio.mp3</example>
        [global::Newtonsoft.Json.JsonProperty("audioUri", Required = global::Newtonsoft.Json.Required.Always)]
        public string AudioUri { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"eleven_voice_isolation"</default>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string Model { get; set; } = "eleven_voice_isolation";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceIsolationRequestElevenVoiceIsolation" /> class.
        /// </summary>
        /// <param name="audioUri">
        /// A HTTPS URL, Runway or data URI containing an encoded audio. See [our docs](/assets/inputs#audio) on audio inputs for more information.<br/>
        /// Example: https://example.com/audio.mp3
        /// </param>
        /// <param name="model"></param>
        public CreateVoiceIsolationRequestElevenVoiceIsolation(
            string audioUri,
            string model = "eleven_voice_isolation")
        {
            this.AudioUri = audioUri;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceIsolationRequestElevenVoiceIsolation" /> class.
        /// </summary>
        public CreateVoiceIsolationRequestElevenVoiceIsolation()
        {
        }
    }
}