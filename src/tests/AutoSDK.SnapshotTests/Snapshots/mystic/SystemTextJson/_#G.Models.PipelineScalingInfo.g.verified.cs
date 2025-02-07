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
        [global::System.Text.Json.Serialization.JsonPropertyName("current_replicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CurrentReplicas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desired_replicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DesiredReplicas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_pipeline_states")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> CurrentPipelineStates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineScalingInfo" /> class.
        /// </summary>
        /// <param name="currentReplicas"></param>
        /// <param name="desiredReplicas"></param>
        /// <param name="currentPipelineStates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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