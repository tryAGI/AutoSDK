//HintName: G.Models.TestLLMEvaluatorRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestLLMEvaluatorRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluatorName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvaluatorName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testInput")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TestInput TestInput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluatorConfig")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EvaluatorConfig EvaluatorConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLLMEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="evaluatorName"></param>
        /// <param name="testInput"></param>
        /// <param name="evaluatorConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestLLMEvaluatorRequest(
            string evaluatorName,
            global::G.TestInput testInput,
            global::G.EvaluatorConfig evaluatorConfig)
        {
            this.EvaluatorName = evaluatorName ?? throw new global::System.ArgumentNullException(nameof(evaluatorName));
            this.TestInput = testInput ?? throw new global::System.ArgumentNullException(nameof(testInput));
            this.EvaluatorConfig = evaluatorConfig ?? throw new global::System.ArgumentNullException(nameof(evaluatorConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLLMEvaluatorRequest" /> class.
        /// </summary>
        public TestLLMEvaluatorRequest()
        {
        }
    }
}