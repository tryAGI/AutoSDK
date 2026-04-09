//HintName: G.Models.TestSuiteRunScorerAI.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteRunScorerAI
    {
        /// <summary>
        /// This is the type of the scorer, which must be AI.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TestSuiteRunScorerAITypeJsonConverter))]
        public global::G.TestSuiteRunScorerAIType Type { get; set; }

        /// <summary>
        /// This is the result of the test suite.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TestSuiteRunScorerAIResultJsonConverter))]
        public global::G.TestSuiteRunScorerAIResult Result { get; set; } = default!;

        /// <summary>
        /// This is the reasoning provided by the AI scorer.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning", Required = global::Newtonsoft.Json.Required.Always)]
        public string Reasoning { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="TestSuiteRunScorerAI" /> class.
        /// </summary>
        /// <param name="result">
        /// This is the result of the test suite.
        /// </param>
        /// <param name="reasoning">
        /// This is the reasoning provided by the AI scorer.
        /// </param>
        /// <param name="rubric">
        /// This is the rubric used by the AI scorer.
        /// </param>
        /// <param name="type">
        /// This is the type of the scorer, which must be AI.
        /// </param>
        public TestSuiteRunScorerAI(
            global::G.TestSuiteRunScorerAIResult result,
            string reasoning,
            string rubric,
            global::G.TestSuiteRunScorerAIType type)
        {
            this.Type = type;
            this.Result = result;
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
            this.Rubric = rubric ?? throw new global::System.ArgumentNullException(nameof(rubric));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunScorerAI" /> class.
        /// </summary>
        public TestSuiteRunScorerAI()
        {
        }
    }
}