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
        [global::System.Text.Json.Serialization.JsonPropertyName("netblock")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Netblock { get; set; }

        /// <summary>
        /// Example: AKAMAI
        /// </summary>
        /// <example>AKAMAI</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Example: Akamai Technologies, Inc.
        /// </summary>
        /// <example>Akamai Technologies, Inc.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: US
        /// </summary>
        /// <example>US</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Country { get; set; }

        /// <summary>
        /// Example: 256
        /// </summary>
        /// <example>256</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Example: ALLOCATION
        /// </summary>
        /// <example>ALLOCATION</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Example: quadranet.com
        /// </summary>
        /// <example>quadranet.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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