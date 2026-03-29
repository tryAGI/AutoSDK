//HintName: G.Models.AssistantServerMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantServerMessage
    {
        /// <summary>
        /// 
        /// </summary>
        AssistantStarted,
        /// <summary>
        /// 
        /// </summary>
        CallDeleteFailed,
        /// <summary>
        /// 
        /// </summary>
        CallDeleted,
        /// <summary>
        /// 
        /// </summary>
        ChatCreated,
        /// <summary>
        /// 
        /// </summary>
        ChatDeleted,
        /// <summary>
        /// 
        /// </summary>
        ConversationUpdate,
        /// <summary>
        /// 
        /// </summary>
        EndOfCallReport,
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        HandoffDestinationRequest,
        /// <summary>
        /// 
        /// </summary>
        Hang,
        /// <summary>
        /// 
        /// </summary>
        LanguageChangeDetected,
        /// <summary>
        /// 
        /// </summary>
        LanguageChanged,
        /// <summary>
        /// 
        /// </summary>
        ModelOutput,
        /// <summary>
        /// 
        /// </summary>
        PhoneCallControl,
        /// <summary>
        /// 
        /// </summary>
        SessionCreated,
        /// <summary>
        /// 
        /// </summary>
        SessionDeleted,
        /// <summary>
        /// 
        /// </summary>
        SessionUpdated,
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
        Transcript,
        /// <summary>
        /// 
        /// </summary>
        TranscriptFinal,
        /// <summary>
        /// 
        /// </summary>
        TransferDestinationRequest,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantServerMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantServerMessage value)
        {
            return value switch
            {
                AssistantServerMessage.AssistantStarted => "assistant.started",
                AssistantServerMessage.CallDeleteFailed => "call.delete.failed",
                AssistantServerMessage.CallDeleted => "call.deleted",
                AssistantServerMessage.ChatCreated => "chat.created",
                AssistantServerMessage.ChatDeleted => "chat.deleted",
                AssistantServerMessage.ConversationUpdate => "conversation-update",
                AssistantServerMessage.EndOfCallReport => "end-of-call-report",
                AssistantServerMessage.FunctionCall => "function-call",
                AssistantServerMessage.HandoffDestinationRequest => "handoff-destination-request",
                AssistantServerMessage.Hang => "hang",
                AssistantServerMessage.LanguageChangeDetected => "language-change-detected",
                AssistantServerMessage.LanguageChanged => "language-changed",
                AssistantServerMessage.ModelOutput => "model-output",
                AssistantServerMessage.PhoneCallControl => "phone-call-control",
                AssistantServerMessage.SessionCreated => "session.created",
                AssistantServerMessage.SessionDeleted => "session.deleted",
                AssistantServerMessage.SessionUpdated => "session.updated",
                AssistantServerMessage.SpeechUpdate => "speech-update",
                AssistantServerMessage.StatusUpdate => "status-update",
                AssistantServerMessage.ToolCalls => "tool-calls",
                AssistantServerMessage.Transcript => "transcript",
                AssistantServerMessage.TranscriptFinal => "transcript-final",
                AssistantServerMessage.TransferDestinationRequest => "transfer-destination-request",
                AssistantServerMessage.TransferUpdate => "transfer-update",
                AssistantServerMessage.UserInterrupted => "user-interrupted",
                AssistantServerMessage.VoiceInput => "voice-input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantServerMessage? ToEnum(string value)
        {
            return value switch
            {
                "assistant.started" => AssistantServerMessage.AssistantStarted,
                "call.delete.failed" => AssistantServerMessage.CallDeleteFailed,
                "call.deleted" => AssistantServerMessage.CallDeleted,
                "chat.created" => AssistantServerMessage.ChatCreated,
                "chat.deleted" => AssistantServerMessage.ChatDeleted,
                "conversation-update" => AssistantServerMessage.ConversationUpdate,
                "end-of-call-report" => AssistantServerMessage.EndOfCallReport,
                "function-call" => AssistantServerMessage.FunctionCall,
                "handoff-destination-request" => AssistantServerMessage.HandoffDestinationRequest,
                "hang" => AssistantServerMessage.Hang,
                "language-change-detected" => AssistantServerMessage.LanguageChangeDetected,
                "language-changed" => AssistantServerMessage.LanguageChanged,
                "model-output" => AssistantServerMessage.ModelOutput,
                "phone-call-control" => AssistantServerMessage.PhoneCallControl,
                "session.created" => AssistantServerMessage.SessionCreated,
                "session.deleted" => AssistantServerMessage.SessionDeleted,
                "session.updated" => AssistantServerMessage.SessionUpdated,
                "speech-update" => AssistantServerMessage.SpeechUpdate,
                "status-update" => AssistantServerMessage.StatusUpdate,
                "tool-calls" => AssistantServerMessage.ToolCalls,
                "transcript" => AssistantServerMessage.Transcript,
                "transcript-final" => AssistantServerMessage.TranscriptFinal,
                "transfer-destination-request" => AssistantServerMessage.TransferDestinationRequest,
                "transfer-update" => AssistantServerMessage.TransferUpdate,
                "user-interrupted" => AssistantServerMessage.UserInterrupted,
                "voice-input" => AssistantServerMessage.VoiceInput,
                _ => null,
            };
        }
    }
}