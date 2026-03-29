//HintName: G.Models.OtlpKeyValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An OTLP attribute key-value pair.
    /// </summary>
    public sealed partial class OtlpKeyValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// The attribute value. Exactly one of the value fields must be set.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OtlpKeyValueValue Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpKeyValue" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value">
        /// The attribute value. Exactly one of the value fields must be set.
        /// </param>
        public OtlpKeyValue(
            string key,
            global::G.OtlpKeyValueValue value)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtlpKeyValue" /> class.
        /// </summary>
        public OtlpKeyValue()
        {
        }
    }
}