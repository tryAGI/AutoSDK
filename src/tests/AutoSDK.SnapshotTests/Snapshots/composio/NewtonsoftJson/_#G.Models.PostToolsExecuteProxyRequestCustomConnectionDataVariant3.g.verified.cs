//HintName: G.Models.PostToolsExecuteProxyRequestCustomConnectionDataVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolsExecuteProxyRequestCustomConnectionDataVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        public global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant3AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolkitSlug", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolkitSlug { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant3Val Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteProxyRequestCustomConnectionDataVariant3" /> class.
        /// </summary>
        /// <param name="toolkitSlug"></param>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public PostToolsExecuteProxyRequestCustomConnectionDataVariant3(
            string toolkitSlug,
            global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant3Val val,
            global::G.PostToolsExecuteProxyRequestCustomConnectionDataVariant3AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.ToolkitSlug = toolkitSlug ?? throw new global::System.ArgumentNullException(nameof(toolkitSlug));
            this.Val = val ?? throw new global::System.ArgumentNullException(nameof(val));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteProxyRequestCustomConnectionDataVariant3" /> class.
        /// </summary>
        public PostToolsExecuteProxyRequestCustomConnectionDataVariant3()
        {
        }
    }
}