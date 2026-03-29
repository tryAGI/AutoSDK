//HintName: G.Models.OTELTraceResourceSpanResourceAttribute.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OTELTraceResourceSpanResourceAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OTELTraceResourceSpanResourceAttributeValue Value { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanResourceAttribute" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="key"></param>
        public OTELTraceResourceSpanResourceAttribute(
            global::G.OTELTraceResourceSpanResourceAttributeValue value,
            string key)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanResourceAttribute" /> class.
        /// </summary>
        public OTELTraceResourceSpanResourceAttribute()
        {
        }
    }
}