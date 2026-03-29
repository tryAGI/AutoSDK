//HintName: G.Models.UpdateAssistantDTOClientMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateAssistantDTOClientMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.started")]
        AssistantStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation-update")]
        ConversationUpdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function-call")]
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function-call-result")]
        FunctionCallResult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hang")]
        Hang,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="language-changed")]
        LanguageChanged,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="metadata")]
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="model-output")]
        ModelOutput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="speech-update")]
        SpeechUpdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="status-update")]
        StatusUpdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool-calls")]
        ToolCalls,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool-calls-result")]
        ToolCallsResult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool.completed")]
        ToolCompleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcript")]
        Transcript,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transfer-update")]
        TransferUpdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user-interrupted")]
        UserInterrupted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice-input")]
        VoiceInput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflow.node.started")]
        WorkflowNodeStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAssistantDTOClientMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssistantDTOClientMessage value)
        {
            return value switch
            {
                UpdateAssistantDTOClientMessage.AssistantStarted => "assistant.started",
                UpdateAssistantDTOClientMessage.ConversationUpdate => "conversation-update",
                UpdateAssistantDTOClientMessage.FunctionCall => "function-call",
                UpdateAssistantDTOClientMessage.FunctionCallResult => "function-call-result",
                UpdateAssistantDTOClientMessage.Hang => "hang",
                UpdateAssistantDTOClientMessage.LanguageChanged => "language-changed",
                UpdateAssistantDTOClientMessage.Metadata => "metadata",
                UpdateAssistantDTOClientMessage.ModelOutput => "model-output",
                UpdateAssistantDTOClientMessage.SpeechUpdate => "speech-update",
                UpdateAssistantDTOClientMessage.StatusUpdate => "status-update",
                UpdateAssistantDTOClientMessage.ToolCalls => "tool-calls",
                UpdateAssistantDTOClientMessage.ToolCallsResult => "tool-calls-result",
                UpdateAssistantDTOClientMessage.ToolCompleted => "tool.completed",
                UpdateAssistantDTOClientMessage.Transcript => "transcript",
                UpdateAssistantDTOClientMessage.TransferUpdate => "transfer-update",
                UpdateAssistantDTOClientMessage.UserInterrupted => "user-interrupted",
                UpdateAssistantDTOClientMessage.VoiceInput => "voice-input",
                UpdateAssistantDTOClientMessage.WorkflowNodeStarted => "workflow.node.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssistantDTOClientMessage? ToEnum(string value)
        {
            return value switch
            {
                "assistant.started" => UpdateAssistantDTOClientMessage.AssistantStarted,
                "conversation-update" => UpdateAssistantDTOClientMessage.ConversationUpdate,
                "function-call" => UpdateAssistantDTOClientMessage.FunctionCall,
                "function-call-result" => UpdateAssistantDTOClientMessage.FunctionCallResult,
                "hang" => UpdateAssistantDTOClientMessage.Hang,
                "language-changed" => UpdateAssistantDTOClientMessage.LanguageChanged,
                "metadata" => UpdateAssistantDTOClientMessage.Metadata,
                "model-output" => UpdateAssistantDTOClientMessage.ModelOutput,
                "speech-update" => UpdateAssistantDTOClientMessage.SpeechUpdate,
                "status-update" => UpdateAssistantDTOClientMessage.StatusUpdate,
                "tool-calls" => UpdateAssistantDTOClientMessage.ToolCalls,
                "tool-calls-result" => UpdateAssistantDTOClientMessage.ToolCallsResult,
                "tool.completed" => UpdateAssistantDTOClientMessage.ToolCompleted,
                "transcript" => UpdateAssistantDTOClientMessage.Transcript,
                "transfer-update" => UpdateAssistantDTOClientMessage.TransferUpdate,
                "user-interrupted" => UpdateAssistantDTOClientMessage.UserInterrupted,
                "voice-input" => UpdateAssistantDTOClientMessage.VoiceInput,
                "workflow.node.started" => UpdateAssistantDTOClientMessage.WorkflowNodeStarted,
                _ => null,
            };
        }
    }
}