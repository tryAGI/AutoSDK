//HintName: G.Models.StreamingTranscriptionResponseVariant22.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamingTranscriptionResponseVariant22
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.StreamingTranscriptionResponseVariant2TypeJsonConverter))]
        public global::G.StreamingTranscriptionResponseVariant2Type? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingTranscriptionResponseVariant22" /> class.
        /// </summary>
        /// <param name="type"></param>
        public StreamingTranscriptionResponseVariant22(
            global::G.StreamingTranscriptionResponseVariant2Type? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingTranscriptionResponseVariant22" /> class.
        /// </summary>
        public StreamingTranscriptionResponseVariant22()
        {
        }
    }
}