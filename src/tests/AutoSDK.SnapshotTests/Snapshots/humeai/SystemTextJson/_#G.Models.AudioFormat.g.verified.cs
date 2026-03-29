//HintName: G.Models.AudioFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AudioFormatTypeJsonConverter))]
        public global::G.AudioFormatType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bit_depth")]
        public int? BitDepth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioFormat" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="sampleRate"></param>
        /// <param name="bitDepth"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioFormat(
            global::G.AudioFormatType? type,
            int? sampleRate,
            int? bitDepth)
        {
            this.Type = type;
            this.SampleRate = sampleRate;
            this.BitDepth = bitDepth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioFormat" /> class.
        /// </summary>
        public AudioFormat()
        {
        }
    }
}