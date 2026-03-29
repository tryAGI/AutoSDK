//HintName: G.Models.ScoreSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Summary of a score's performance
    /// </summary>
    public sealed partial class ScoreSummary
    {
        /// <summary>
        /// Name of the score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Average score across all examples
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public double Score { get; set; } = default!;

        /// <summary>
        /// Difference in score between the current and comparison experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("diff")]
        public double? Diff { get; set; }

        /// <summary>
        /// Number of improvements in the score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("improvements", Required = global::Newtonsoft.Json.Required.Always)]
        public int Improvements { get; set; } = default!;

        /// <summary>
        /// Number of regressions in the score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("regressions", Required = global::Newtonsoft.Json.Required.Always)]
        public int Regressions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreSummary" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the score
        /// </param>
        /// <param name="score">
        /// Average score across all examples
        /// </param>
        /// <param name="improvements">
        /// Number of improvements in the score
        /// </param>
        /// <param name="regressions">
        /// Number of regressions in the score
        /// </param>
        /// <param name="diff">
        /// Difference in score between the current and comparison experiment
        /// </param>
        public ScoreSummary(
            string name,
            double score,
            int improvements,
            int regressions,
            double? diff)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Score = score;
            this.Diff = diff;
            this.Improvements = improvements;
            this.Regressions = regressions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreSummary" /> class.
        /// </summary>
        public ScoreSummary()
        {
        }
    }
}