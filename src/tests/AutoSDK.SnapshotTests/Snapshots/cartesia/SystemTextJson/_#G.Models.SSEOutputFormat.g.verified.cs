//HintName: G.Models.SSEOutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SSEOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SSEOutputFormatContainerJsonConverter))]
        public global::G.SSEOutputFormatContainer Container { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RawEncodingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RawEncoding Encoding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SampleRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SSEOutputFormat" /> class.
        /// </summary>
        /// <param name="encoding"></param>
        /// <param name="sampleRate"></param>
        /// <param name="container"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SSEOutputFormat(
            global::G.RawEncoding encoding,
            int sampleRate,
            global::G.SSEOutputFormatContainer container)
        {
            this.Container = container;
            this.Encoding = encoding;
            this.SampleRate = sampleRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSEOutputFormat" /> class.
        /// </summary>
        public SSEOutputFormat()
        {
        }
    }
}