//HintName: G.Models.PendingOptimization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PendingOptimization
    {
        /// <summary>
        /// Name of the optimizer that scheduled this optimization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optimizer", Required = global::Newtonsoft.Json.Required.Always)]
        public string Optimizer { get; set; } = default!;

        /// <summary>
        /// Segments that will be optimized.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OptimizationSegmentInfo> Segments { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingOptimization" /> class.
        /// </summary>
        /// <param name="optimizer">
        /// Name of the optimizer that scheduled this optimization.
        /// </param>
        /// <param name="segments">
        /// Segments that will be optimized.
        /// </param>
        public PendingOptimization(
            string optimizer,
            global::System.Collections.Generic.IList<global::G.OptimizationSegmentInfo> segments)
        {
            this.Optimizer = optimizer ?? throw new global::System.ArgumentNullException(nameof(optimizer));
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingOptimization" /> class.
        /// </summary>
        public PendingOptimization()
        {
        }
    }
}