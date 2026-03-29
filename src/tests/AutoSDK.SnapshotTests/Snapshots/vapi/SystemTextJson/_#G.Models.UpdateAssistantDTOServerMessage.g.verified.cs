//HintName: G.Models.UpdateAssistantDTOServerMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateAssistantDTOServerMessage
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
    public static class UpdateAssistantDTOServerMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssistantDTOServerMessage value)
        {
            return value switch
            {
                UpdateAssistantDTOServerMessage.AssistantStarted => "assistant.started",
                UpdateAssistantDTOServerMessage.CallDeleteFailed => "call.delete.failed",
                UpdateAssistantDTOServerMessage.CallDeleted => "call.deleted",
                UpdateAssistantDTOServerMessage.ChatCreated => "chat.created",
                UpdateAssistantDTOServerMessage.ChatDeleted => "chat.deleted",
                UpdateAssistantDTOServerMessage.ConversationUpdate => "conversation-update",
                UpdateAssistantDTOServerMessage.EndOfCallReport => "end-of-call-report",
                UpdateAssistantDTOServerMessage.FunctionCall => "function-call",
                UpdateAssistantDTOServerMessage.HandoffDestinationRequest => "handoff-destination-request",
                UpdateAssistantDTOServerMessage.Hang => "hang",
                UpdateAssistantDTOServerMessage.LanguageChangeDetected => "language-change-detected",
                UpdateAssistantDTOServerMessage.LanguageChanged => "language-changed",
                UpdateAssistantDTOServerMessage.ModelOutput => "model-output",
                UpdateAssistantDTOServerMessage.PhoneCallControl => "phone-call-control",
                UpdateAssistantDTOServerMessage.SessionCreated => "session.created",
                UpdateAssistantDTOServerMessage.SessionDeleted => "session.deleted",
                UpdateAssistantDTOServerMessage.SessionUpdated => "session.updated",
                UpdateAssistantDTOServerMessage.SpeechUpdate => "speech-update",
                UpdateAssistantDTOServerMessage.StatusUpdate => "status-update",
                UpdateAssistantDTOServerMessage.ToolCalls => "tool-calls",
                UpdateAssistantDTOServerMessage.Transcript => "transcript",
                UpdateAssistantDTOServerMessage.TranscriptFinal => "transcript-final",
                UpdateAssistantDTOServerMessage.TransferDestinationRequest => "transfer-destination-request",
                UpdateAssistantDTOServerMessage.TransferUpdate => "transfer-update",
                UpdateAssistantDTOServerMessage.UserInterrupted => "user-interrupted",
                UpdateAssistantDTOServerMessage.VoiceInput => "voice-input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssistantDTOServerMessage? ToEnum(string value)
        {
            return value switch
            {
                "assistant.started" => UpdateAssistantDTOServerMessage.AssistantStarted,
                "call.delete.failed" => UpdateAssistantDTOServerMessage.CallDeleteFailed,
                "call.deleted" => UpdateAssistantDTOServerMessage.CallDeleted,
                "chat.created" => UpdateAssistantDTOServerMessage.ChatCreated,
                "chat.deleted" => UpdateAssistantDTOServerMessage.ChatDeleted,
                "conversation-update" => UpdateAssistantDTOServerMessage.ConversationUpdate,
                "end-of-call-report" => UpdateAssistantDTOServerMessage.EndOfCallReport,
                "function-call" => UpdateAssistantDTOServerMessage.FunctionCall,
                "handoff-destination-request" => UpdateAssistantDTOServerMessage.HandoffDestinationRequest,
                "hang" => UpdateAssistantDTOServerMessage.Hang,
                "language-change-detected" => UpdateAssistantDTOServerMessage.LanguageChangeDetected,
                "language-changed" => UpdateAssistantDTOServerMessage.LanguageChanged,
                "model-output" => UpdateAssistantDTOServerMessage.ModelOutput,
                "phone-call-control" => UpdateAssistantDTOServerMessage.PhoneCallControl,
                "session.created" => UpdateAssistantDTOServerMessage.SessionCreated,
                "session.deleted" => UpdateAssistantDTOServerMessage.SessionDeleted,
                "session.updated" => UpdateAssistantDTOServerMessage.SessionUpdated,
                "speech-update" => UpdateAssistantDTOServerMessage.SpeechUpdate,
                "status-update" => UpdateAssistantDTOServerMessage.StatusUpdate,
                "tool-calls" => UpdateAssistantDTOServerMessage.ToolCalls,
                "transcript" => UpdateAssistantDTOServerMessage.Transcript,
                "transcript-final" => UpdateAssistantDTOServerMessage.TranscriptFinal,
                "transfer-destination-request" => UpdateAssistantDTOServerMessage.TransferDestinationRequest,
                "transfer-update" => UpdateAssistantDTOServerMessage.TransferUpdate,
                "user-interrupted" => UpdateAssistantDTOServerMessage.UserInterrupted,
                "voice-input" => UpdateAssistantDTOServerMessage.VoiceInput,
                _ => null,
            };
        }
    }
}