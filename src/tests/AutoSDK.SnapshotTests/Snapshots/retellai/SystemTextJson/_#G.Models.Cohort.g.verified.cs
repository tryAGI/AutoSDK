//HintName: G.Models.Cohort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Cohort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohort_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CohortId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Call filter criteria to create QA.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cohort_filter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CohortFilter CohortFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SamplingPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_weekly_max")]
        public double? SamplingWeeklyMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoring_criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ScoringCriteria ScoringCriteria { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful_criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CohortSuccessfulCriteria SuccessfulCriteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Cohort" /> class.
        /// </summary>
        /// <param name="cohortId"></param>
        /// <param name="name"></param>
        /// <param name="cohortFilter">
        /// Call filter criteria to create QA.
        /// </param>
        /// <param name="samplingPercentage"></param>
        /// <param name="scoringCriteria"></param>
        /// <param name="successfulCriteria"></param>
        /// <param name="samplingWeeklyMax"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Cohort(
            string cohortId,
            string name,
            global::G.CohortFilter cohortFilter,
            double samplingPercentage,
            global::G.ScoringCriteria scoringCriteria,
            global::G.CohortSuccessfulCriteria successfulCriteria,
            double? samplingWeeklyMax)
        {
            this.CohortId = cohortId ?? throw new global::System.ArgumentNullException(nameof(cohortId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CohortFilter = cohortFilter ?? throw new global::System.ArgumentNullException(nameof(cohortFilter));
            this.SamplingPercentage = samplingPercentage;
            this.SamplingWeeklyMax = samplingWeeklyMax;
            this.ScoringCriteria = scoringCriteria ?? throw new global::System.ArgumentNullException(nameof(scoringCriteria));
            this.SuccessfulCriteria = successfulCriteria ?? throw new global::System.ArgumentNullException(nameof(successfulCriteria));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cohort" /> class.
        /// </summary>
        public Cohort()
        {
        }
    }
}