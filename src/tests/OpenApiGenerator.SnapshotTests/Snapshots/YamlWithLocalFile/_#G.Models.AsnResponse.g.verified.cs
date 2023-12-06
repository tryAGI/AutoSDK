//HintName: G.Models.AsnResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class AsnResponse
    {
        /// <summary>
        /// Example: AS10507
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asn")]
        public required string Asn { get; set; }

        /// <summary>
        /// Example: Sprint Personal Communications Systems
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public required string Name { get; set; }

        /// <summary>
        /// Example: US
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Example: 1997-02-14
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allocated")]
        public string? Allocated { get; set; }

        /// <summary>
        /// Example: arin
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry")]
        public string? Registry { get; set; }

        /// <summary>
        /// Example: sprint.net
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public required string Domain { get; set; }

        /// <summary>
        /// Example: 71224576
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_ips")]
        public int NumIps { get; set; }

        /// <summary>
        /// Example: 66.87.125.0/24
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        public string? Route { get; set; }

        /// <summary>
        /// Example: isp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public required AsnResponseType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefixes")]
        public Prefix?[]? Prefixes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefixes6")]
        public Prefix6?[]? Prefixes6 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peers")]
        public string?[]? Peers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstreams")]
        public string?[]? Upstreams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downstreams")]
        public string?[]? Downstreams { get; set; }

        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}