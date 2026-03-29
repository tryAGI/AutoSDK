//HintName: G.Models.Eval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Eval
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("averageScore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AverageScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minScore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MinScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxScore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.EvalOverTimeItem> OverTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("averageOverTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.EvalAverageOverTimeItem> AverageOverTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Eval" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="averageScore"></param>
        /// <param name="minScore"></param>
        /// <param name="maxScore"></param>
        /// <param name="count"></param>
        /// <param name="overTime"></param>
        /// <param name="averageOverTime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Eval(
            string name,
            double averageScore,
            double minScore,
            double maxScore,
            double count,
            global::System.Collections.Generic.IList<global::G.EvalOverTimeItem> overTime,
            global::System.Collections.Generic.IList<global::G.EvalAverageOverTimeItem> averageOverTime)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AverageScore = averageScore;
            this.MinScore = minScore;
            this.MaxScore = maxScore;
            this.Count = count;
            this.OverTime = overTime ?? throw new global::System.ArgumentNullException(nameof(overTime));
            this.AverageOverTime = averageOverTime ?? throw new global::System.ArgumentNullException(nameof(averageOverTime));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Eval" /> class.
        /// </summary>
        public Eval()
        {
        }
    }
}