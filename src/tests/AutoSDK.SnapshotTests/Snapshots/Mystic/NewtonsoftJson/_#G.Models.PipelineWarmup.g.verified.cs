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
        [global::Newtonsoft.Json.JsonProperty("minimum_nodes", Required = global::Newtonsoft.Json.Required.Always)]
        public int MinimumNodes { get; set; } = default!;

        /// <summary>
        /// Default Value: 300
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineWarmup" /> class.
        /// </summary>
        /// <param name="minimumNodes"></param>
        /// <param name="duration">
        /// Default Value: 300
        /// </param>
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