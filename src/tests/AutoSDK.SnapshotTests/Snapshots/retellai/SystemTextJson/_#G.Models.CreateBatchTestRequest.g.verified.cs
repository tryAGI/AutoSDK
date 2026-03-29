//HintName: G.Models.CreateBatchTestRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBatchTestRequest
    {
        /// <summary>
        /// Array of test case definition IDs to run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_case_definition_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TestCaseDefinitionIds { get; set; }

        /// <summary>
        /// Response engine for test cases. Custom LLM is not supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RetellResponseEngineJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RetellResponseEngine ResponseEngine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchTestRequest" /> class.
        /// </summary>
        /// <param name="testCaseDefinitionIds">
        /// Array of test case definition IDs to run
        /// </param>
        /// <param name="responseEngine">
        /// Response engine for test cases. Custom LLM is not supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBatchTestRequest(
            global::System.Collections.Generic.IList<string> testCaseDefinitionIds,
            global::G.RetellResponseEngine responseEngine)
        {
            this.TestCaseDefinitionIds = testCaseDefinitionIds ?? throw new global::System.ArgumentNullException(nameof(testCaseDefinitionIds));
            this.ResponseEngine = responseEngine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchTestRequest" /> class.
        /// </summary>
        public CreateBatchTestRequest()
        {
        }
    }
}