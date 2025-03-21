//HintName: G.Models.InputAudio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An audio input to the model.
    /// </summary>
    public sealed partial class InputAudio
    {
        /// <summary>
        /// Base64-encoded audio data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public string Data { get; set; } = default!;

        /// <summary>
        /// The format of the audio data. Currently supported formats are `mp3` and<br/>
        /// `wav`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InputAudioFormat Format { get; set; } = default!;

        /// <summary>
        /// The type of the input item. Always `input_audio`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.InputAudioType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudio" /> class.
        /// </summary>
        /// <param name="data">
        /// Base64-encoded audio data.
        /// </param>
        /// <param name="format">
        /// The format of the audio data. Currently supported formats are `mp3` and<br/>
        /// `wav`.
        /// </param>
        /// <param name="type">
        /// The type of the input item. Always `input_audio`.
        /// </param>
        public InputAudio(
            string data,
            global::G.InputAudioFormat format,
            global::G.InputAudioType type)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Format = format;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudio" /> class.
        /// </summary>
        public InputAudio()
        {
        }
    }
}