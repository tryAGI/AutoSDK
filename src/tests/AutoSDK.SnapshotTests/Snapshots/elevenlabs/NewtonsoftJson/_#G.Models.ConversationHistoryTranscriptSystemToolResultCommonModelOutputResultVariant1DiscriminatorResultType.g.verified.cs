//HintName: G.Models.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType
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