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
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.Score2> Scores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RunsCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentScoresHypothesis" /> class.
        /// </summary>
        /// <param name="scores">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="runsCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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