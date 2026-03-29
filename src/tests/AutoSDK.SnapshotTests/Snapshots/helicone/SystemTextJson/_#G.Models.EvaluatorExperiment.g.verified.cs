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
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExperimentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExperimentCreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExperimentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorExperiment" /> class.
        /// </summary>
        /// <param name="experimentName"></param>
        /// <param name="experimentCreatedAt"></param>
        /// <param name="experimentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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