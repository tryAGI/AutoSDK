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
        /// <br/>Example: 104.69.216.0/22
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("netblock")]
        public required string Netblock { get; set; }

        /// <summary>
        /// <br/>Example: AKAMAI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public required string Id { get; set; }

        /// <summary>
        /// <br/>Example: Akamai Technologies, Inc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public required string Name { get; set; }

        /// <summary>
        /// <br/>Example: US
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public required string Country { get; set; }

        /// <summary>
        /// <br/>Example: 256
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// <br/>Example: ALLOCATION
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// <br/>Example: quadranet.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}