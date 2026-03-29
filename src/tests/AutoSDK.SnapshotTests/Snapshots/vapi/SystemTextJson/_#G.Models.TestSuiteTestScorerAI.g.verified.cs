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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TestSuiteTestScorerAITypeJsonConverter))]
        public global::G.TestSuiteTestScorerAIType Type { get; set; }

        /// <summary>
        /// This is the rubric used by the AI scorer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rubric")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Rubric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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