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
        [global::System.Text.Json.Serialization.JsonPropertyName("vpn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Vpn { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Proxy { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Tor { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hosting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Hosting { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("relay")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Relay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Service { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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