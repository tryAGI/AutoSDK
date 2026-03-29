//HintName: G.Models.PhoneNumberCallRingingHookFilterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of filter - matches when the specified field starts with any of the given prefixes
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PhoneNumberCallRingingHookFilterType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="startsWith")]
        StartsWith,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PhoneNumberCallRingingHookFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberCallRingingHookFilterType value)
        {
            return value switch
            {
                PhoneNumberCallRingingHookFilterType.StartsWith => "startsWith",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberCallRingingHookFilterType? ToEnum(string value)
        {
            return value switch
            {
                "startsWith" => PhoneNumberCallRingingHookFilterType.StartsWith,
                _ => null,
            };
        }
    }
}