//HintName: G.Models.ConversationHistoryTranscriptOtherToolsResultCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryTranscriptOtherToolsResultCommonModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResultValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_has_been_called")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ToolHasBeenCalled { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_latency_secs")]
        public double? ToolLatencySecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        public string? ErrorType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_error_message")]
        public string? RawErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variable_updates")]
        public global::System.Collections.Generic.IList<global::G.DynamicVariableUpdateCommonModel>? DynamicVariableUpdates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::G.ConversationHistoryTranscriptOtherToolsResultCommonModelType2? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptOtherToolsResultCommonModel" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="toolName"></param>
        /// <param name="resultValue"></param>
        /// <param name="isError"></param>
        /// <param name="toolHasBeenCalled"></param>
        /// <param name="toolLatencySecs">
        /// Default Value: 0
        /// </param>
        /// <param name="errorType"></param>
        /// <param name="rawErrorMessage"></param>
        /// <param name="dynamicVariableUpdates"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationHistoryTranscriptOtherToolsResultCommonModel(
            string requestId,
            string toolName,
            string resultValue,
            bool isError,
            bool toolHasBeenCalled,
            double? toolLatencySecs,
            string? errorType,
            string? rawErrorMessage,
            global::System.Collections.Generic.IList<global::G.DynamicVariableUpdateCommonModel>? dynamicVariableUpdates,
            global::G.ConversationHistoryTranscriptOtherToolsResultCommonModelType2? type)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ResultValue = resultValue ?? throw new global::System.ArgumentNullException(nameof(resultValue));
            this.IsError = isError;
            this.ToolHasBeenCalled = toolHasBeenCalled;
            this.ToolLatencySecs = toolLatencySecs;
            this.ErrorType = errorType;
            this.RawErrorMessage = rawErrorMessage;
            this.DynamicVariableUpdates = dynamicVariableUpdates;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptOtherToolsResultCommonModel" /> class.
        /// </summary>
        public ConversationHistoryTranscriptOtherToolsResultCommonModel()
        {
        }
    }
}