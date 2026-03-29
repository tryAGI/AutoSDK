//HintName: G.Models.EvalResultsScorerStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Stats for a single flattened score dimension (scorer_key or scorer_key.path.to.leaf).
    /// </summary>
    public sealed partial class EvalResultsScorerStats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorer_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScorerKey { get; set; }

        /// <summary>
        /// Dot-joined subpath for nested dimensions, e.g. 'passed' for token_distance.passed. None for root-level scalar scorers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Type of the leaf value: binary (bool) or continuous (number).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_type")]
        public global::G.EvalResultsScorerStatsValueType2? ValueType { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trial_count")]
        public int? TrialCount { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeric_count")]
        public int? NumericCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeric_mean")]
        public double? NumericMean { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_true_count")]
        public int? PassTrueCount { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_known_count")]
        public int? PassKnownCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_rate")]
        public double? PassRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pass_signal_coverage")]
        public double? PassSignalCoverage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResultsScorerStats" /> class.
        /// </summary>
        /// <param name="scorerKey"></param>
        /// <param name="path">
        /// Dot-joined subpath for nested dimensions, e.g. 'passed' for token_distance.passed. None for root-level scalar scorers.
        /// </param>
        /// <param name="valueType">
        /// Type of the leaf value: binary (bool) or continuous (number).
        /// </param>
        /// <param name="trialCount">
        /// Default Value: 0
        /// </param>
        /// <param name="numericCount">
        /// Default Value: 0
        /// </param>
        /// <param name="numericMean"></param>
        /// <param name="passTrueCount">
        /// Default Value: 0
        /// </param>
        /// <param name="passKnownCount">
        /// Default Value: 0
        /// </param>
        /// <param name="passRate"></param>
        /// <param name="passSignalCoverage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalResultsScorerStats(
            string scorerKey,
            string? path,
            global::G.EvalResultsScorerStatsValueType2? valueType,
            int? trialCount,
            int? numericCount,
            double? numericMean,
            int? passTrueCount,
            int? passKnownCount,
            double? passRate,
            double? passSignalCoverage)
        {
            this.ScorerKey = scorerKey ?? throw new global::System.ArgumentNullException(nameof(scorerKey));
            this.Path = path;
            this.ValueType = valueType;
            this.TrialCount = trialCount;
            this.NumericCount = numericCount;
            this.NumericMean = numericMean;
            this.PassTrueCount = passTrueCount;
            this.PassKnownCount = passKnownCount;
            this.PassRate = passRate;
            this.PassSignalCoverage = passSignalCoverage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResultsScorerStats" /> class.
        /// </summary>
        public EvalResultsScorerStats()
        {
        }
    }
}