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
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OTELTraceResourceSpanResourceAttributeValueArrayValueValue> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanResourceAttributeValueArrayValue" /> class.
        /// </summary>
        /// <param name="values"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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