//HintName: G.Models.MP3OutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MP3OutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SampleRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bit_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BitRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MP3OutputFormat" /> class.
        /// </summary>
        /// <param name="sampleRate"></param>
        /// <param name="bitRate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MP3OutputFormat(
            int sampleRate,
            int bitRate)
        {
            this.SampleRate = sampleRate;
            this.BitRate = bitRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MP3OutputFormat" /> class.
        /// </summary>
        public MP3OutputFormat()
        {
        }
    }
}