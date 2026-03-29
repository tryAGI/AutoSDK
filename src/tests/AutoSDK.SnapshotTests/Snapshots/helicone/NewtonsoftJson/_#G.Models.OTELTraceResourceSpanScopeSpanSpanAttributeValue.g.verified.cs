//HintName: G.Models.OTELTraceResourceSpanScopeSpanSpanAttributeValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OTELTraceResourceSpanScopeSpanSpanAttributeValue
    {
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
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanScopeSpanSpanAttributeValue" /> class.
        /// </summary>
        /// <param name="intValue"></param>
        /// <param name="stringValue"></param>
        public OTELTraceResourceSpanScopeSpanSpanAttributeValue(
            double? intValue,
            string? stringValue)
        {
            this.IntValue = intValue;
            this.StringValue = stringValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanScopeSpanSpanAttributeValue" /> class.
        /// </summary>
        public OTELTraceResourceSpanScopeSpanSpanAttributeValue()
        {
        }
    }
}