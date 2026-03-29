//HintName: G.Models.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authScheme")]
        public global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolkitSlug", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolkitSlug { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("val", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1Val Val { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1" /> class.
        /// </summary>
        /// <param name="toolkitSlug"></param>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
        public PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1(
            string toolkitSlug,
            global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1Val val,
            global::G.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.ToolkitSlug = toolkitSlug ?? throw new global::System.ArgumentNullException(nameof(toolkitSlug));
            this.Val = val ?? throw new global::System.ArgumentNullException(nameof(val));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1()
        {
        }
    }
}