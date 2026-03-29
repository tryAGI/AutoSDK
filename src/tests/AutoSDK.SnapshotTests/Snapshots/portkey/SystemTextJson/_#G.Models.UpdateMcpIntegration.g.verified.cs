//HintName: G.Models.UpdateMcpIntegration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateMcpIntegration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Auth/config key-value pairs (e.g. headers, client credentials)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurations")]
        public global::G.UpdateMcpIntegrationConfigurations? Configurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateMcpIntegrationAuthTypeJsonConverter))]
        public global::G.UpdateMcpIntegrationAuthType? AuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateMcpIntegrationTransportJsonConverter))]
        public global::G.UpdateMcpIntegrationTransport? Transport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMcpIntegration" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="configurations">
        /// Auth/config key-value pairs (e.g. headers, client credentials)
        /// </param>
        /// <param name="url"></param>
        /// <param name="authType"></param>
        /// <param name="transport"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMcpIntegration(
            string? name,
            string? description,
            global::G.UpdateMcpIntegrationConfigurations? configurations,
            string? url,
            global::G.UpdateMcpIntegrationAuthType? authType,
            global::G.UpdateMcpIntegrationTransport? transport)
        {
            this.Name = name;
            this.Description = description;
            this.Configurations = configurations;
            this.Url = url;
            this.AuthType = authType;
            this.Transport = transport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMcpIntegration" /> class.
        /// </summary>
        public UpdateMcpIntegration()
        {
        }
    }
}