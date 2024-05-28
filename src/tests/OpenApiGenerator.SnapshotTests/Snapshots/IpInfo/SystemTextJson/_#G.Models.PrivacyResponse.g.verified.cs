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
        [global::System.Text.Json.Serialization.JsonPropertyName("vpn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Vpn { get; set; }

        /// <summary>
        /// <br/>Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Proxy { get; set; }

        /// <summary>
        /// <br/>Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Tor { get; set; }

        /// <summary>
        /// <br/>Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hosting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Hosting { get; set; }

        /// <summary>
        /// <br/>Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relay")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Relay { get; set; }

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Service { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}