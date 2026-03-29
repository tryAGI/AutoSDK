//HintName: G.Models.AudioScript3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioScript3
    {
        /// <summary>
        /// The type of the script.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.AudioScript3Type Type { get; set; }

        /// <summary>
        /// Should subtitles be created.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subtitles")]
        public bool? Subtitles { get; set; }

        /// <summary>
        /// The URL of the audio file which will be used by the actor.<br/>
        /// File size is limited to 15MB.<br/>
        /// Audio length is limited 5 minutes for clips and 10 minutes for talks.<br/>
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
        /// Initializes a new instance of the <see cref="AudioScript3" /> class.
        /// </summary>
        /// <param name="audioUrl">
        /// The URL of the audio file which will be used by the actor.<br/>
        /// File size is limited to 15MB.<br/>
        /// Audio length is limited 5 minutes for clips and 10 minutes for talks.<br/>
        /// Example: https://path.to/audio.mp3
        /// </param>
        /// <param name="type">
        /// The type of the script.
        /// </param>
        /// <param name="subtitles">
        /// Should subtitles be created.<br/>
        /// Default Value: false
        /// </param>
        public AudioScript3(
            string audioUrl,
            global::G.AudioScript3Type type,
            bool? subtitles)
        {
            this.Type = type;
            this.Subtitles = subtitles;
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioScript3" /> class.
        /// </summary>
        public AudioScript3()
        {
        }
    }
}