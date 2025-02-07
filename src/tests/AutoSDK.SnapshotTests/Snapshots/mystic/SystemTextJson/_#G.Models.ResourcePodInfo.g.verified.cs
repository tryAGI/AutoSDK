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
        [global::System.Text.Json.Serialization.JsonPropertyName("pod_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PodName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pod_ip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PodIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeName { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PipelineStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PipelineState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_run")]
        public string? CurrentRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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