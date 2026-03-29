//HintName: G.Models.AssistantClientMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantClientMessage
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
    public static class AssistantClientMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantClientMessage value)
        {
            return value switch
            {
                AssistantClientMessage.AssistantStarted => "assistant.started",
                AssistantClientMessage.ConversationUpdate => "conversation-update",
                AssistantClientMessage.FunctionCall => "function-call",
                AssistantClientMessage.FunctionCallResult => "function-call-result",
                AssistantClientMessage.Hang => "hang",
                AssistantClientMessage.LanguageChanged => "language-changed",
                AssistantClientMessage.Metadata => "metadata",
                AssistantClientMessage.ModelOutput => "model-output",
                AssistantClientMessage.SpeechUpdate => "speech-update",
                AssistantClientMessage.StatusUpdate => "status-update",
                AssistantClientMessage.ToolCalls => "tool-calls",
                AssistantClientMessage.ToolCallsResult => "tool-calls-result",
                AssistantClientMessage.ToolCompleted => "tool.completed",
                AssistantClientMessage.Transcript => "transcript",
                AssistantClientMessage.TransferUpdate => "transfer-update",
                AssistantClientMessage.UserInterrupted => "user-interrupted",
                AssistantClientMessage.VoiceInput => "voice-input",
                AssistantClientMessage.WorkflowNodeStarted => "workflow.node.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantClientMessage? ToEnum(string value)
        {
            return value switch
            {
                "assistant.started" => AssistantClientMessage.AssistantStarted,
                "conversation-update" => AssistantClientMessage.ConversationUpdate,
                "function-call" => AssistantClientMessage.FunctionCall,
                "function-call-result" => AssistantClientMessage.FunctionCallResult,
                "hang" => AssistantClientMessage.Hang,
                "language-changed" => AssistantClientMessage.LanguageChanged,
                "metadata" => AssistantClientMessage.Metadata,
                "model-output" => AssistantClientMessage.ModelOutput,
                "speech-update" => AssistantClientMessage.SpeechUpdate,
                "status-update" => AssistantClientMessage.StatusUpdate,
                "tool-calls" => AssistantClientMessage.ToolCalls,
                "tool-calls-result" => AssistantClientMessage.ToolCallsResult,
                "tool.completed" => AssistantClientMessage.ToolCompleted,
                "transcript" => AssistantClientMessage.Transcript,
                "transfer-update" => AssistantClientMessage.TransferUpdate,
                "user-interrupted" => AssistantClientMessage.UserInterrupted,
                "voice-input" => AssistantClientMessage.VoiceInput,
                "workflow.node.started" => AssistantClientMessage.WorkflowNodeStarted,
                _ => null,
            };
        }
    }
}