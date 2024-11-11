//HintName: G.Models.Prefix6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Prefix6
    {
        /// <summary>
        /// Example: 2601::/20
        /// </summary>
        /// <example>2601::/20</example>
        [global::Newtonsoft.Json.JsonProperty("netblock", Required = global::Newtonsoft.Json.Required.Always)]
        public string Netblock { get; set; } = default!;

        /// <summary>
        /// Example: COMCAST6NET
        /// </summary>
        /// <example>COMCAST6NET</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Example: Comcast Cable Communications, LLC
        /// </summary>
        /// <example>Comcast Cable Communications, LLC</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: US
        /// </summary>
        /// <example>US</example>
        [global::Newtonsoft.Json.JsonProperty("country", Required = global::Newtonsoft.Json.Required.Always)]
        public string Country { get; set; } = default!;

        /// <summary>
        /// Example: 20282409603651670423947251286016
        /// </summary>
        /// <example>20282409603651670423947251286016</example>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Example: ASSIGNMENT
        /// </summary>
        /// <example>ASSIGNMENT</example>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Example: comcast.com
        /// </summary>
        /// <example>comcast.com</example>
        [global::Newtonsoft.Json.JsonProperty("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Prefix6" /> class.
        /// </summary>
        /// <param name="netblock">
        /// Example: 2601::/20
        /// </param>
        /// <param name="id">
        /// Example: COMCAST6NET
        /// </param>
        /// <param name="name">
        /// Example: Comcast Cable Communications, LLC
        /// </param>
        /// <param name="country">
        /// Example: US
        /// </param>
        /// <param name="size">
        /// Example: 20282409603651670423947251286016
        /// </param>
        /// <param name="status">
        /// Example: ASSIGNMENT
        /// </param>
        /// <param name="domain">
        /// Example: comcast.com
        /// </param>
        public Prefix6(
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
        /// Initializes a new instance of the <see cref="Prefix6" /> class.
        /// </summary>
        public Prefix6()
        {
        }
    }
}