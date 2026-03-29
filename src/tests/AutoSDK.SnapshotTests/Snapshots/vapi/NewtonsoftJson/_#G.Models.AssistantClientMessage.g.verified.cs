//HintName: G.Models.AssistantClientMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantClientMessage
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