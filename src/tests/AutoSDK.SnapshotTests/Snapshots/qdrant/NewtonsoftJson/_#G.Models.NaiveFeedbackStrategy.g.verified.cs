//HintName: G.Models.NaiveFeedbackStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NaiveFeedbackStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("naive", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NaiveFeedbackStrategyParams Naive { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NaiveFeedbackStrategy" /> class.
        /// </summary>
        /// <param name="naive"></param>
        public NaiveFeedbackStrategy(
            global::G.NaiveFeedbackStrategyParams naive)
        {
            this.Naive = naive ?? throw new global::System.ArgumentNullException(nameof(naive));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NaiveFeedbackStrategy" /> class.
        /// </summary>
        public NaiveFeedbackStrategy()
        {
        }
    }
}