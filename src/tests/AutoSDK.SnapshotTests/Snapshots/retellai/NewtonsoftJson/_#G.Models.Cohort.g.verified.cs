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
        [global::Newtonsoft.Json.JsonProperty("cohort_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CohortId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Call filter criteria to create QA.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cohort_filter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CohortFilter CohortFilter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sampling_percentage", Required = global::Newtonsoft.Json.Required.Always)]
        public double SamplingPercentage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sampling_weekly_max")]
        public double? SamplingWeeklyMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scoring_criteria", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ScoringCriteria ScoringCriteria { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("successful_criteria", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CohortSuccessfulCriteria SuccessfulCriteria { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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