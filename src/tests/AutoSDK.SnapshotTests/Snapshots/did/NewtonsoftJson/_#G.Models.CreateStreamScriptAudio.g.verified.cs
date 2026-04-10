//HintName: G.Models.CreateStreamScriptAudio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStreamScriptAudio
    {
        /// <summary>
        /// The type of the script.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateStreamScriptAudioTypeJsonConverter))]
        public global::G.CreateStreamScriptAudioType Type { get; set; }

        /// <summary>
        /// The URL of the audio file which will be used by the actor.<br/>
        /// File size is limit to 15MB.<br/>
        /// Example: https://path.to/audio.mp3
        /// </summary>
        /// <example>https://path.to/audio.mp3</example>
        [global::Newtonsoft.Json.JsonProperty("audio_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AudioUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStreamScriptAudio" /> class.
        /// </summary>
        /// <param name="audioUrl">
        /// The URL of the audio file which will be used by the actor.<br/>
        /// File size is limit to 15MB.<br/>
        /// Example: https://path.to/audio.mp3
        /// </param>
        /// <param name="type">
        /// The type of the script.
        /// </param>
        public CreateStreamScriptAudio(
            string audioUrl,
            global::G.CreateStreamScriptAudioType type)
        {
            this.Type = type;
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStreamScriptAudio" /> class.
        /// </summary>
        public CreateStreamScriptAudio()
        {
        }
    }
}