//HintName: G.Models.TestCaseDefinitionInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestCaseDefinitionInput
    {
        /// <summary>
        /// Name of the test case definition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Response engine for test cases. Custom LLM is not supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RetellResponseEngineJsonConverter))]
        public global::G.RetellResponseEngine? ResponseEngine { get; set; }

        /// <summary>
        /// User prompt to simulate in the test case
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_prompt")]
        public string? UserPrompt { get; set; }

        /// <summary>
        /// Array of metric names to evaluate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::System.Collections.Generic.IList<string>? Metrics { get; set; }

        /// <summary>
        /// Dynamic variables to inject into the response engine
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? DynamicVariables { get; set; }

        /// <summary>
        /// Mock tool calls for testing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_mocks")]
        public global::System.Collections.Generic.IList<global::G.ToolMock>? ToolMocks { get; set; }

        /// <summary>
        /// Available LLM models for agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LLMModelJsonConverter))]
        public global::G.LLMModel? LlmModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseDefinitionInput" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the test case definition
        /// </param>
        /// <param name="responseEngine">
        /// Response engine for test cases. Custom LLM is not supported.
        /// </param>
        /// <param name="userPrompt">
        /// User prompt to simulate in the test case
        /// </param>
        /// <param name="metrics">
        /// Array of metric names to evaluate
        /// </param>
        /// <param name="dynamicVariables">
        /// Dynamic variables to inject into the response engine
        /// </param>
        /// <param name="toolMocks">
        /// Mock tool calls for testing
        /// </param>
        /// <param name="llmModel">
        /// Available LLM models for agents.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCaseDefinitionInput(
            string? name,
            global::G.RetellResponseEngine? responseEngine,
            string? userPrompt,
            global::System.Collections.Generic.IList<string>? metrics,
            global::System.Collections.Generic.Dictionary<string, string>? dynamicVariables,
            global::System.Collections.Generic.IList<global::G.ToolMock>? toolMocks,
            global::G.LLMModel? llmModel)
        {
            this.Name = name;
            this.ResponseEngine = responseEngine;
            this.UserPrompt = userPrompt;
            this.Metrics = metrics;
            this.DynamicVariables = dynamicVariables;
            this.ToolMocks = toolMocks;
            this.LlmModel = llmModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseDefinitionInput" /> class.
        /// </summary>
        public TestCaseDefinitionInput()
        {
        }
    }
}