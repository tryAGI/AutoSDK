//HintName: G.Models.DisconnectionReason4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DisconnectionReason4
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
    public static class DisconnectionReason4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DisconnectionReason4 value)
        {
            return value switch
            {
                DisconnectionReason4.AgentHangup => "agent_hangup",
                DisconnectionReason4.CallTransfer => "call_transfer",
                DisconnectionReason4.ConcurrencyLimitReached => "concurrency_limit_reached",
                DisconnectionReason4.DialBusy => "dial_busy",
                DisconnectionReason4.DialFailed => "dial_failed",
                DisconnectionReason4.DialNoAnswer => "dial_no_answer",
                DisconnectionReason4.ErrorAsr => "error_asr",
                DisconnectionReason4.ErrorLlmWebsocketCorruptPayload => "error_llm_websocket_corrupt_payload",
                DisconnectionReason4.ErrorLlmWebsocketLostConnection => "error_llm_websocket_lost_connection",
                DisconnectionReason4.ErrorLlmWebsocketOpen => "error_llm_websocket_open",
                DisconnectionReason4.ErrorLlmWebsocketRuntime => "error_llm_websocket_runtime",
                DisconnectionReason4.ErrorNoAudioReceived => "error_no_audio_received",
                DisconnectionReason4.ErrorRetell => "error_retell",
                DisconnectionReason4.ErrorUnknown => "error_unknown",
                DisconnectionReason4.ErrorUserNotJoined => "error_user_not_joined",
                DisconnectionReason4.Inactivity => "inactivity",
                DisconnectionReason4.InvalidDestination => "invalid_destination",
                DisconnectionReason4.IvrReached => "ivr_reached",
                DisconnectionReason4.MarkedAsSpam => "marked_as_spam",
                DisconnectionReason4.MaxDurationReached => "max_duration_reached",
                DisconnectionReason4.NoValidPayment => "no_valid_payment",
                DisconnectionReason4.RegisteredCallTimeout => "registered_call_timeout",
                DisconnectionReason4.ScamDetected => "scam_detected",
                DisconnectionReason4.SipRoutingError => "sip_routing_error",
                DisconnectionReason4.TelephonyProviderPermissionDenied => "telephony_provider_permission_denied",
                DisconnectionReason4.TelephonyProviderUnavailable => "telephony_provider_unavailable",
                DisconnectionReason4.TransferBridged => "transfer_bridged",
                DisconnectionReason4.TransferCancelled => "transfer_cancelled",
                DisconnectionReason4.UserDeclined => "user_declined",
                DisconnectionReason4.UserHangup => "user_hangup",
                DisconnectionReason4.VoicemailReached => "voicemail_reached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DisconnectionReason4? ToEnum(string value)
        {
            return value switch
            {
                "agent_hangup" => DisconnectionReason4.AgentHangup,
                "call_transfer" => DisconnectionReason4.CallTransfer,
                "concurrency_limit_reached" => DisconnectionReason4.ConcurrencyLimitReached,
                "dial_busy" => DisconnectionReason4.DialBusy,
                "dial_failed" => DisconnectionReason4.DialFailed,
                "dial_no_answer" => DisconnectionReason4.DialNoAnswer,
                "error_asr" => DisconnectionReason4.ErrorAsr,
                "error_llm_websocket_corrupt_payload" => DisconnectionReason4.ErrorLlmWebsocketCorruptPayload,
                "error_llm_websocket_lost_connection" => DisconnectionReason4.ErrorLlmWebsocketLostConnection,
                "error_llm_websocket_open" => DisconnectionReason4.ErrorLlmWebsocketOpen,
                "error_llm_websocket_runtime" => DisconnectionReason4.ErrorLlmWebsocketRuntime,
                "error_no_audio_received" => DisconnectionReason4.ErrorNoAudioReceived,
                "error_retell" => DisconnectionReason4.ErrorRetell,
                "error_unknown" => DisconnectionReason4.ErrorUnknown,
                "error_user_not_joined" => DisconnectionReason4.ErrorUserNotJoined,
                "inactivity" => DisconnectionReason4.Inactivity,
                "invalid_destination" => DisconnectionReason4.InvalidDestination,
                "ivr_reached" => DisconnectionReason4.IvrReached,
                "marked_as_spam" => DisconnectionReason4.MarkedAsSpam,
                "max_duration_reached" => DisconnectionReason4.MaxDurationReached,
                "no_valid_payment" => DisconnectionReason4.NoValidPayment,
                "registered_call_timeout" => DisconnectionReason4.RegisteredCallTimeout,
                "scam_detected" => DisconnectionReason4.ScamDetected,
                "sip_routing_error" => DisconnectionReason4.SipRoutingError,
                "telephony_provider_permission_denied" => DisconnectionReason4.TelephonyProviderPermissionDenied,
                "telephony_provider_unavailable" => DisconnectionReason4.TelephonyProviderUnavailable,
                "transfer_bridged" => DisconnectionReason4.TransferBridged,
                "transfer_cancelled" => DisconnectionReason4.TransferCancelled,
                "user_declined" => DisconnectionReason4.UserDeclined,
                "user_hangup" => DisconnectionReason4.UserHangup,
                "voicemail_reached" => DisconnectionReason4.VoicemailReached,
                _ => null,
            };
        }
    }
}