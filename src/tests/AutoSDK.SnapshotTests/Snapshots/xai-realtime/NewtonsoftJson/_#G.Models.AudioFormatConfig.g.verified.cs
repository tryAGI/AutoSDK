//HintName: G.Models.AudioFormatConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Audio format specification.
    /// </summary>
    public sealed partial class AudioFormatConfig
    {
        /// <summary>
        /// Audio format type: audio/pcm, audio/pcmu, or audio/pcma.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Sample rate in Hz (8000, 16000, 22050, 24000, 32000, 44100, 48000).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate")]
        public int? Rate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioFormatConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Audio format type: audio/pcm, audio/pcmu, or audio/pcma.
        /// </param>
        /// <param name="rate">
        /// Sample rate in Hz (8000, 16000, 22050, 24000, 32000, 44100, 48000).
        /// </param>
        public AudioFormatConfig(
            string? type,
            int? rate)
        {
            this.Type = type;
            this.Rate = rate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioFormatConfig" /> class.
        /// </summary>
        public AudioFormatConfig()
        {
        }
    }
}