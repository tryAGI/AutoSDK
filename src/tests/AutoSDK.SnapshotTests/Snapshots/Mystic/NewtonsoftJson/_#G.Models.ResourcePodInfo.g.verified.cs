//HintName: G.Models.ResourcePodInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class ResourcePodInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pod_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string PodName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pod_ip", Required = global::Newtonsoft.Json.Required.Always)]
        public string PodIp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeName { get; set; } = default!;

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PipelineState State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_run")]
        public string? CurrentRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcePodInfo" /> class.
        /// </summary>
        /// <param name="podName"></param>
        /// <param name="podIp"></param>
        /// <param name="nodeName"></param>
        /// <param name="state">
        /// An enumeration.
        /// </param>
        /// <param name="currentRun"></param>
        public ResourcePodInfo(
            string podName,
            string podIp,
            string nodeName,
            global::G.PipelineState state,
            string? currentRun)
        {
            this.PodName = podName ?? throw new global::System.ArgumentNullException(nameof(podName));
            this.PodIp = podIp ?? throw new global::System.ArgumentNullException(nameof(podIp));
            this.NodeName = nodeName ?? throw new global::System.ArgumentNullException(nameof(nodeName));
            this.State = state;
            this.CurrentRun = currentRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcePodInfo" /> class.
        /// </summary>
        public ResourcePodInfo()
        {
        }
    }
}