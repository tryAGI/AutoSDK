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
        [global::System.Text.Json.Serialization.JsonPropertyName("stringValue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StringValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanResourceAttributeValueArrayValueValue" /> class.
        /// </summary>
        /// <param name="stringValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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