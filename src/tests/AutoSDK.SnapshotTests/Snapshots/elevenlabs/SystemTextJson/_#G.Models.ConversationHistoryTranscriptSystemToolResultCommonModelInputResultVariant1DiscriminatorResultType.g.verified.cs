//HintName: G.Models.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType
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
    public static class ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType value)
        {
            return value switch
            {
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.EndCallSuccess => "end_call_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.LanguageDetectionSuccess => "language_detection_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.PlayDtmfError => "play_dtmf_error",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.PlayDtmfSuccess => "play_dtmf_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.SkipTurnSuccess => "skip_turn_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TestingToolResult => "testing_tool_result",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToAgentError => "transfer_to_agent_error",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToAgentSuccess => "transfer_to_agent_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToNumberError => "transfer_to_number_error",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToNumberSipSuccess => "transfer_to_number_sip_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToNumberTwilioSuccess => "transfer_to_number_twilio_success",
                ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.VoicemailDetectionSuccess => "voicemail_detection_success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType? ToEnum(string value)
        {
            return value switch
            {
                "end_call_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.EndCallSuccess,
                "language_detection_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.LanguageDetectionSuccess,
                "play_dtmf_error" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.PlayDtmfError,
                "play_dtmf_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.PlayDtmfSuccess,
                "skip_turn_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.SkipTurnSuccess,
                "testing_tool_result" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TestingToolResult,
                "transfer_to_agent_error" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToAgentError,
                "transfer_to_agent_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToAgentSuccess,
                "transfer_to_number_error" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToNumberError,
                "transfer_to_number_sip_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToNumberSipSuccess,
                "transfer_to_number_twilio_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.TransferToNumberTwilioSuccess,
                "voicemail_detection_success" => ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.VoicemailDetectionSuccess,
                _ => null,
            };
        }
    }
}