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
        [global::Newtonsoft.Json.JsonProperty("asn", Required = global::Newtonsoft.Json.Required.Always)]
        public string Asn { get; set; } = default!;

        /// <summary>
        /// <br/>Example: Sprint Personal Communications Systems
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// <br/>Example: US
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("country")]
        public string? Country { get; set; }

        /// <summary>
        /// <br/>Example: 1997-02-14
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allocated")]
        public string? Allocated { get; set; }

        /// <summary>
        /// <br/>Example: arin
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("registry")]
        public string? Registry { get; set; }

        /// <summary>
        /// <br/>Example: sprint.net
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("domain", Required = global::Newtonsoft.Json.Required.Always)]
        public string Domain { get; set; } = default!;

        /// <summary>
        /// <br/>Example: 71224576
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_ips")]
        public int NumIps { get; set; }

        /// <summary>
        /// <br/>Example: 66.87.125.0/24
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("route")]
        public string? Route { get; set; }

        /// <summary>
        /// <br/>Example: isp
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public AsnResponseType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefixes")]
        public global::System.Collections.Generic.IList<Prefix>? Prefixes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prefixes6")]
        public global::System.Collections.Generic.IList<Prefix6>? Prefixes6 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("peers")]
        public global::System.Collections.Generic.IList<string?>? Peers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("upstreams")]
        public global::System.Collections.Generic.IList<string?>? Upstreams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("downstreams")]
        public global::System.Collections.Generic.IList<string?>? Downstreams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}