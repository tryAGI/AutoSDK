//HintName: G.Models.OTELTraceResourceSpanResourceAttributeValueArrayValueValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OTELTraceResourceSpanResourceAttributeValueArrayValueValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stringValue", Required = global::Newtonsoft.Json.Required.Always)]
        public string StringValue { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanResourceAttributeValueArrayValueValue" /> class.
        /// </summary>
        /// <param name="stringValue"></param>
        public OTELTraceResourceSpanResourceAttributeValueArrayValueValue(
            string stringValue)
        {
            this.StringValue = stringValue ?? throw new global::System.ArgumentNullException(nameof(stringValue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanResourceAttributeValueArrayValueValue" /> class.
        /// </summary>
        public OTELTraceResourceSpanResourceAttributeValueArrayValueValue()
        {
        }
    }
}