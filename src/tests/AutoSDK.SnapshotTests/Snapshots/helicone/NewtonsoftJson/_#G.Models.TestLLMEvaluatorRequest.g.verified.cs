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
        [global::Newtonsoft.Json.JsonProperty("evaluatorName", Required = global::Newtonsoft.Json.Required.Always)]
        public string EvaluatorName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("testInput", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TestInput TestInput { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluatorConfig", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EvaluatorConfig EvaluatorConfig { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLLMEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="evaluatorName"></param>
        /// <param name="testInput"></param>
        /// <param name="evaluatorConfig"></param>
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