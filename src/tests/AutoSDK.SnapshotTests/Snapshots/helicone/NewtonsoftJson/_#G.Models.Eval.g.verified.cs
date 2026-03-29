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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("averageScore", Required = global::Newtonsoft.Json.Required.Always)]
        public double AverageScore { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minScore", Required = global::Newtonsoft.Json.Required.Always)]
        public double MinScore { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxScore", Required = global::Newtonsoft.Json.Required.Always)]
        public double MaxScore { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public double Count { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overTime", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EvalOverTimeItem> OverTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("averageOverTime", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EvalAverageOverTimeItem> AverageOverTime { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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