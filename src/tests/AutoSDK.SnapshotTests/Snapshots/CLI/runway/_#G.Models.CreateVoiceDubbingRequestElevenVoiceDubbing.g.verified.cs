//HintName: G.Models.CreateVoiceDubbingRequestElevenVoiceDubbing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVoiceDubbingRequestElevenVoiceDubbing
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
        /// The target language code to dub the audio to (e.g., "es" for Spanish, "fr" for French).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetLang")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang TargetLang { get; set; }

        /// <summary>
        /// Whether to disable voice cloning and use a generic voice instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disableVoiceCloning")]
        public bool? DisableVoiceCloning { get; set; }

        /// <summary>
        /// Whether to remove background audio from the dubbed output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dropBackgroundAudio")]
        public bool? DropBackgroundAudio { get; set; }

        /// <summary>
        /// The number of speakers in the audio. If not provided, it will be detected automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numSpeakers")]
        public int? NumSpeakers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"eleven_voice_dubbing"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "eleven_voice_dubbing";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceDubbingRequestElevenVoiceDubbing" /> class.
        /// </summary>
        /// <param name="audioUri">
        /// A HTTPS URL, Runway or data URI containing an encoded audio. See [our docs](/assets/inputs#audio) on audio inputs for more information.<br/>
        /// Example: https://example.com/audio.mp3
        /// </param>
        /// <param name="targetLang">
        /// The target language code to dub the audio to (e.g., "es" for Spanish, "fr" for French).
        /// </param>
        /// <param name="disableVoiceCloning">
        /// Whether to disable voice cloning and use a generic voice instead.
        /// </param>
        /// <param name="dropBackgroundAudio">
        /// Whether to remove background audio from the dubbed output.
        /// </param>
        /// <param name="numSpeakers">
        /// The number of speakers in the audio. If not provided, it will be detected automatically.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVoiceDubbingRequestElevenVoiceDubbing(
            string audioUri,
            global::G.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang targetLang,
            bool? disableVoiceCloning,
            bool? dropBackgroundAudio,
            int? numSpeakers,
            string model = "eleven_voice_dubbing")
        {
            this.AudioUri = audioUri;
            this.TargetLang = targetLang;
            this.DisableVoiceCloning = disableVoiceCloning;
            this.DropBackgroundAudio = dropBackgroundAudio;
            this.NumSpeakers = numSpeakers;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVoiceDubbingRequestElevenVoiceDubbing" /> class.
        /// </summary>
        public CreateVoiceDubbingRequestElevenVoiceDubbing()
        {
        }
    }
}