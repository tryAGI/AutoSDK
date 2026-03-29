//HintName: G.Models.SimulationRunItemCounts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationRunItemCounts
    {
        /// <summary>
        /// Total number of run items
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public double Total { get; set; } = default!;

        /// <summary>
        /// Number of passed run items
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("passed", Required = global::Newtonsoft.Json.Required.Always)]
        public double Passed { get; set; } = default!;

        /// <summary>
        /// Number of failed run items
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed", Required = global::Newtonsoft.Json.Required.Always)]
        public double Failed { get; set; } = default!;

        /// <summary>
        /// Number of running/evaluating run items
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("running", Required = global::Newtonsoft.Json.Required.Always)]
        public double Running { get; set; } = default!;

        /// <summary>
        /// Number of queued run items
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queued", Required = global::Newtonsoft.Json.Required.Always)]
        public double Queued { get; set; } = default!;

        /// <summary>
        /// Number of canceled run items
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("canceled", Required = global::Newtonsoft.Json.Required.Always)]
        public double Canceled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemCounts" /> class.
        /// </summary>
        /// <param name="total">
        /// Total number of run items
        /// </param>
        /// <param name="passed">
        /// Number of passed run items
        /// </param>
        /// <param name="failed">
        /// Number of failed run items
        /// </param>
        /// <param name="running">
        /// Number of running/evaluating run items
        /// </param>
        /// <param name="queued">
        /// Number of queued run items
        /// </param>
        /// <param name="canceled">
        /// Number of canceled run items
        /// </param>
        public SimulationRunItemCounts(
            double total,
            double passed,
            double failed,
            double running,
            double queued,
            double canceled)
        {
            this.Total = total;
            this.Passed = passed;
            this.Failed = failed;
            this.Running = running;
            this.Queued = queued;
            this.Canceled = canceled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemCounts" /> class.
        /// </summary>
        public SimulationRunItemCounts()
        {
        }
    }
}