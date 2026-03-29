//HintName: G.Models.OptimizerTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OptimizerTelemetry
    {
        /// <summary>
        /// Current state of the collection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OptimizersStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optimizations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OperationDurationStatistics Optimizations { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("log")]
        public global::System.Collections.Generic.IList<global::G.TrackerTelemetry>? Log { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizerTelemetry" /> class.
        /// </summary>
        /// <param name="status">
        /// Current state of the collection
        /// </param>
        /// <param name="optimizations"></param>
        /// <param name="log"></param>
        public OptimizerTelemetry(
            global::G.OptimizersStatus status,
            global::G.OperationDurationStatistics optimizations,
            global::System.Collections.Generic.IList<global::G.TrackerTelemetry>? log)
        {
            this.Status = status;
            this.Optimizations = optimizations ?? throw new global::System.ArgumentNullException(nameof(optimizations));
            this.Log = log;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizerTelemetry" /> class.
        /// </summary>
        public OptimizerTelemetry()
        {
        }
    }
}