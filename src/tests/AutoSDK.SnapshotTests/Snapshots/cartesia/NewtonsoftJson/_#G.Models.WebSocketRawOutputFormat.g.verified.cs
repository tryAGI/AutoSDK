//HintName: G.Models.WebSocketRawOutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSocketRawOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("container")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.WebSocketRawOutputFormatContainerJsonConverter))]
        public global::G.WebSocketRawOutputFormatContainer Container { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encoding", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RawEncodingJsonConverter))]
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
        /// Initializes a new instance of the <see cref="WebSocketRawOutputFormat" /> class.
        /// </summary>
        /// <param name="encoding"></param>
        /// <param name="sampleRate"></param>
        /// <param name="container"></param>
        public WebSocketRawOutputFormat(
            global::G.RawEncoding encoding,
            int sampleRate,
            global::G.WebSocketRawOutputFormatContainer container)
        {
            this.Container = container;
            this.Encoding = encoding;
            this.SampleRate = sampleRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSocketRawOutputFormat" /> class.
        /// </summary>
        public WebSocketRawOutputFormat()
        {
        }
    }
}