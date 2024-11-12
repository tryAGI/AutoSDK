//HintName: G.Models.StreamSentinel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamSentinel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.StreamSentinelData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamSentinel" /> class.
        /// </summary>
        /// <param name="data"></param>
        public StreamSentinel(
            global::G.StreamSentinelData data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamSentinel" /> class.
        /// </summary>
        public StreamSentinel()
        {
        }
    }
}