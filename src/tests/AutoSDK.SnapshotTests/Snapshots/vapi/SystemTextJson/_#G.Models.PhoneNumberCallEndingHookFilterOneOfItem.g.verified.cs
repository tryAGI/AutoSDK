//HintName: G.Models.PhoneNumberCallEndingHookFilterOneOfItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PhoneNumberCallEndingHookFilterOneOfItem
    {
        /// <summary>
        /// 
        /// </summary>
        AssistantRequestFailed,
        /// <summary>
        /// 
        /// </summary>
        AssistantRequestReturnedError,
        /// <summary>
        /// 
        /// </summary>
        AssistantRequestReturnedForwardingPhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        AssistantRequestReturnedInvalidAssistant,
        /// <summary>
        /// 
        /// </summary>
        AssistantRequestReturnedNoAssistant,
        /// <summary>
        /// 
        /// </summary>
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