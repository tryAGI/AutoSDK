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
        [global::Newtonsoft.Json.JsonProperty("droppedAttributesCount", Required = global::Newtonsoft.Json.Required.Always)]
        public double DroppedAttributesCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OTELTraceResourceSpanResourceAttribute> Attributes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanResource" /> class.
        /// </summary>
        /// <param name="droppedAttributesCount"></param>
        /// <param name="attributes"></param>
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