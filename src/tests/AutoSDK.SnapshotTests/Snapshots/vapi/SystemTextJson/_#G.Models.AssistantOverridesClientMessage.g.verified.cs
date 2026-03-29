//HintName: G.Models.AssistantOverridesClientMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantOverridesClientMessage
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
    public static class AssistantOverridesClientMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantOverridesClientMessage value)
        {
            return value switch
            {
                AssistantOverridesClientMessage.AssistantStarted => "assistant.started",
                AssistantOverridesClientMessage.ConversationUpdate => "conversation-update",
                AssistantOverridesClientMessage.FunctionCall => "function-call",
                AssistantOverridesClientMessage.FunctionCallResult => "function-call-result",
                AssistantOverridesClientMessage.Hang => "hang",
                AssistantOverridesClientMessage.LanguageChanged => "language-changed",
                AssistantOverridesClientMessage.Metadata => "metadata",
                AssistantOverridesClientMessage.ModelOutput => "model-output",
                AssistantOverridesClientMessage.SpeechUpdate => "speech-update",
                AssistantOverridesClientMessage.StatusUpdate => "status-update",
                AssistantOverridesClientMessage.ToolCalls => "tool-calls",
                AssistantOverridesClientMessage.ToolCallsResult => "tool-calls-result",
                AssistantOverridesClientMessage.ToolCompleted => "tool.completed",
                AssistantOverridesClientMessage.Transcript => "transcript",
                AssistantOverridesClientMessage.TransferUpdate => "transfer-update",
                AssistantOverridesClientMessage.UserInterrupted => "user-interrupted",
                AssistantOverridesClientMessage.VoiceInput => "voice-input",
                AssistantOverridesClientMessage.WorkflowNodeStarted => "workflow.node.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantOverridesClientMessage? ToEnum(string value)
        {
            return value switch
            {
                "assistant.started" => AssistantOverridesClientMessage.AssistantStarted,
                "conversation-update" => AssistantOverridesClientMessage.ConversationUpdate,
                "function-call" => AssistantOverridesClientMessage.FunctionCall,
                "function-call-result" => AssistantOverridesClientMessage.FunctionCallResult,
                "hang" => AssistantOverridesClientMessage.Hang,
                "language-changed" => AssistantOverridesClientMessage.LanguageChanged,
                "metadata" => AssistantOverridesClientMessage.Metadata,
                "model-output" => AssistantOverridesClientMessage.ModelOutput,
                "speech-update" => AssistantOverridesClientMessage.SpeechUpdate,
                "status-update" => AssistantOverridesClientMessage.StatusUpdate,
                "tool-calls" => AssistantOverridesClientMessage.ToolCalls,
                "tool-calls-result" => AssistantOverridesClientMessage.ToolCallsResult,
                "tool.completed" => AssistantOverridesClientMessage.ToolCompleted,
                "transcript" => AssistantOverridesClientMessage.Transcript,
                "transfer-update" => AssistantOverridesClientMessage.TransferUpdate,
                "user-interrupted" => AssistantOverridesClientMessage.UserInterrupted,
                "voice-input" => AssistantOverridesClientMessage.VoiceInput,
                "workflow.node.started" => AssistantOverridesClientMessage.WorkflowNodeStarted,
                _ => null,
            };
        }
    }
}