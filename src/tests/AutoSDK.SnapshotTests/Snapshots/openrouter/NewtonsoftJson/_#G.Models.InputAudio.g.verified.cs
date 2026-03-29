//HintName: G.Models.InputAudio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Audio input content item
    /// </summary>
    public sealed partial class InputAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.InputAudioType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_audio", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.InputAudioInputAudio InputAudio1 { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudio" /> class.
        /// </summary>
        /// <param name="inputAudio1"></param>
        /// <param name="type"></param>
        public InputAudio(
            global::G.InputAudioInputAudio inputAudio1,
            global::G.InputAudioType type)
        {
            this.Type = type;
            this.InputAudio1 = inputAudio1 ?? throw new global::System.ArgumentNullException(nameof(inputAudio1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudio" /> class.
        /// </summary>
        public InputAudio()
        {
        }
    }
}