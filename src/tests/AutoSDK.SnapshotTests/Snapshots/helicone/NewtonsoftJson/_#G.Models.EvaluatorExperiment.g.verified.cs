//HintName: G.Models.EvaluatorExperiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorExperiment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExperimentName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExperimentCreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExperimentId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorExperiment" /> class.
        /// </summary>
        /// <param name="experimentName"></param>
        /// <param name="experimentCreatedAt"></param>
        /// <param name="experimentId"></param>
        public EvaluatorExperiment(
            string experimentName,
            string experimentCreatedAt,
            string experimentId)
        {
            this.ExperimentName = experimentName ?? throw new global::System.ArgumentNullException(nameof(experimentName));
            this.ExperimentCreatedAt = experimentCreatedAt ?? throw new global::System.ArgumentNullException(nameof(experimentCreatedAt));
            this.ExperimentId = experimentId ?? throw new global::System.ArgumentNullException(nameof(experimentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorExperiment" /> class.
        /// </summary>
        public EvaluatorExperiment()
        {
        }
    }
}