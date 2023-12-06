//HintName: G.Models.PrivacyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class PrivacyResponse
    {
        /// <summary>
        /// Example: True
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vpn")]
        public required bool Vpn { get; set; }

        /// <summary>
        /// Example: False
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy")]
        public required bool Proxy { get; set; }

        /// <summary>
        /// Example: False
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tor")]
        public required bool Tor { get; set; }

        /// <summary>
        /// Example: False
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hosting")]
        public required bool Hosting { get; set; }

        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}