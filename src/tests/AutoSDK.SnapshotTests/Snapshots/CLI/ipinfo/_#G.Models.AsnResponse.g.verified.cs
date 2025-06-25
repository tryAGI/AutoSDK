//HintName: G.Models.AsnResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AsnResponse
    {
        /// <summary>
        /// Example: AS10507
        /// </summary>
        /// <example>AS10507</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("asn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Asn { get; set; }

        /// <summary>
        /// Example: Sprint Personal Communications Systems
        /// </summary>
        /// <example>Sprint Personal Communications Systems</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: US
        /// </summary>
        /// <example>US</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Example: 1997-02-14
        /// </summary>
        /// <example>1997-02-14</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allocated")]
        public string? Allocated { get; set; }

        /// <summary>
        /// Example: arin
        /// </summary>
        /// <example>arin</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry")]
        public string? Registry { get; set; }

        /// <summary>
        /// Example: sprint.net
        /// </summary>
        /// <example>sprint.net</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// Example: 71224576
        /// </summary>
        /// <example>71224576</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_ips")]
        public int? NumIps { get; set; }

        /// <summary>
        /// Example: 66.87.125.0/24
        /// </summary>
        /// <example>66.87.125.0/24</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        public string? Route { get; set; }

        /// <summary>
        /// Example: isp
        /// </summary>
        /// <example>isp</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AsnResponseTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AsnResponseType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefixes")]
        public global::System.Collections.Generic.IList<global::G.Prefix>? Prefixes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefixes6")]
        public global::System.Collections.Generic.IList<global::G.Prefix6>? Prefixes6 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peers")]
        public global::System.Collections.Generic.IList<string>? Peers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstreams")]
        public global::System.Collections.Generic.IList<string>? Upstreams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downstreams")]
        public global::System.Collections.Generic.IList<string>? Downstreams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsnResponse" /> class.
        /// </summary>
        /// <param name="asn">
        /// Example: AS10507
        /// </param>
        /// <param name="name">
        /// Example: Sprint Personal Communications Systems
        /// </param>
        /// <param name="country">
        /// Example: US
        /// </param>
        /// <param name="allocated">
        /// Example: 1997-02-14
        /// </param>
        /// <param name="registry">
        /// Example: arin
        /// </param>
        /// <param name="domain">
        /// Example: sprint.net
        /// </param>
        /// <param name="numIps">
        /// Example: 71224576
        /// </param>
        /// <param name="route">
        /// Example: 66.87.125.0/24
        /// </param>
        /// <param name="type">
        /// Example: isp
        /// </param>
        /// <param name="prefixes"></param>
        /// <param name="prefixes6"></param>
        /// <param name="peers"></param>
        /// <param name="upstreams"></param>
        /// <param name="downstreams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsnResponse(
            string asn,
            string name,
            string domain,
            global::G.AsnResponseType type,
            string? country,
            string? allocated,
            string? registry,
            int? numIps,
            string? route,
            global::System.Collections.Generic.IList<global::G.Prefix>? prefixes,
            global::System.Collections.Generic.IList<global::G.Prefix6>? prefixes6,
            global::System.Collections.Generic.IList<string>? peers,
            global::System.Collections.Generic.IList<string>? upstreams,
            global::System.Collections.Generic.IList<string>? downstreams)
        {
            this.Asn = asn ?? throw new global::System.ArgumentNullException(nameof(asn));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Type = type;
            this.Country = country;
            this.Allocated = allocated;
            this.Registry = registry;
            this.NumIps = numIps;
            this.Route = route;
            this.Prefixes = prefixes;
            this.Prefixes6 = prefixes6;
            this.Peers = peers;
            this.Upstreams = upstreams;
            this.Downstreams = downstreams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsnResponse" /> class.
        /// </summary>
        public AsnResponse()
        {
        }
    }
}