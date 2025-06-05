//HintName: G.Models.InputAudio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InputAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public string Data { get; set; } = default!;

        /// <summary>
        /// Default Value: wav
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public global::G.InputAudioFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudio" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="format">
        /// Default Value: wav
        /// </param>
        public InputAudio(
            string data,
            global::G.InputAudioFormat? format)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudio" /> class.
        /// </summary>
        public InputAudio()
        {
        }
    }
}