//HintName: G.Models.CreateAssistantDTOClientMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAssistantDTOClientMessage
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
    public static class CreateAssistantDTOClientMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssistantDTOClientMessage value)
        {
            return value switch
            {
                CreateAssistantDTOClientMessage.AssistantStarted => "assistant.started",
                CreateAssistantDTOClientMessage.ConversationUpdate => "conversation-update",
                CreateAssistantDTOClientMessage.FunctionCall => "function-call",
                CreateAssistantDTOClientMessage.FunctionCallResult => "function-call-result",
                CreateAssistantDTOClientMessage.Hang => "hang",
                CreateAssistantDTOClientMessage.LanguageChanged => "language-changed",
                CreateAssistantDTOClientMessage.Metadata => "metadata",
                CreateAssistantDTOClientMessage.ModelOutput => "model-output",
                CreateAssistantDTOClientMessage.SpeechUpdate => "speech-update",
                CreateAssistantDTOClientMessage.StatusUpdate => "status-update",
                CreateAssistantDTOClientMessage.ToolCalls => "tool-calls",
                CreateAssistantDTOClientMessage.ToolCallsResult => "tool-calls-result",
                CreateAssistantDTOClientMessage.ToolCompleted => "tool.completed",
                CreateAssistantDTOClientMessage.Transcript => "transcript",
                CreateAssistantDTOClientMessage.TransferUpdate => "transfer-update",
                CreateAssistantDTOClientMessage.UserInterrupted => "user-interrupted",
                CreateAssistantDTOClientMessage.VoiceInput => "voice-input",
                CreateAssistantDTOClientMessage.WorkflowNodeStarted => "workflow.node.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssistantDTOClientMessage? ToEnum(string value)
        {
            return value switch
            {
                "assistant.started" => CreateAssistantDTOClientMessage.AssistantStarted,
                "conversation-update" => CreateAssistantDTOClientMessage.ConversationUpdate,
                "function-call" => CreateAssistantDTOClientMessage.FunctionCall,
                "function-call-result" => CreateAssistantDTOClientMessage.FunctionCallResult,
                "hang" => CreateAssistantDTOClientMessage.Hang,
                "language-changed" => CreateAssistantDTOClientMessage.LanguageChanged,
                "metadata" => CreateAssistantDTOClientMessage.Metadata,
                "model-output" => CreateAssistantDTOClientMessage.ModelOutput,
                "speech-update" => CreateAssistantDTOClientMessage.SpeechUpdate,
                "status-update" => CreateAssistantDTOClientMessage.StatusUpdate,
                "tool-calls" => CreateAssistantDTOClientMessage.ToolCalls,
                "tool-calls-result" => CreateAssistantDTOClientMessage.ToolCallsResult,
                "tool.completed" => CreateAssistantDTOClientMessage.ToolCompleted,
                "transcript" => CreateAssistantDTOClientMessage.Transcript,
                "transfer-update" => CreateAssistantDTOClientMessage.TransferUpdate,
                "user-interrupted" => CreateAssistantDTOClientMessage.UserInterrupted,
                "voice-input" => CreateAssistantDTOClientMessage.VoiceInput,
                "workflow.node.started" => CreateAssistantDTOClientMessage.WorkflowNodeStarted,
                _ => null,
            };
        }
    }
}