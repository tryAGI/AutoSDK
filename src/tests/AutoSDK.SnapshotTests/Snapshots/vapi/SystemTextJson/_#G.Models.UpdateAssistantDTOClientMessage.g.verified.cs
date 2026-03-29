//HintName: G.Models.UpdateAssistantDTOClientMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateAssistantDTOClientMessage
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