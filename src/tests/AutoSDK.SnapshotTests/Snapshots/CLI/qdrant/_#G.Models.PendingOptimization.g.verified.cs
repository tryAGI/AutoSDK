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
        [global::System.Text.Json.Serialization.JsonPropertyName("optimizer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Optimizer { get; set; }

        /// <summary>
        /// Segments that will be optimized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OptimizationSegmentInfo> Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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