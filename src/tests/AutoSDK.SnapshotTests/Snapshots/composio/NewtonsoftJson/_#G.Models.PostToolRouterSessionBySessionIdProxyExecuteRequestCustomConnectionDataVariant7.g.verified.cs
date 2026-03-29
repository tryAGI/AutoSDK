//HintName: G.Models.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        public global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolkitSlug", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolkitSlug { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7Val Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7" /> class.
        /// </summary>
        /// <param name="toolkitSlug"></param>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7(
            string toolkitSlug,
            global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7Val val,
            global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.ToolkitSlug = toolkitSlug ?? throw new global::System.ArgumentNullException(nameof(toolkitSlug));
            this.Val = val ?? throw new global::System.ArgumentNullException(nameof(val));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7()
        {
        }
    }
}