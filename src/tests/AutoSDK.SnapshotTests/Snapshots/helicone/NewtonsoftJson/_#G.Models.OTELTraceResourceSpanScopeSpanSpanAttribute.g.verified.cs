//HintName: G.Models.OTELTraceResourceSpanScopeSpanSpanAttribute.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OTELTraceResourceSpanScopeSpanSpanAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OTELTraceResourceSpanScopeSpanSpanAttributeValue Value { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanScopeSpanSpanAttribute" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="key"></param>
        public OTELTraceResourceSpanScopeSpanSpanAttribute(
            global::G.OTELTraceResourceSpanScopeSpanSpanAttributeValue value,
            string key)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OTELTraceResourceSpanScopeSpanSpanAttribute" /> class.
        /// </summary>
        public OTELTraceResourceSpanScopeSpanSpanAttribute()
        {
        }
    }
}