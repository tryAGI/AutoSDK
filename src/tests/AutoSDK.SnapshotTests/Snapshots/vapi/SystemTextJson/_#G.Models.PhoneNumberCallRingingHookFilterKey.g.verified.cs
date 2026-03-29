//HintName: G.Models.PhoneNumberCallRingingHookFilterKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The field to check. Currently only "number" (the caller's phone number) is supported.
    /// </summary>
    public enum PhoneNumberCallRingingHookFilterKey
    {
        /// <summary>
        /// 
        /// </summary>
        Number,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberCallRingingHookFilterKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberCallRingingHookFilterKey value)
        {
            return value switch
            {
                PhoneNumberCallRingingHookFilterKey.Number => "number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberCallRingingHookFilterKey? ToEnum(string value)
        {
            return value switch
            {
                "number" => PhoneNumberCallRingingHookFilterKey.Number,
                _ => null,
            };
        }
    }
}