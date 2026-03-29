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
        [global::Newtonsoft.Json.JsonProperty("test_case_definition_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> TestCaseDefinitionIds { get; set; } = default!;

        /// <summary>
        /// Response engine for test cases. Custom LLM is not supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_engine", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RetellResponseEngine ResponseEngine { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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