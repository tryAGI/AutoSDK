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
        [global::Newtonsoft.Json.JsonProperty("uuid", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Uuid { get; set; } = default!;

        /// <summary>
        /// Name of the optimizer that performed this optimization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optimizer", Required = global::Newtonsoft.Json.Required.Always)]
        public string Optimizer { get; set; } = default!;

        /// <summary>
        /// Represents the current state of the optimizer being tracked
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TrackerStatus Status { get; set; } = default!;

        /// <summary>
        /// Segments being optimized.<br/>
        /// After the optimization is complete, these segments will be replaced by the new optimized segment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OptimizationSegmentInfo> Segments { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("progress", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProgressTree Progress { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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