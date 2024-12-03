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
        [global::System.Text.Json.Serialization.JsonPropertyName("netblock")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Netblock { get; set; }

        /// <summary>
        /// Example: COMCAST6NET
        /// </summary>
        /// <example>COMCAST6NET</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Example: Comcast Cable Communications, LLC
        /// </summary>
        /// <example>Comcast Cable Communications, LLC</example>
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
        /// Example: 20282409603651670423947251286016
        /// </summary>
        /// <example>20282409603651670423947251286016</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Example: ASSIGNMENT
        /// </summary>
        /// <example>ASSIGNMENT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Example: comcast.com
        /// </summary>
        /// <example>comcast.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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