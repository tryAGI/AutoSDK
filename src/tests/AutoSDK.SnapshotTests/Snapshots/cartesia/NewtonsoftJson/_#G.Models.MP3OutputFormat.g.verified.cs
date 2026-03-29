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
        [global::Newtonsoft.Json.JsonProperty("sample_rate", Required = global::Newtonsoft.Json.Required.Always)]
        public int SampleRate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bit_rate", Required = global::Newtonsoft.Json.Required.Always)]
        public int BitRate { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MP3OutputFormat" /> class.
        /// </summary>
        /// <param name="sampleRate"></param>
        /// <param name="bitRate"></param>
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