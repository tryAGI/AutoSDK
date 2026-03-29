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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExternalProxyConfigTypeJsonConverter))]
        public global::G.ExternalProxyConfigType Type { get; set; }

        /// <summary>
        /// Server URL for external proxy. Required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Server { get; set; }

        /// <summary>
        /// Domain pattern for which this proxy should be used. If omitted, defaults to all domains. Optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domainPattern")]
        public string? DomainPattern { get; set; }

        /// <summary>
        /// Username for external proxy authentication. Optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Password for external proxy authentication. Optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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