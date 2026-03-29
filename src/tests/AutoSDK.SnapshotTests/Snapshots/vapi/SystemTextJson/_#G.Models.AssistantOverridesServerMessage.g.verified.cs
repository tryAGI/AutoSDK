//HintName: G.Models.AssistantOverridesServerMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantOverridesServerMessage
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
    public static class AssistantOverridesServerMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantOverridesServerMessage value)
        {
            return value switch
            {
                AssistantOverridesServerMessage.AssistantStarted => "assistant.started",
                AssistantOverridesServerMessage.CallDeleteFailed => "call.delete.failed",
                AssistantOverridesServerMessage.CallDeleted => "call.deleted",
                AssistantOverridesServerMessage.ChatCreated => "chat.created",
                AssistantOverridesServerMessage.ChatDeleted => "chat.deleted",
                AssistantOverridesServerMessage.ConversationUpdate => "conversation-update",
                AssistantOverridesServerMessage.EndOfCallReport => "end-of-call-report",
                AssistantOverridesServerMessage.FunctionCall => "function-call",
                AssistantOverridesServerMessage.HandoffDestinationRequest => "handoff-destination-request",
                AssistantOverridesServerMessage.Hang => "hang",
                AssistantOverridesServerMessage.LanguageChangeDetected => "language-change-detected",
                AssistantOverridesServerMessage.LanguageChanged => "language-changed",
                AssistantOverridesServerMessage.ModelOutput => "model-output",
                AssistantOverridesServerMessage.PhoneCallControl => "phone-call-control",
                AssistantOverridesServerMessage.SessionCreated => "session.created",
                AssistantOverridesServerMessage.SessionDeleted => "session.deleted",
                AssistantOverridesServerMessage.SessionUpdated => "session.updated",
                AssistantOverridesServerMessage.SpeechUpdate => "speech-update",
                AssistantOverridesServerMessage.StatusUpdate => "status-update",
                AssistantOverridesServerMessage.ToolCalls => "tool-calls",
                AssistantOverridesServerMessage.Transcript => "transcript",
                AssistantOverridesServerMessage.TranscriptFinal => "transcript-final",
                AssistantOverridesServerMessage.TransferDestinationRequest => "transfer-destination-request",
                AssistantOverridesServerMessage.TransferUpdate => "transfer-update",
                AssistantOverridesServerMessage.UserInterrupted => "user-interrupted",
                AssistantOverridesServerMessage.VoiceInput => "voice-input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantOverridesServerMessage? ToEnum(string value)
        {
            return value switch
            {
                "assistant.started" => AssistantOverridesServerMessage.AssistantStarted,
                "call.delete.failed" => AssistantOverridesServerMessage.CallDeleteFailed,
                "call.deleted" => AssistantOverridesServerMessage.CallDeleted,
                "chat.created" => AssistantOverridesServerMessage.ChatCreated,
                "chat.deleted" => AssistantOverridesServerMessage.ChatDeleted,
                "conversation-update" => AssistantOverridesServerMessage.ConversationUpdate,
                "end-of-call-report" => AssistantOverridesServerMessage.EndOfCallReport,
                "function-call" => AssistantOverridesServerMessage.FunctionCall,
                "handoff-destination-request" => AssistantOverridesServerMessage.HandoffDestinationRequest,
                "hang" => AssistantOverridesServerMessage.Hang,
                "language-change-detected" => AssistantOverridesServerMessage.LanguageChangeDetected,
                "language-changed" => AssistantOverridesServerMessage.LanguageChanged,
                "model-output" => AssistantOverridesServerMessage.ModelOutput,
                "phone-call-control" => AssistantOverridesServerMessage.PhoneCallControl,
                "session.created" => AssistantOverridesServerMessage.SessionCreated,
                "session.deleted" => AssistantOverridesServerMessage.SessionDeleted,
                "session.updated" => AssistantOverridesServerMessage.SessionUpdated,
                "speech-update" => AssistantOverridesServerMessage.SpeechUpdate,
                "status-update" => AssistantOverridesServerMessage.StatusUpdate,
                "tool-calls" => AssistantOverridesServerMessage.ToolCalls,
                "transcript" => AssistantOverridesServerMessage.Transcript,
                "transcript-final" => AssistantOverridesServerMessage.TranscriptFinal,
                "transfer-destination-request" => AssistantOverridesServerMessage.TransferDestinationRequest,
                "transfer-update" => AssistantOverridesServerMessage.TransferUpdate,
                "user-interrupted" => AssistantOverridesServerMessage.UserInterrupted,
                "voice-input" => AssistantOverridesServerMessage.VoiceInput,
                _ => null,
            };
        }
    }
}