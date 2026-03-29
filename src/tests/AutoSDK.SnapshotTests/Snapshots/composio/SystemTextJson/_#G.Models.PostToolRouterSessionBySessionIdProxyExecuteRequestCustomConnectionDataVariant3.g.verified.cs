//HintName: G.Models.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthSchemeJsonConverter))]
        public global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkitSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolkitSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3Val Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3" /> class.
        /// </summary>
        /// <param name="toolkitSlug"></param>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3(
            string toolkitSlug,
            global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3Val val,
            global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.ToolkitSlug = toolkitSlug ?? throw new global::System.ArgumentNullException(nameof(toolkitSlug));
            this.Val = val ?? throw new global::System.ArgumentNullException(nameof(val));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3()
        {
        }
    }
}