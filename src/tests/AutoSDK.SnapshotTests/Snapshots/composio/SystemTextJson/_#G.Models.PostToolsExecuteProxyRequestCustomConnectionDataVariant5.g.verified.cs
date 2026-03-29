//HintName: G.Models.PostToolsExecuteProxyRequestCustomConnectionDataVariant5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolsExecuteProxyRequestCustomConnectionDataVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant5AuthSchemeJsonConverter))]
        public global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant5AuthScheme AuthScheme { get; set; }

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
        public required global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant5Val Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteProxyRequestCustomConnectionDataVariant5" /> class.
        /// </summary>
        /// <param name="toolkitSlug"></param>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolsExecuteProxyRequestCustomConnectionDataVariant5(
            string toolkitSlug,
            global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant5Val val,
            global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant5AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.ToolkitSlug = toolkitSlug ?? throw new global::System.ArgumentNullException(nameof(toolkitSlug));
            this.Val = val ?? throw new global::System.ArgumentNullException(nameof(val));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteProxyRequestCustomConnectionDataVariant5" /> class.
        /// </summary>
        public PostToolsExecuteProxyRequestCustomConnectionDataVariant5()
        {
        }
    }
}