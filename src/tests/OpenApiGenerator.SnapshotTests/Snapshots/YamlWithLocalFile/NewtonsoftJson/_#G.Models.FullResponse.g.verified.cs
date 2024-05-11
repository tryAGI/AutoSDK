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
        /// <br/>Example: 66.87.125.72
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ip", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ip { get; set; } = default!;

        /// <summary>
        /// <br/>Example: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bogon")]
        public bool Bogon { get; set; }

        /// <summary>
        /// <br/>Example: ip-66-87-125-72.spfdma.spcsdns.net
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hostname")]
        public string? Hostname { get; set; }

        /// <summary>
        /// <br/>Example: Springfield
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("city")]
        public string? City { get; set; }

        /// <summary>
        /// <br/>Example: Massachusetts
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region")]
        public string? Region { get; set; }

        /// <summary>
        /// <br/>Example: US
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("country")]
        public string? Country { get; set; }

        /// <summary>
        /// <br/>Example: 42.0999,-72.5783
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("loc")]
        public string? Loc { get; set; }

        /// <summary>
        /// <br/>Example: 01105
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("postal")]
        public string? Postal { get; set; }

        /// <summary>
        /// <br/>Example: America/New_York
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// <br/>Example: AS51501 Khabarovsk home networks Ltd
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org")]
        public string? Org { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("asn")]
        public AsnResponse? Asn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("company")]
        public Company? Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("carrier")]
        public Carrier? Carrier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privacy")]
        public PrivacyResponse? Privacy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("domains")]
        public DomainsResponse? Domains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}