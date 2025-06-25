//HintName: G.Models.FullResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FullResponse
    {
        /// <summary>
        /// Example: 66.87.125.72
        /// </summary>
        /// <example>66.87.125.72</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ip { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bogon")]
        public bool? Bogon { get; set; }

        /// <summary>
        /// Example: ip-66-87-125-72.spfdma.spcsdns.net
        /// </summary>
        /// <example>ip-66-87-125-72.spfdma.spcsdns.net</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        public string? Hostname { get; set; }

        /// <summary>
        /// Example: Springfield
        /// </summary>
        /// <example>Springfield</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// Example: Massachusetts
        /// </summary>
        /// <example>Massachusetts</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Example: US
        /// </summary>
        /// <example>US</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Example: 42.0999,-72.5783
        /// </summary>
        /// <example>42.0999,-72.5783</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("loc")]
        public string? Loc { get; set; }

        /// <summary>
        /// Example: 01105
        /// </summary>
        /// <example>01105</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("postal")]
        public string? Postal { get; set; }

        /// <summary>
        /// Example: America/New_York
        /// </summary>
        /// <example>America/New_York</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Example: AS51501 Khabarovsk home networks Ltd
        /// </summary>
        /// <example>AS51501 Khabarovsk home networks Ltd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        public string? Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asn")]
        public global::G.AsnResponse? Asn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        public global::G.Company? Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("carrier")]
        public global::G.Carrier? Carrier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        public global::G.PrivacyResponse? Privacy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public global::G.DomainsResponse? Domains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FullResponse" /> class.
        /// </summary>
        /// <param name="ip">
        /// Example: 66.87.125.72
        /// </param>
        /// <param name="bogon">
        /// Example: false
        /// </param>
        /// <param name="hostname">
        /// Example: ip-66-87-125-72.spfdma.spcsdns.net
        /// </param>
        /// <param name="city">
        /// Example: Springfield
        /// </param>
        /// <param name="region">
        /// Example: Massachusetts
        /// </param>
        /// <param name="country">
        /// Example: US
        /// </param>
        /// <param name="loc">
        /// Example: 42.0999,-72.5783
        /// </param>
        /// <param name="postal">
        /// Example: 01105
        /// </param>
        /// <param name="timezone">
        /// Example: America/New_York
        /// </param>
        /// <param name="org">
        /// Example: AS51501 Khabarovsk home networks Ltd
        /// </param>
        /// <param name="asn"></param>
        /// <param name="company"></param>
        /// <param name="carrier"></param>
        /// <param name="privacy"></param>
        /// <param name="domains"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FullResponse(
            string ip,
            bool? bogon,
            string? hostname,
            string? city,
            string? region,
            string? country,
            string? loc,
            string? postal,
            string? timezone,
            string? org,
            global::G.AsnResponse? asn,
            global::G.Company? company,
            global::G.Carrier? carrier,
            global::G.PrivacyResponse? privacy,
            global::G.DomainsResponse? domains)
        {
            this.Ip = ip ?? throw new global::System.ArgumentNullException(nameof(ip));
            this.Bogon = bogon;
            this.Hostname = hostname;
            this.City = city;
            this.Region = region;
            this.Country = country;
            this.Loc = loc;
            this.Postal = postal;
            this.Timezone = timezone;
            this.Org = org;
            this.Asn = asn;
            this.Company = company;
            this.Carrier = carrier;
            this.Privacy = privacy;
            this.Domains = domains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FullResponse" /> class.
        /// </summary>
        public FullResponse()
        {
        }
    }
}