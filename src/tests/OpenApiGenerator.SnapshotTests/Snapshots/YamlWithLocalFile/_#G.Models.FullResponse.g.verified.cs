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
        /// <br/>Example: 66.87.125.72
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip")]
        public required string Ip { get; set; }

        /// <summary>
        /// <br/>Example: ip-66-87-125-72.spfdma.spcsdns.net
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        public string? Hostname { get; set; }

        /// <summary>
        /// <br/>Example: Springfield
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public required string City { get; set; }

        /// <summary>
        /// <br/>Example: Massachusetts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// <br/>Example: US
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public required string Country { get; set; }

        /// <summary>
        /// <br/>Example: 42.0999,-72.5783
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loc")]
        public string? Loc { get; set; }

        /// <summary>
        /// <br/>Example: 01105
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postal")]
        public string? Postal { get; set; }

        /// <summary>
        /// <br/>Example: America/New_York
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// <br/>Example: AS51501 Khabarovsk home networks Ltd
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        public string? Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asn")]
        public AsnResponse? Asn { get; set; }

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