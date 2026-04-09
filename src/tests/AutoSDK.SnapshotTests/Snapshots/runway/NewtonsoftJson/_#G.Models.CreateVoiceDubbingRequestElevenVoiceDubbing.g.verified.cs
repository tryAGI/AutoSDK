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
        [global::Newtonsoft.Json.JsonProperty("audioUri", Required = global::Newtonsoft.Json.Required.Always)]
        public string AudioUri { get; set; } = default!;

        /// <summary>
        /// The target language code to dub the audio to (e.g., "es" for Spanish, "fr" for French).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("targetLang", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangJsonConverter))]
        public global::G.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLang TargetLang { get; set; } = default!;

        /// <summary>
        /// Whether to disable voice cloning and use a generic voice instead.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disableVoiceCloning")]
        public bool? DisableVoiceCloning { get; set; }

        /// <summary>
        /// Whether to remove background audio from the dubbed output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dropBackgroundAudio")]
        public bool? DropBackgroundAudio { get; set; }

        /// <summary>
        /// The number of speakers in the audio. If not provided, it will be detected automatically.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numSpeakers")]
        public int? NumSpeakers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"eleven_voice_dubbing"</default>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string Model { get; set; } = "eleven_voice_dubbing";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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