//HintName: G.Models.ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationHistoryTranscriptSystemToolResultCommonModelInputResultVariant1DiscriminatorResultType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="end_call_success")]
        EndCallSuccess,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="language_detection_success")]
        LanguageDetectionSuccess,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="play_dtmf_error")]
        PlayDtmfError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="play_dtmf_success")]
        PlayDtmfSuccess,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skip_turn_success")]
        SkipTurnSuccess,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="testing_tool_result")]
        TestingToolResult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transfer_to_agent_error")]
        TransferToAgentError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transfer_to_agent_success")]
        TransferToAgentSuccess,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transfer_to_number_error")]
        TransferToNumberError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transfer_to_number_sip_success")]
        TransferToNumberSipSuccess,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transfer_to_number_twilio_success")]
        TransferToNumberTwilioSuccess,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voicemail_detection_success")]
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