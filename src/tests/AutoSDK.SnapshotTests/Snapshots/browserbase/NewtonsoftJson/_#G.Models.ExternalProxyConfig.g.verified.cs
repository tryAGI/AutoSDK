//HintName: G.Models.ExternalProxyConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExternalProxyConfig
    {
        /// <summary>
        /// Type of proxy. Always 'external' for this config.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ExternalProxyConfigTypeJsonConverter))]
        public global::G.ExternalProxyConfigType Type { get; set; }

        /// <summary>
        /// Server URL for external proxy. Required.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server", Required = global::Newtonsoft.Json.Required.Always)]
        public string Server { get; set; } = default!;

        /// <summary>
        /// Domain pattern for which this proxy should be used. If omitted, defaults to all domains. Optional.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("domainPattern")]
        public string? DomainPattern { get; set; }

        /// <summary>
        /// Username for external proxy authentication. Optional.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Password for external proxy authentication. Optional.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalProxyConfig" /> class.
        /// </summary>
        /// <param name="server">
        /// Server URL for external proxy. Required.
        /// </param>
        /// <param name="type">
        /// Type of proxy. Always 'external' for this config.
        /// </param>
        /// <param name="domainPattern">
        /// Domain pattern for which this proxy should be used. If omitted, defaults to all domains. Optional.
        /// </param>
        /// <param name="username">
        /// Username for external proxy authentication. Optional.
        /// </param>
        /// <param name="password">
        /// Password for external proxy authentication. Optional.
        /// </param>
        public ExternalProxyConfig(
            string server,
            global::G.ExternalProxyConfigType type,
            string? domainPattern,
            string? username,
            string? password)
        {
            this.Type = type;
            this.Server = server ?? throw new global::System.ArgumentNullException(nameof(server));
            this.DomainPattern = domainPattern;
            this.Username = username;
            this.Password = password;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalProxyConfig" /> class.
        /// </summary>
        public ExternalProxyConfig()
        {
        }
    }
}