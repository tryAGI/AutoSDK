//HintName: G.Models.GetToolRouterSessionBySessionIdResponseConfigWorkbench.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Workbench configuration<br/>
    /// Default Value: {"enable":true,"proxy_execution_enabled":true}
    /// </summary>
    public sealed partial class GetToolRouterSessionBySessionIdResponseConfigWorkbench
    {
        /// <summary>
        /// Whether the workbench (code execution sandbox) is enabled. When false, COMPOSIO_REMOTE_WORKBENCH and COMPOSIO_REMOTE_BASH_TOOL are not exposed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        public bool? Enable { get; set; }

        /// <summary>
        /// Whether proxy execution is enabled in the workbench
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_execution_enabled")]
        public bool? ProxyExecutionEnabled { get; set; }

        /// <summary>
        /// Character threshold after which tool execution response are saved to a file in workbench. Default is 20k.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_offload_threshold")]
        public double? AutoOffloadThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigWorkbench" /> class.
        /// </summary>
        /// <param name="enable">
        /// Whether the workbench (code execution sandbox) is enabled. When false, COMPOSIO_REMOTE_WORKBENCH and COMPOSIO_REMOTE_BASH_TOOL are not exposed.
        /// </param>
        /// <param name="proxyExecutionEnabled">
        /// Whether proxy execution is enabled in the workbench
        /// </param>
        /// <param name="autoOffloadThreshold">
        /// Character threshold after which tool execution response are saved to a file in workbench. Default is 20k.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolRouterSessionBySessionIdResponseConfigWorkbench(
            bool? enable,
            bool? proxyExecutionEnabled,
            double? autoOffloadThreshold)
        {
            this.Enable = enable;
            this.ProxyExecutionEnabled = proxyExecutionEnabled;
            this.AutoOffloadThreshold = autoOffloadThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigWorkbench" /> class.
        /// </summary>
        public GetToolRouterSessionBySessionIdResponseConfigWorkbench()
        {
        }
    }
}