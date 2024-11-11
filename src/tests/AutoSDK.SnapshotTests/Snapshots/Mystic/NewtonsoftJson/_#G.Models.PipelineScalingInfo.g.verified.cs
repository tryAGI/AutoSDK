//HintName: G.Models.PipelineScalingInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class PipelineScalingInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_replicas", Required = global::Newtonsoft.Json.Required.Always)]
        public int CurrentReplicas { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("desired_replicas", Required = global::Newtonsoft.Json.Required.Always)]
        public int DesiredReplicas { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_pipeline_states", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, int> CurrentPipelineStates { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineScalingInfo" /> class.
        /// </summary>
        /// <param name="currentReplicas"></param>
        /// <param name="desiredReplicas"></param>
        /// <param name="currentPipelineStates"></param>
        public PipelineScalingInfo(
            int currentReplicas,
            int desiredReplicas,
            global::System.Collections.Generic.Dictionary<string, int> currentPipelineStates)
        {
            this.CurrentReplicas = currentReplicas;
            this.DesiredReplicas = desiredReplicas;
            this.CurrentPipelineStates = currentPipelineStates ?? throw new global::System.ArgumentNullException(nameof(currentPipelineStates));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineScalingInfo" /> class.
        /// </summary>
        public PipelineScalingInfo()
        {
        }
    }
}