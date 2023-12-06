//HintName: G.Models.FullResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class FullResponse
    {
        /// <summary>
        /// Example: 66.87.125.72
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip")]
        public string? Ip { get; set; }

        /// <summary>
        /// Example: ip-66-87-125-72.spfdma.spcsdns.net
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        public string? Hostname { get; set; }

        /// <summary>
        /// Example: Springfield
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// Example: Massachusetts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Example: US
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Example: 42.0999,-72.5783
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loc")]
        public string? Loc { get; set; }

        /// <summary>
        /// Example: 01105
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postal")]
        public string? Postal { get; set; }

        /// <summary>
        /// Example: America/New_York
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Example: AS51501 Khabarovsk home networks Ltd
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        public string? Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asn")]
        public required AsnResponse? Asn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        public Company? Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("carrier")]
        public Carrier? Carrier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        public PrivacyResponse? Privacy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public DomainsResponse? Domains { get; set; }

        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}