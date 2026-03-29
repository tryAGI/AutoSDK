//HintName: G.Models.RawOutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RawOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encoding", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RawEncoding Encoding { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_rate", Required = global::Newtonsoft.Json.Required.Always)]
        public int SampleRate { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RawOutputFormat" /> class.
        /// </summary>
        /// <param name="encoding"></param>
        /// <param name="sampleRate"></param>
        public RawOutputFormat(
            global::G.RawEncoding encoding,
            int sampleRate)
        {
            this.Encoding = encoding;
            this.SampleRate = sampleRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RawOutputFormat" /> class.
        /// </summary>
        public RawOutputFormat()
        {
        }
    }
}