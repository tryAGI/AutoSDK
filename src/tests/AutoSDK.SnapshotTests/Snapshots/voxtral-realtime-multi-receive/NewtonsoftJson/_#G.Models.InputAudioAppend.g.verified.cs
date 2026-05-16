//HintName: G.Models.InputAudioAppend.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Append a chunk of base64-encoded PCM audio.
    /// </summary>
    public sealed partial class InputAudioAppend
    {
        /// <summary>
        /// Must be 'input_audio.append'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.InputAudioAppendTypeJsonConverter))]
        public global::G.InputAudioAppendType Type { get; set; }

        /// <summary>
        /// Base64-encoded PCM audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public string Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioAppend" /> class.
        /// </summary>
        /// <param name="data">
        /// Base64-encoded PCM audio.
        /// </param>
        /// <param name="type">
        /// Must be 'input_audio.append'.
        /// </param>
        public InputAudioAppend(
            string data,
            global::G.InputAudioAppendType type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioAppend" /> class.
        /// </summary>
        public InputAudioAppend()
        {
        }

    }
}