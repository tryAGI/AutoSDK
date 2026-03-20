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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Sample rate in Hz (8000, 16000, 22050, 24000, 32000, 44100, 48000).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        public int? Rate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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