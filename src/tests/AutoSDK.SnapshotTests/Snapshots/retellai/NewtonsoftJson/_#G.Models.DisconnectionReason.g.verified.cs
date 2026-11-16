//HintName: G.Models.DisconnectionReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DisconnectionReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent_hangup")]
        AgentHangup,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call_transfer")]
        CallTransfer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="concurrency_limit_reached")]
        ConcurrencyLimitReached,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dial_busy")]
        DialBusy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dial_failed")]
        DialFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dial_no_answer")]
        DialNoAnswer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error_asr")]
        ErrorAsr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error_llm_websocket_corrupt_payload")]
        ErrorLlmWebsocketCorruptPayload,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error_llm_websocket_lost_connection")]
        ErrorLlmWebsocketLostConnection,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error_llm_websocket_open")]
        ErrorLlmWebsocketOpen,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error_llm_websocket_runtime")]
        ErrorLlmWebsocketRuntime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error_no_audio_received")]
        ErrorNoAudioReceived,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error_retell")]
        ErrorRetell,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error_unknown")]
        ErrorUnknown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error_user_not_joined")]
        ErrorUserNotJoined,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inactivity")]
        Inactivity,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid_destination")]
        InvalidDestination,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ivr_reached")]
        IvrReached,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="marked_as_spam")]
        MarkedAsSpam,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="max_duration_reached")]
        MaxDurationReached,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="no_valid_payment")]
        NoValidPayment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="registered_call_timeout")]
        RegisteredCallTimeout,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scam_detected")]
        ScamDetected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sip_routing_error")]
        SipRoutingError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="telephony_provider_permission_denied")]
        TelephonyProviderPermissionDenied,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="telephony_provider_unavailable")]
        TelephonyProviderUnavailable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transfer_bridged")]
        TransferBridged,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transfer_cancelled")]
        TransferCancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_declined")]
        UserDeclined,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_hangup")]
        UserHangup,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voicemail_reached")]
        VoicemailReached,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DisconnectionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DisconnectionReason value)
        {
            return value switch
            {
                DisconnectionReason.AgentHangup => "agent_hangup",
                DisconnectionReason.CallTransfer => "call_transfer",
                DisconnectionReason.ConcurrencyLimitReached => "concurrency_limit_reached",
                DisconnectionReason.DialBusy => "dial_busy",
                DisconnectionReason.DialFailed => "dial_failed",
                DisconnectionReason.DialNoAnswer => "dial_no_answer",
                DisconnectionReason.ErrorAsr => "error_asr",
                DisconnectionReason.ErrorLlmWebsocketCorruptPayload => "error_llm_websocket_corrupt_payload",
                DisconnectionReason.ErrorLlmWebsocketLostConnection => "error_llm_websocket_lost_connection",
                DisconnectionReason.ErrorLlmWebsocketOpen => "error_llm_websocket_open",
                DisconnectionReason.ErrorLlmWebsocketRuntime => "error_llm_websocket_runtime",
                DisconnectionReason.ErrorNoAudioReceived => "error_no_audio_received",
                DisconnectionReason.ErrorRetell => "error_retell",
                DisconnectionReason.ErrorUnknown => "error_unknown",
                DisconnectionReason.ErrorUserNotJoined => "error_user_not_joined",
                DisconnectionReason.Inactivity => "inactivity",
                DisconnectionReason.InvalidDestination => "invalid_destination",
                DisconnectionReason.IvrReached => "ivr_reached",
                DisconnectionReason.MarkedAsSpam => "marked_as_spam",
                DisconnectionReason.MaxDurationReached => "max_duration_reached",
                DisconnectionReason.NoValidPayment => "no_valid_payment",
                DisconnectionReason.RegisteredCallTimeout => "registered_call_timeout",
                DisconnectionReason.ScamDetected => "scam_detected",
                DisconnectionReason.SipRoutingError => "sip_routing_error",
                DisconnectionReason.TelephonyProviderPermissionDenied => "telephony_provider_permission_denied",
                DisconnectionReason.TelephonyProviderUnavailable => "telephony_provider_unavailable",
                DisconnectionReason.TransferBridged => "transfer_bridged",
                DisconnectionReason.TransferCancelled => "transfer_cancelled",
                DisconnectionReason.UserDeclined => "user_declined",
                DisconnectionReason.UserHangup => "user_hangup",
                DisconnectionReason.VoicemailReached => "voicemail_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DisconnectionReason? ToEnum(string value)
        {
            return value switch
            {
                "agent_hangup" => DisconnectionReason.AgentHangup,
                "call_transfer" => DisconnectionReason.CallTransfer,
                "concurrency_limit_reached" => DisconnectionReason.ConcurrencyLimitReached,
                "dial_busy" => DisconnectionReason.DialBusy,
                "dial_failed" => DisconnectionReason.DialFailed,
                "dial_no_answer" => DisconnectionReason.DialNoAnswer,
                "error_asr" => DisconnectionReason.ErrorAsr,
                "error_llm_websocket_corrupt_payload" => DisconnectionReason.ErrorLlmWebsocketCorruptPayload,
                "error_llm_websocket_lost_connection" => DisconnectionReason.ErrorLlmWebsocketLostConnection,
                "error_llm_websocket_open" => DisconnectionReason.ErrorLlmWebsocketOpen,
                "error_llm_websocket_runtime" => DisconnectionReason.ErrorLlmWebsocketRuntime,
                "error_no_audio_received" => DisconnectionReason.ErrorNoAudioReceived,
                "error_retell" => DisconnectionReason.ErrorRetell,
                "error_unknown" => DisconnectionReason.ErrorUnknown,
                "error_user_not_joined" => DisconnectionReason.ErrorUserNotJoined,
                "inactivity" => DisconnectionReason.Inactivity,
                "invalid_destination" => DisconnectionReason.InvalidDestination,
                "ivr_reached" => DisconnectionReason.IvrReached,
                "marked_as_spam" => DisconnectionReason.MarkedAsSpam,
                "max_duration_reached" => DisconnectionReason.MaxDurationReached,
                "no_valid_payment" => DisconnectionReason.NoValidPayment,
                "registered_call_timeout" => DisconnectionReason.RegisteredCallTimeout,
                "scam_detected" => DisconnectionReason.ScamDetected,
                "sip_routing_error" => DisconnectionReason.SipRoutingError,
                "telephony_provider_permission_denied" => DisconnectionReason.TelephonyProviderPermissionDenied,
                "telephony_provider_unavailable" => DisconnectionReason.TelephonyProviderUnavailable,
                "transfer_bridged" => DisconnectionReason.TransferBridged,
                "transfer_cancelled" => DisconnectionReason.TransferCancelled,
                "user_declined" => DisconnectionReason.UserDeclined,
                "user_hangup" => DisconnectionReason.UserHangup,
                "voicemail_reached" => DisconnectionReason.VoicemailReached,
                _ => null,
            };
        }
    }
}