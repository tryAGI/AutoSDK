//HintName: G.Models.AbuseResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AbuseResponse
    {
        /// <summary>
        /// Example: US, CA, Mountain View, 1600 Amphitheatre Parkway, 94043
        /// </summary>
        /// <example>US, CA, Mountain View, 1600 Amphitheatre Parkway, 94043</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }

        /// <summary>
        /// Example: US
        /// </summary>
        /// <example>US</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Example: network-abuse@google.com
        /// </summary>
        /// <example>network-abuse@google.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Example: Abuse
        /// </summary>
        /// <example>Abuse</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: 8.8.8.0/24
        /// </summary>
        /// <example>8.8.8.0/24</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("network")]
        public string? Network { get; set; }

        /// <summary>
        /// Example: +1-650-253-0000
        /// </summary>
        /// <example>+1-650-253-0000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string? Phone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AbuseResponse" /> class.
        /// </summary>
        /// <param name="address">
        /// Example: US, CA, Mountain View, 1600 Amphitheatre Parkway, 94043
        /// </param>
        /// <param name="country">
        /// Example: US
        /// </param>
        /// <param name="email">
        /// Example: network-abuse@google.com
        /// </param>
        /// <param name="name">
        /// Example: Abuse
        /// </param>
        /// <param name="network">
        /// Example: 8.8.8.0/24
        /// </param>
        /// <param name="phone">
        /// Example: +1-650-253-0000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AbuseResponse(
            string? address,
            string? country,
            string? email,
            string? name,
            string? network,
            string? phone)
        {
            this.Address = address;
            this.Country = country;
            this.Email = email;
            this.Name = name;
            this.Network = network;
            this.Phone = phone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbuseResponse" /> class.
        /// </summary>
        public AbuseResponse()
        {
        }
    }
}