//HintName: G.Models.CustomSIPHeader.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom SIP header for phone transfers with a static (validated) value.
    /// </summary>
    public sealed partial class CustomSIPHeader
    {
        /// <summary>
        /// Default Value: static
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The SIP header name (e.g., 'X-Customer-ID')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// The header value
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSIPHeader" /> class.
        /// </summary>
        /// <param name="key">
        /// The SIP header name (e.g., 'X-Customer-ID')
        /// </param>
        /// <param name="value">
        /// The header value
        /// </param>
        /// <param name="type">
        /// Default Value: static
        /// </param>
        public CustomSIPHeader(
            string key,
            string value,
            string? type)
        {
            this.Type = type;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSIPHeader" /> class.
        /// </summary>
        public CustomSIPHeader()
        {
        }
    }
}