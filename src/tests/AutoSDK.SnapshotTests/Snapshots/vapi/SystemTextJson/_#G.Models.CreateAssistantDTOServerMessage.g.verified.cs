//HintName: G.Models.CreateAssistantDTOServerMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAssistantDTOServerMessage
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