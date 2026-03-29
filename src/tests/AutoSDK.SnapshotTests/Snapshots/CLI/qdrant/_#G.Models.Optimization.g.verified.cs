//HintName: G.Models.Optimization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Optimization
    {
        /// <summary>
        /// Unique identifier of the optimization process.<br/>
        /// After the optimization is complete, a new segment will be created with this UUID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Uuid { get; set; }

        /// <summary>
        /// Name of the optimizer that performed this optimization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimizer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Optimizer { get; set; }

        /// <summary>
        /// Represents the current state of the optimizer being tracked
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TrackerStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TrackerStatus Status { get; set; }

        /// <summary>
        /// Segments being optimized.<br/>
        /// After the optimization is complete, these segments will be replaced by the new optimized segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OptimizationSegmentInfo> Segments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProgressTree Progress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Optimization" /> class.
        /// </summary>
        /// <param name="uuid">
        /// Unique identifier of the optimization process.<br/>
        /// After the optimization is complete, a new segment will be created with this UUID.
        /// </param>
        /// <param name="optimizer">
        /// Name of the optimizer that performed this optimization.
        /// </param>
        /// <param name="status">
        /// Represents the current state of the optimizer being tracked
        /// </param>
        /// <param name="segments">
        /// Segments being optimized.<br/>
        /// After the optimization is complete, these segments will be replaced by the new optimized segment.
        /// </param>
        /// <param name="progress"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Optimization(
            global::System.Guid uuid,
            string optimizer,
            global::G.TrackerStatus status,
            global::System.Collections.Generic.IList<global::G.OptimizationSegmentInfo> segments,
            global::G.ProgressTree progress)
        {
            this.Uuid = uuid;
            this.Optimizer = optimizer ?? throw new global::System.ArgumentNullException(nameof(optimizer));
            this.Status = status;
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
            this.Progress = progress ?? throw new global::System.ArgumentNullException(nameof(progress));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Optimization" /> class.
        /// </summary>
        public Optimization()
        {
        }
    }
}