//HintName: G.Models.OTELTraceResourceSpanResourceAttributeValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OTELTraceResourceSpanResourceAttributeValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arrayValue")]
        public global::G.OTELTraceResourceSpanResourceAttributeValueArrayValue? ArrayValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("intValue")]
        public double? IntValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stringValue")]
        public string? StringValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanResourceAttributeValue" /> class.
        /// </summary>
        /// <param name="arrayValue"></param>
        /// <param name="intValue"></param>
        /// <param name="stringValue"></param>
        public OTELTraceResourceSpanResourceAttributeValue(
            global::G.OTELTraceResourceSpanResourceAttributeValueArrayValue? arrayValue,
            double? intValue,
            string? stringValue)
        {
            this.ArrayValue = arrayValue;
            this.IntValue = intValue;
            this.StringValue = stringValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanResourceAttributeValue" /> class.
        /// </summary>
        public OTELTraceResourceSpanResourceAttributeValue()
        {
        }
    }
}