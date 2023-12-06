//HintName: G.Models.Prefix6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class Prefix6
    {
        /// <summary>
        /// Example: 2601::/20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("netblock")]
        public required string Netblock { get; set; }

        /// <summary>
        /// Example: COMCAST6NET
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public required string Id { get; set; }

        /// <summary>
        /// Example: Comcast Cable Communications, LLC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public required string Name { get; set; }

        /// <summary>
        /// Example: US
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public required string Country { get; set; }

        /// <summary>
        /// Example: 20282409603651670423947251286016
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Example: ASSIGNMENT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Example: comcast.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}