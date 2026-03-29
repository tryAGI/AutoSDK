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
        [global::System.Text.Json.Serialization.JsonPropertyName("timeUnixNano")]
        public string? TimeUnixNano { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<global::G.OtlpKeyValue>? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpSpanEvent" /> class.
        /// </summary>
        /// <param name="timeUnixNano"></param>
        /// <param name="name"></param>
        /// <param name="attributes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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