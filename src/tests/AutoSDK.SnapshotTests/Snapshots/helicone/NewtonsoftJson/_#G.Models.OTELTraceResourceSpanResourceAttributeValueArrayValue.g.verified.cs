//HintName: G.Models.OTELTraceResourceSpanResourceAttributeValueArrayValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OTELTraceResourceSpanResourceAttributeValueArrayValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("values", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OTELTraceResourceSpanResourceAttributeValueArrayValueValue> Values { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanResourceAttributeValueArrayValue" /> class.
        /// </summary>
        /// <param name="values"></param>
        public OTELTraceResourceSpanResourceAttributeValueArrayValue(
            global::System.Collections.Generic.IList<global::G.OTELTraceResourceSpanResourceAttributeValueArrayValueValue> values)
        {
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanResourceAttributeValueArrayValue" /> class.
        /// </summary>
        public OTELTraceResourceSpanResourceAttributeValueArrayValue()
        {
        }
    }
}