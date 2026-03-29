//HintName: G.Models.ExperimentScoresHypothesis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentScoresHypothesis
    {
        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scores", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.Score2> Scores { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("runsCount", Required = global::Newtonsoft.Json.Required.Always)]
        public double RunsCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentScoresHypothesis" /> class.
        /// </summary>
        /// <param name="scores">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="runsCount"></param>
        public ExperimentScoresHypothesis(
            global::System.Collections.Generic.Dictionary<string, global::G.Score2> scores,
            double runsCount)
        {
            this.Scores = scores ?? throw new global::System.ArgumentNullException(nameof(scores));
            this.RunsCount = runsCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentScoresHypothesis" /> class.
        /// </summary>
        public ExperimentScoresHypothesis()
        {
        }
    }
}