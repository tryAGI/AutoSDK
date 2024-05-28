//HintName: G.Models.PrivacyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivacyResponse
    {
        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vpn", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Vpn { get; set; } = default!;

        /// <summary>
        /// <br/>Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("proxy", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Proxy { get; set; } = default!;

        /// <summary>
        /// <br/>Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tor", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Tor { get; set; } = default!;

        /// <summary>
        /// <br/>Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hosting", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Hosting { get; set; } = default!;

        /// <summary>
        /// <br/>Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("relay", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Relay { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service", Required = global::Newtonsoft.Json.Required.Always)]
        public string Service { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}