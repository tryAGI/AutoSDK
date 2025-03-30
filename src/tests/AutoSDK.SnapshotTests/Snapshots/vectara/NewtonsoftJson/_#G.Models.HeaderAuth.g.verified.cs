//HintName: G.Models.HeaderAuth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom header-based authentication
    /// </summary>
    public sealed partial class HeaderAuth
    {
        /// <summary>
        /// Must be "header" for header-based auth<br/>
        /// Default Value: header
        /// </summary>
        /// <default>"header"</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The header name to use (e.g. x-api-key)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("header", Required = global::Newtonsoft.Json.Required.Always)]
        public string Header { get; set; } = default!;

        /// <summary>
        /// The header value to use
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeaderAuth" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "header" for header-based auth<br/>
        /// Default Value: header
        /// </param>
        /// <param name="header">
        /// The header name to use (e.g. x-api-key)
        /// </param>
        /// <param name="value">
        /// The header value to use
        /// </param>
        public HeaderAuth(
            string type,
            string header,
            string value)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Header = header ?? throw new global::System.ArgumentNullException(nameof(header));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeaderAuth" /> class.
        /// </summary>
        public HeaderAuth()
        {
        }
    }
}