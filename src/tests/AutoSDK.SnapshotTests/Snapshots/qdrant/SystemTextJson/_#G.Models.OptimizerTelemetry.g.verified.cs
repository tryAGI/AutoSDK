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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OptimizersStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OptimizersStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optimizations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OperationDurationStatistics Optimizations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log")]
        public global::System.Collections.Generic.IList<global::G.TrackerTelemetry>? Log { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizerTelemetry" /> class.
        /// </summary>
        /// <param name="status">
        /// Current state of the collection
        /// </param>
        /// <param name="optimizations"></param>
        /// <param name="log"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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