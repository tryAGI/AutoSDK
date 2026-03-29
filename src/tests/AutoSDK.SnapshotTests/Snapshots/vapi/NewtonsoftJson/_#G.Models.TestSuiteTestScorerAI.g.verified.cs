//HintName: G.Models.TestSuiteTestScorerAI.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteTestScorerAI
    {
        /// <summary>
        /// This is the type of the scorer, which must be AI.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.TestSuiteTestScorerAIType Type { get; set; }

        /// <summary>
        /// This is the rubric used by the AI scorer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rubric", Required = global::Newtonsoft.Json.Required.Always)]
        public string Rubric { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestScorerAI" /> class.
        /// </summary>
        /// <param name="rubric">
        /// This is the rubric used by the AI scorer.
        /// </param>
        /// <param name="type">
        /// This is the type of the scorer, which must be AI.
        /// </param>
        public TestSuiteTestScorerAI(
            string rubric,
            global::G.TestSuiteTestScorerAIType type)
        {
            this.Type = type;
            this.Rubric = rubric ?? throw new global::System.ArgumentNullException(nameof(rubric));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteTestScorerAI" /> class.
        /// </summary>
        public TestSuiteTestScorerAI()
        {
        }
    }
}