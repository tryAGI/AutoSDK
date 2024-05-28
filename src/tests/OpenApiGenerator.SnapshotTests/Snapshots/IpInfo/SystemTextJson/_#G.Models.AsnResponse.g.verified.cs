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
        /// <br/>Example: AS10507
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Asn { get; set; }

        /// <summary>
        /// <br/>Example: Sprint Personal Communications Systems
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// <br/>Example: US
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// <br/>Example: 1997-02-14
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allocated")]
        public string? Allocated { get; set; }

        /// <summary>
        /// <br/>Example: arin
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry")]
        public string? Registry { get; set; }

        /// <summary>
        /// <br/>Example: sprint.net
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// <br/>Example: 71224576
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_ips")]
        public int NumIps { get; set; }

        /// <summary>
        /// <br/>Example: 66.87.125.0/24
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        public string? Route { get; set; }

        /// <summary>
        /// <br/>Example: isp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefixes")]
        public global::System.Collections.Generic.IList<Prefix>? Prefixes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefixes6")]
        public global::System.Collections.Generic.IList<Prefix6>? Prefixes6 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("peers")]
        public global::System.Collections.Generic.IList<string?>? Peers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstreams")]
        public global::System.Collections.Generic.IList<string?>? Upstreams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downstreams")]
        public global::System.Collections.Generic.IList<string?>? Downstreams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}