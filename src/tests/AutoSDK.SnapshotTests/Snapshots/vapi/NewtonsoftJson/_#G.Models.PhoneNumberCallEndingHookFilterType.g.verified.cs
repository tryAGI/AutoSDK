//HintName: G.Models.PhoneNumberCallEndingHookFilterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of filter - currently only "oneOf" is supported
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PhoneNumberCallEndingHookFilterType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="oneOf")]
        OneOf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberCallEndingHookFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberCallEndingHookFilterType value)
        {
            return value switch
            {
                PhoneNumberCallEndingHookFilterType.OneOf => "oneOf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberCallEndingHookFilterType? ToEnum(string value)
        {
            return value switch
            {
                "oneOf" => PhoneNumberCallEndingHookFilterType.OneOf,
                _ => null,
            };
        }
    }
}