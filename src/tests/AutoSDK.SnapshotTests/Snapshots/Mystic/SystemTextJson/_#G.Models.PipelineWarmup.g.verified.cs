//HintName: G.Models.PipelineWarmup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class PipelineWarmup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum_nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinimumNodes { get; set; }

        /// <summary>
        /// Default Value: 300
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineWarmup" /> class.
        /// </summary>
        /// <param name="minimumNodes"></param>
        /// <param name="duration">
        /// Default Value: 300
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PipelineWarmup(
            int minimumNodes,
            int? duration)
        {
            this.MinimumNodes = minimumNodes;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineWarmup" /> class.
        /// </summary>
        public PipelineWarmup()
        {
        }
    }
}