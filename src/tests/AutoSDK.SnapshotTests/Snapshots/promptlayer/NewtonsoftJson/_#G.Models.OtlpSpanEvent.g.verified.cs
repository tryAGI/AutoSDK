//HintName: G.Models.OtlpSpanEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OtlpSpanEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeUnixNano")]
        public string? TimeUnixNano { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes")]
        public global::System.Collections.Generic.IList<global::G.OtlpKeyValue>? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpSpanEvent" /> class.
        /// </summary>
        /// <param name="timeUnixNano"></param>
        /// <param name="name"></param>
        /// <param name="attributes"></param>
        public OtlpSpanEvent(
            string? timeUnixNano,
            string? name,
            global::System.Collections.Generic.IList<global::G.OtlpKeyValue>? attributes)
        {
            this.TimeUnixNano = timeUnixNano;
            this.Name = name;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpSpanEvent" /> class.
        /// </summary>
        public OtlpSpanEvent()
        {
        }
    }
}