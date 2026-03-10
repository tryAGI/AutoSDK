//HintName: G.Models.GetResponseUnitTestResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetResponseUnitTestResponseModel
    {
        /// <summary>
        /// Metadata of a conversation this test was created from (if applicable).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("from_conversation_metadata")]
        public global::G.TestFromConversationMetadataOutput? FromConversationMetadata { get; set; }

        /// <summary>
        /// Dynamic variables to replace in the agent config during testing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat_history")]
        public global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptCommonModelOutput>? ChatHistory { get; set; }

        /// <summary>
        /// Default Value: llm
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// A prompt that evaluates whether the agent's response is successful. Should return True or False.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success_condition")]
        public string? SuccessCondition { get; set; }

        /// <summary>
        /// Non-empty list of example responses that should be considered successful
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success_examples")]
        public global::System.Collections.Generic.IList<global::G.AgentSuccessfulResponseExample>? SuccessExamples { get; set; }

        /// <summary>
        /// Non-empty list of example responses that should be considered failures
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failure_examples")]
        public global::System.Collections.Generic.IList<global::G.AgentFailureResponseExample>? FailureExamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetResponseUnitTestResponseModel" /> class.
        /// </summary>
        /// <param name="fromConversationMetadata">
        /// Metadata of a conversation this test was created from (if applicable).
        /// </param>
        /// <param name="dynamicVariables">
        /// Dynamic variables to replace in the agent config during testing
        /// </param>
        /// <param name="chatHistory"></param>
        /// <param name="type">
        /// Default Value: llm
        /// </param>
        /// <param name="successCondition">
        /// A prompt that evaluates whether the agent's response is successful. Should return True or False.
        /// </param>
        /// <param name="successExamples">
        /// Non-empty list of example responses that should be considered successful
        /// </param>
        /// <param name="failureExamples">
        /// Non-empty list of example responses that should be considered failures
        /// </param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public GetResponseUnitTestResponseModel(
            string id,
            string name,
            global::G.TestFromConversationMetadataOutput? fromConversationMetadata,
            object? dynamicVariables,
            global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptCommonModelOutput>? chatHistory,
            string? type,
            string? successCondition,
            global::System.Collections.Generic.IList<global::G.AgentSuccessfulResponseExample>? successExamples,
            global::System.Collections.Generic.IList<global::G.AgentFailureResponseExample>? failureExamples)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FromConversationMetadata = fromConversationMetadata;
            this.DynamicVariables = dynamicVariables;
            this.ChatHistory = chatHistory;
            this.Type = type;
            this.SuccessCondition = successCondition;
            this.SuccessExamples = successExamples;
            this.FailureExamples = failureExamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetResponseUnitTestResponseModel" /> class.
        /// </summary>
        public GetResponseUnitTestResponseModel()
        {
        }
    }
}