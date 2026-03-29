//HintName: G.Models.AssistantOverridesClientMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantOverridesClientMessage
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