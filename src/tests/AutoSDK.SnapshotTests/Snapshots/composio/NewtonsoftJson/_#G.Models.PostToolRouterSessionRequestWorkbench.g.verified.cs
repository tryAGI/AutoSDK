//HintName: G.Models.PostToolRouterSessionRequestWorkbench.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for workbench behavior<br/>
    /// Default Value: {"enable":true,"enable_proxy_execution":true}
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestWorkbench
    {
        /// <summary>
        /// Set to false to disable the workbench entirely. When disabled, no code execution tools are available in the session.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("enable")]
        public bool? Enable { get; set; }

        /// <summary>
        /// Whether proxy execution is enabled. When enabled, workbench can call URLs and APIs directly.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("enable_proxy_execution")]
        public bool? EnableProxyExecution { get; set; }

        /// <summary>
        /// Character threshold for automatic offloading. When workbench response exceeds this threshold, it will be automatically offloaded. Default is picked automatically based on the response size.<br/>
        /// Example: 20000
        /// </summary>
        /// <example>20000</example>
        [global::Newtonsoft.Json.JsonProperty("auto_offload_threshold")]
        public double? AutoOffloadThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestWorkbench" /> class.
        /// </summary>
        /// <param name="enable">
        /// Set to false to disable the workbench entirely. When disabled, no code execution tools are available in the session.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="enableProxyExecution">
        /// Whether proxy execution is enabled. When enabled, workbench can call URLs and APIs directly.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="autoOffloadThreshold">
        /// Character threshold for automatic offloading. When workbench response exceeds this threshold, it will be automatically offloaded. Default is picked automatically based on the response size.<br/>
        /// Example: 20000
        /// </param>
        public PostToolRouterSessionRequestWorkbench(
            bool? enable,
            bool? enableProxyExecution,
            double? autoOffloadThreshold)
        {
            this.Enable = enable;
            this.EnableProxyExecution = enableProxyExecution;
            this.AutoOffloadThreshold = autoOffloadThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestWorkbench" /> class.
        /// </summary>
        public PostToolRouterSessionRequestWorkbench()
        {
        }
    }
}