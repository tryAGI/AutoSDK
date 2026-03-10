//HintName: G.Models.CreateResponseUnitTestRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateResponseUnitTestRequest
    {
        /// <summary>
        /// Metadata of a conversation this test was created from (if applicable).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_conversation_metadata")]
        public global::G.TestFromConversationMetadataInput? FromConversationMetadata { get; set; }

        /// <summary>
        /// Dynamic variables to replace in the agent config during testing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_history")]
        public global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptCommonModelInput>? ChatHistory { get; set; }

        /// <summary>
        /// Default Value: llm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// A prompt that evaluates whether the agent's response is successful. Should return True or False.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_condition")]
        public string? SuccessCondition { get; set; }

        /// <summary>
        /// Non-empty list of example responses that should be considered successful
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_examples")]
        public global::System.Collections.Generic.IList<global::G.AgentSuccessfulResponseExample>? SuccessExamples { get; set; }

        /// <summary>
        /// Non-empty list of example responses that should be considered failures
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_examples")]
        public global::System.Collections.Generic.IList<global::G.AgentFailureResponseExample>? FailureExamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The ID of the parent folder. If not provided, the test will be created at the root level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_folder_id")]
        public string? ParentFolderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseUnitTestRequest" /> class.
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
        /// <param name="name"></param>
        /// <param name="parentFolderId">
        /// The ID of the parent folder. If not provided, the test will be created at the root level.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResponseUnitTestRequest(
            string name,
            global::G.TestFromConversationMetadataInput? fromConversationMetadata,
            object? dynamicVariables,
            global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptCommonModelInput>? chatHistory,
            string? type,
            string? successCondition,
            global::System.Collections.Generic.IList<global::G.AgentSuccessfulResponseExample>? successExamples,
            global::System.Collections.Generic.IList<global::G.AgentFailureResponseExample>? failureExamples,
            string? parentFolderId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FromConversationMetadata = fromConversationMetadata;
            this.DynamicVariables = dynamicVariables;
            this.ChatHistory = chatHistory;
            this.Type = type;
            this.SuccessCondition = successCondition;
            this.SuccessExamples = successExamples;
            this.FailureExamples = failureExamples;
            this.ParentFolderId = parentFolderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseUnitTestRequest" /> class.
        /// </summary>
        public CreateResponseUnitTestRequest()
        {
        }
    }
}