//HintName: G.Models.NoneProxyConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NoneProxyConfig
    {
        /// <summary>
        /// Type of proxy. Always 'none' for this config.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.NoneProxyConfigTypeJsonConverter))]
        public global::G.NoneProxyConfigType Type { get; set; }

        /// <summary>
        /// Domain pattern for which this proxy should be used. If omitted, defaults to all domains. Optional.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("domainPattern")]
        public string? DomainPattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NoneProxyConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of proxy. Always 'none' for this config.
        /// </param>
        /// <param name="domainPattern">
        /// Domain pattern for which this proxy should be used. If omitted, defaults to all domains. Optional.
        /// </param>
        public NoneProxyConfig(
            global::G.NoneProxyConfigType type,
            string? domainPattern)
        {
            this.Type = type;
            this.DomainPattern = domainPattern;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoneProxyConfig" /> class.
        /// </summary>
        public NoneProxyConfig()
        {
        }
    }
}