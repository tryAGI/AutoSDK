//HintName: G.Models.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType
    {
        /// <summary>
        /// 
        /// </summary>
        EndCallSuccess,
        /// <summary>
        /// 
        /// </summary>
        LanguageDetectionSuccess,
        /// <summary>
        /// 
        /// </summary>
        PlayDtmfError,
        /// <summary>
        /// 
        /// </summary>
        PlayDtmfSuccess,
        /// <summary>
        /// 
        /// </summary>
        SkipTurnSuccess,
        /// <summary>
        /// 
        /// </summary>
        TestingToolResult,
        /// <summary>
        /// 
        /// </summary>
        TransferToAgentError,
        /// <summary>
        /// 
        /// </summary>
        TransferToAgentSuccess,
        /// <summary>
        /// 
        /// </summary>
        TransferToNumberError,
        /// <summary>
        /// 
        /// </summary>
        TransferToNumberSipSuccess,
        /// <summary>
        /// 
        /// </summary>
        TransferToNumberTwilioSuccess,
        /// <summary>
        /// 
        /// </summary>
        VoicemailDetectionSuccess,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType value)
        {
            return value switch
            {
                ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.EndCallSuccess => "end_call_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.LanguageDetectionSuccess => "language_detection_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.PlayDtmfError => "play_dtmf_error",
                ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.PlayDtmfSuccess => "play_dtmf_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.SkipTurnSuccess => "skip_turn_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TestingToolResult => "testing_tool_result",
                ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToAgentError => "transfer_to_agent_error",
                ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToAgentSuccess => "transfer_to_agent_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToNumberError => "transfer_to_number_error",
                ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToNumberSipSuccess => "transfer_to_number_sip_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToNumberTwilioSuccess => "transfer_to_number_twilio_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.VoicemailDetectionSuccess => "voicemail_detection_success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType? ToEnum(string value)
        {
            return value switch
            {
                "end_call_success" => ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.EndCallSuccess,
                "language_detection_success" => ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.LanguageDetectionSuccess,
                "play_dtmf_error" => ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.PlayDtmfError,
                "play_dtmf_success" => ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.PlayDtmfSuccess,
                "skip_turn_success" => ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.SkipTurnSuccess,
                "testing_tool_result" => ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TestingToolResult,
                "transfer_to_agent_error" => ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToAgentError,
                "transfer_to_agent_success" => ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToAgentSuccess,
                "transfer_to_number_error" => ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToNumberError,
                "transfer_to_number_sip_success" => ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToNumberSipSuccess,
                "transfer_to_number_twilio_success" => ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToNumberTwilioSuccess,
                "voicemail_detection_success" => ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.VoicemailDetectionSuccess,
                _ => null,
            };
        }
    }
}