//HintName: G.Models.GetToolCallUnitTestResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolCallUnitTestResponseModel
    {
        /// <summary>
        /// Metadata of a conversation this test was created from (if applicable).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_conversation_metadata")]
        public global::G.TestFromConversationMetadataOutput? FromConversationMetadata { get; set; }

        /// <summary>
        /// Dynamic variables to replace in the agent config during testing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_history")]
        public global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptCommonModelOutput>? ChatHistory { get; set; }

        /// <summary>
        /// Default Value: tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// How to evaluate the agent's tool call (if any). If empty, the tool call is not evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_parameters")]
        public global::G.UnitTestToolCallEvaluationModelOutput? ToolCallParameters { get; set; }

        /// <summary>
        /// If set to True this test will pass if any tool call returned by the LLM matches the criteria. Otherwise it will fail if more than one tool is returned by the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_any_tool_matches")]
        public bool? CheckAnyToolMatches { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolCallUnitTestResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="fromConversationMetadata">
        /// Metadata of a conversation this test was created from (if applicable).
        /// </param>
        /// <param name="dynamicVariables">
        /// Dynamic variables to replace in the agent config during testing
        /// </param>
        /// <param name="chatHistory"></param>
        /// <param name="type">
        /// Default Value: tool
        /// </param>
        /// <param name="toolCallParameters">
        /// How to evaluate the agent's tool call (if any). If empty, the tool call is not evaluated.
        /// </param>
        /// <param name="checkAnyToolMatches">
        /// If set to True this test will pass if any tool call returned by the LLM matches the criteria. Otherwise it will fail if more than one tool is returned by the agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolCallUnitTestResponseModel(
            string id,
            string name,
            global::G.TestFromConversationMetadataOutput? fromConversationMetadata,
            object? dynamicVariables,
            global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptCommonModelOutput>? chatHistory,
            string? type,
            global::G.UnitTestToolCallEvaluationModelOutput? toolCallParameters,
            bool? checkAnyToolMatches)
        {
            this.FromConversationMetadata = fromConversationMetadata;
            this.DynamicVariables = dynamicVariables;
            this.ChatHistory = chatHistory;
            this.Type = type;
            this.ToolCallParameters = toolCallParameters;
            this.CheckAnyToolMatches = checkAnyToolMatches;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolCallUnitTestResponseModel" /> class.
        /// </summary>
        public GetToolCallUnitTestResponseModel()
        {
        }
    }
}