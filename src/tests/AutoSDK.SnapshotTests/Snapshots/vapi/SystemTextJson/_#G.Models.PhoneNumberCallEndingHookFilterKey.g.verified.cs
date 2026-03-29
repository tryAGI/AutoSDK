//HintName: G.Models.PhoneNumberCallEndingHookFilterKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the key to filter on - only "call.endedReason" is allowed for phone number call ending hooks
    /// </summary>
    public enum PhoneNumberCallEndingHookFilterKey
    {
        /// <summary>
        /// 
        /// </summary>
        CallEndedReason,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberCallEndingHookFilterKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberCallEndingHookFilterKey value)
        {
            return value switch
            {
                PhoneNumberCallEndingHookFilterKey.CallEndedReason => "call.endedReason",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberCallEndingHookFilterKey? ToEnum(string value)
        {
            return value switch
            {
                "call.endedReason" => PhoneNumberCallEndingHookFilterKey.CallEndedReason,
                _ => null,
            };
        }
    }
}