//HintName: G.Models.CreateAssistantDTOServerMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAssistantDTOServerMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.started")]
        AssistantStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.delete.failed")]
        CallDeleteFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call.deleted")]
        CallDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat.created")]
        ChatCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat.deleted")]
        ChatDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversation-update")]
        ConversationUpdate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="end-of-call-report")]
        EndOfCallReport,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function-call")]
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="handoff-destination-request")]
        HandoffDestinationRequest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hang")]
        Hang,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="language-change-detected")]
        LanguageChangeDetected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="language-changed")]
        LanguageChanged,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="model-output")]
        ModelOutput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phone-call-control")]
        PhoneCallControl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session.created")]
        SessionCreated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session.deleted")]
        SessionDeleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session.updated")]
        SessionUpdated,
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
        [global::System.Runtime.Serialization.EnumMember(Value="transcript")]
        Transcript,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcript-final")]
        TranscriptFinal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transfer-destination-request")]
        TransferDestinationRequest,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAssistantDTOServerMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssistantDTOServerMessage value)
        {
            return value switch
            {
                CreateAssistantDTOServerMessage.AssistantStarted => "assistant.started",
                CreateAssistantDTOServerMessage.CallDeleteFailed => "call.delete.failed",
                CreateAssistantDTOServerMessage.CallDeleted => "call.deleted",
                CreateAssistantDTOServerMessage.ChatCreated => "chat.created",
                CreateAssistantDTOServerMessage.ChatDeleted => "chat.deleted",
                CreateAssistantDTOServerMessage.ConversationUpdate => "conversation-update",
                CreateAssistantDTOServerMessage.EndOfCallReport => "end-of-call-report",
                CreateAssistantDTOServerMessage.FunctionCall => "function-call",
                CreateAssistantDTOServerMessage.HandoffDestinationRequest => "handoff-destination-request",
                CreateAssistantDTOServerMessage.Hang => "hang",
                CreateAssistantDTOServerMessage.LanguageChangeDetected => "language-change-detected",
                CreateAssistantDTOServerMessage.LanguageChanged => "language-changed",
                CreateAssistantDTOServerMessage.ModelOutput => "model-output",
                CreateAssistantDTOServerMessage.PhoneCallControl => "phone-call-control",
                CreateAssistantDTOServerMessage.SessionCreated => "session.created",
                CreateAssistantDTOServerMessage.SessionDeleted => "session.deleted",
                CreateAssistantDTOServerMessage.SessionUpdated => "session.updated",
                CreateAssistantDTOServerMessage.SpeechUpdate => "speech-update",
                CreateAssistantDTOServerMessage.StatusUpdate => "status-update",
                CreateAssistantDTOServerMessage.ToolCalls => "tool-calls",
                CreateAssistantDTOServerMessage.Transcript => "transcript",
                CreateAssistantDTOServerMessage.TranscriptFinal => "transcript-final",
                CreateAssistantDTOServerMessage.TransferDestinationRequest => "transfer-destination-request",
                CreateAssistantDTOServerMessage.TransferUpdate => "transfer-update",
                CreateAssistantDTOServerMessage.UserInterrupted => "user-interrupted",
                CreateAssistantDTOServerMessage.VoiceInput => "voice-input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssistantDTOServerMessage? ToEnum(string value)
        {
            return value switch
            {
                "assistant.started" => CreateAssistantDTOServerMessage.AssistantStarted,
                "call.delete.failed" => CreateAssistantDTOServerMessage.CallDeleteFailed,
                "call.deleted" => CreateAssistantDTOServerMessage.CallDeleted,
                "chat.created" => CreateAssistantDTOServerMessage.ChatCreated,
                "chat.deleted" => CreateAssistantDTOServerMessage.ChatDeleted,
                "conversation-update" => CreateAssistantDTOServerMessage.ConversationUpdate,
                "end-of-call-report" => CreateAssistantDTOServerMessage.EndOfCallReport,
                "function-call" => CreateAssistantDTOServerMessage.FunctionCall,
                "handoff-destination-request" => CreateAssistantDTOServerMessage.HandoffDestinationRequest,
                "hang" => CreateAssistantDTOServerMessage.Hang,
                "language-change-detected" => CreateAssistantDTOServerMessage.LanguageChangeDetected,
                "language-changed" => CreateAssistantDTOServerMessage.LanguageChanged,
                "model-output" => CreateAssistantDTOServerMessage.ModelOutput,
                "phone-call-control" => CreateAssistantDTOServerMessage.PhoneCallControl,
                "session.created" => CreateAssistantDTOServerMessage.SessionCreated,
                "session.deleted" => CreateAssistantDTOServerMessage.SessionDeleted,
                "session.updated" => CreateAssistantDTOServerMessage.SessionUpdated,
                "speech-update" => CreateAssistantDTOServerMessage.SpeechUpdate,
                "status-update" => CreateAssistantDTOServerMessage.StatusUpdate,
                "tool-calls" => CreateAssistantDTOServerMessage.ToolCalls,
                "transcript" => CreateAssistantDTOServerMessage.Transcript,
                "transcript-final" => CreateAssistantDTOServerMessage.TranscriptFinal,
                "transfer-destination-request" => CreateAssistantDTOServerMessage.TransferDestinationRequest,
                "transfer-update" => CreateAssistantDTOServerMessage.TransferUpdate,
                "user-interrupted" => CreateAssistantDTOServerMessage.UserInterrupted,
                "voice-input" => CreateAssistantDTOServerMessage.VoiceInput,
                _ => null,
            };
        }
    }
}