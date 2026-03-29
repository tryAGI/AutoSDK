//HintName: G.Models.PostAuthConfigsRequestAuthConfigVariant2.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostAuthConfigsRequestAuthConfigVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostAuthConfigsRequestAuthConfigVariant2TypeJsonConverter))]
        public global::G.PostAuthConfigsRequestAuthConfigVariant2Type Type { get; set; }

        /// <summary>
        /// The name of the integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostAuthConfigsRequestAuthConfigVariant2AuthSchemeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostAuthConfigsRequestAuthConfigVariant2AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::G.PostAuthConfigsRequestAuthConfigVariant2Credentials? Credentials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_config")]
        public global::G.PostAuthConfigsRequestAuthConfigVariant2ProxyConfig? ProxyConfig { get; set; }

        /// <summary>
        /// Use tool_access_config instead. This field will be deprecated in the future.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrict_to_following_tools")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? RestrictToFollowingTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_access_config")]
        public global::G.PostAuthConfigsRequestAuthConfigVariant2ToolAccessConfig? ToolAccessConfig { get; set; }

        /// <summary>
        /// [EXPERIMENTAL] Shared credentials that will be inherited by all connected accounts using this auth config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_credentials")]
        public global::System.Collections.Generic.Dictionary<string, object?>? SharedCredentials { get; set; }

        /// <summary>
        /// Whether this auth config is enabled for tool router
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled_for_tool_router")]
        public bool? IsEnabledForToolRouter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsRequestAuthConfigVariant2" /> class.
        /// </summary>
        /// <param name="authScheme"></param>
        /// <param name="type"></param>
        /// <param name="name">
        /// The name of the integration
        /// </param>
        /// <param name="credentials">
        /// Default Value: {}
        /// </param>
        /// <param name="proxyConfig"></param>
        /// <param name="toolAccessConfig"></param>
        /// <param name="sharedCredentials">
        /// [EXPERIMENTAL] Shared credentials that will be inherited by all connected accounts using this auth config
        /// </param>
        /// <param name="isEnabledForToolRouter">
        /// Whether this auth config is enabled for tool router
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostAuthConfigsRequestAuthConfigVariant2(
            global::G.PostAuthConfigsRequestAuthConfigVariant2AuthScheme authScheme,
            global::G.PostAuthConfigsRequestAuthConfigVariant2Type type,
            string? name,
            global::G.PostAuthConfigsRequestAuthConfigVariant2Credentials? credentials,
            global::G.PostAuthConfigsRequestAuthConfigVariant2ProxyConfig? proxyConfig,
            global::G.PostAuthConfigsRequestAuthConfigVariant2ToolAccessConfig? toolAccessConfig,
            global::System.Collections.Generic.Dictionary<string, object?>? sharedCredentials,
            bool? isEnabledForToolRouter)
        {
            this.Type = type;
            this.Name = name;
            this.AuthScheme = authScheme;
            this.Credentials = credentials;
            this.ProxyConfig = proxyConfig;
            this.ToolAccessConfig = toolAccessConfig;
            this.SharedCredentials = sharedCredentials;
            this.IsEnabledForToolRouter = isEnabledForToolRouter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsRequestAuthConfigVariant2" /> class.
        /// </summary>
        public PostAuthConfigsRequestAuthConfigVariant2()
        {
        }
    }
}