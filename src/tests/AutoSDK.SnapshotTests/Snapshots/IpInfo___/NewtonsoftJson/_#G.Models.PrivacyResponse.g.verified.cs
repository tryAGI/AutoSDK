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
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("vpn", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Vpn { get; set; } = default!;

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("proxy", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Proxy { get; set; } = default!;

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("tor", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Tor { get; set; } = default!;

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("hosting", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Hosting { get; set; } = default!;

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("relay", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Relay { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service", Required = global::Newtonsoft.Json.Required.Always)]
        public string Service { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivacyResponse" /> class.
        /// </summary>
        /// <param name="vpn">
        /// Example: true
        /// </param>
        /// <param name="proxy">
        /// Example: false
        /// </param>
        /// <param name="tor">
        /// Example: false
        /// </param>
        /// <param name="hosting">
        /// Example: false
        /// </param>
        /// <param name="relay">
        /// Example: false
        /// </param>
        /// <param name="service"></param>
        public PrivacyResponse(
            bool vpn,
            bool proxy,
            bool tor,
            bool hosting,
            bool relay,
            string service)
        {
            this.Vpn = vpn;
            this.Proxy = proxy;
            this.Tor = tor;
            this.Hosting = hosting;
            this.Relay = relay;
            this.Service = service ?? throw new global::System.ArgumentNullException(nameof(service));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivacyResponse" /> class.
        /// </summary>
        public PrivacyResponse()
        {
        }
    }
}