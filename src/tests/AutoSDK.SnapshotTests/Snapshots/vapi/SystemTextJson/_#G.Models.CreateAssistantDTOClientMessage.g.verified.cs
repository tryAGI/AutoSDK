//HintName: G.Models.CreateAssistantDTOClientMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAssistantDTOClientMessage
    {
        /// <summary>
        /// 
        /// </summary>
        AssistantStarted,
        /// <summary>
        /// 
        /// </summary>
        ConversationUpdate,
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        FunctionCallResult,
        /// <summary>
        /// 
        /// </summary>
        Hang,
        /// <summary>
        /// 
        /// </summary>
        LanguageChanged,
        /// <summary>
        /// 
        /// </summary>
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        ModelOutput,
        /// <summary>
        /// 
        /// </summary>
        SpeechUpdate,
        /// <summary>
        /// 
        /// </summary>
        StatusUpdate,
        /// <summary>
        /// 
        /// </summary>
        ToolCalls,
        /// <summary>
        /// 
        /// </summary>
        ToolCallsResult,
        /// <summary>
        /// 
        /// </summary>
        ToolCompleted,
        /// <summary>
        /// 
        /// </summary>
        Transcript,
        /// <summary>
        /// 
        /// </summary>
        TransferUpdate,
        /// <summary>
        /// 
        /// </summary>
        UserInterrupted,
        /// <summary>
        /// 
        /// </summary>
        VoiceInput,
        /// <summary>
        /// 
        /// </summary>
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