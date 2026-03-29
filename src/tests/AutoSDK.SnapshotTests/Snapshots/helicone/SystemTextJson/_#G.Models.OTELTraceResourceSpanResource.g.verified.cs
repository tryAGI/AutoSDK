//HintName: G.Models.OTELTraceResourceSpanResource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OTELTraceResourceSpanResource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("droppedAttributesCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DroppedAttributesCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OTELTraceResourceSpanResourceAttribute> Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanResource" /> class.
        /// </summary>
        /// <param name="droppedAttributesCount"></param>
        /// <param name="attributes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OTELTraceResourceSpanResource(
            double droppedAttributesCount,
            global::System.Collections.Generic.IList<global::G.OTELTraceResourceSpanResourceAttribute> attributes)
        {
            this.DroppedAttributesCount = droppedAttributesCount;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanResource" /> class.
        /// </summary>
        public OTELTraceResourceSpanResource()
        {
        }
    }
}