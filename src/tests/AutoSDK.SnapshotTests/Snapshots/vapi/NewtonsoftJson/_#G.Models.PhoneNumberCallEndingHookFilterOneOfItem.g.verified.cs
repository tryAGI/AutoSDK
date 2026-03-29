//HintName: G.Models.PhoneNumberCallEndingHookFilterOneOfItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PhoneNumberCallEndingHookFilterOneOfItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-request-failed")]
        AssistantRequestFailed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-request-returned-error")]
        AssistantRequestReturnedError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-request-returned-forwarding-phone-number")]
        AssistantRequestReturnedForwardingPhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-request-returned-invalid-assistant")]
        AssistantRequestReturnedInvalidAssistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-request-returned-no-assistant")]
        AssistantRequestReturnedNoAssistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant-request-returned-unspeakable-error")]
        AssistantRequestReturnedUnspeakableError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberCallEndingHookFilterOneOfItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberCallEndingHookFilterOneOfItem value)
        {
            return value switch
            {
                PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestFailed => "assistant-request-failed",
                PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestReturnedError => "assistant-request-returned-error",
                PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestReturnedForwardingPhoneNumber => "assistant-request-returned-forwarding-phone-number",
                PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestReturnedInvalidAssistant => "assistant-request-returned-invalid-assistant",
                PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestReturnedNoAssistant => "assistant-request-returned-no-assistant",
                PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestReturnedUnspeakableError => "assistant-request-returned-unspeakable-error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberCallEndingHookFilterOneOfItem? ToEnum(string value)
        {
            return value switch
            {
                "assistant-request-failed" => PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestFailed,
                "assistant-request-returned-error" => PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestReturnedError,
                "assistant-request-returned-forwarding-phone-number" => PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestReturnedForwardingPhoneNumber,
                "assistant-request-returned-invalid-assistant" => PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestReturnedInvalidAssistant,
                "assistant-request-returned-no-assistant" => PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestReturnedNoAssistant,
                "assistant-request-returned-unspeakable-error" => PhoneNumberCallEndingHookFilterOneOfItem.AssistantRequestReturnedUnspeakableError,
                _ => null,
            };
        }
    }
}