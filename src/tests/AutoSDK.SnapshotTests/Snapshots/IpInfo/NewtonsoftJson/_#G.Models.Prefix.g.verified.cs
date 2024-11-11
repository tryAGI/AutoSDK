//HintName: G.Models.Prefix.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Prefix
    {
        /// <summary>
        /// Example: 104.69.216.0/22
        /// </summary>
        /// <example>104.69.216.0/22</example>
        [global::Newtonsoft.Json.JsonProperty("netblock", Required = global::Newtonsoft.Json.Required.Always)]
        public string Netblock { get; set; } = default!;

        /// <summary>
        /// Example: AKAMAI
        /// </summary>
        /// <example>AKAMAI</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Example: Akamai Technologies, Inc.
        /// </summary>
        /// <example>Akamai Technologies, Inc.</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: US
        /// </summary>
        /// <example>US</example>
        [global::Newtonsoft.Json.JsonProperty("country", Required = global::Newtonsoft.Json.Required.Always)]
        public string Country { get; set; } = default!;

        /// <summary>
        /// Example: 256
        /// </summary>
        /// <example>256</example>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Example: ALLOCATION
        /// </summary>
        /// <example>ALLOCATION</example>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Example: quadranet.com
        /// </summary>
        /// <example>quadranet.com</example>
        [global::Newtonsoft.Json.JsonProperty("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prefix" /> class.
        /// </summary>
        /// <param name="netblock">
        /// Example: 104.69.216.0/22
        /// </param>
        /// <param name="id">
        /// Example: AKAMAI
        /// </param>
        /// <param name="name">
        /// Example: Akamai Technologies, Inc.
        /// </param>
        /// <param name="country">
        /// Example: US
        /// </param>
        /// <param name="size">
        /// Example: 256
        /// </param>
        /// <param name="status">
        /// Example: ALLOCATION
        /// </param>
        /// <param name="domain">
        /// Example: quadranet.com
        /// </param>
        public Prefix(
            string netblock,
            string id,
            string name,
            string country,
            string? size,
            string? status,
            string? domain)
        {
            this.Netblock = netblock ?? throw new global::System.ArgumentNullException(nameof(netblock));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Country = country ?? throw new global::System.ArgumentNullException(nameof(country));
            this.Size = size;
            this.Status = status;
            this.Domain = domain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prefix" /> class.
        /// </summary>
        public Prefix()
        {
        }
    }
}