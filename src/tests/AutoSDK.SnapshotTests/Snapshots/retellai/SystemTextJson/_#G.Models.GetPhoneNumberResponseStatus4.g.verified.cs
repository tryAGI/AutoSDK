//HintName: G.Models.GetPhoneNumberResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPhoneNumberResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPhoneNumberResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPhoneNumberResponseStatus4 value)
        {
            return value switch
            {
                GetPhoneNumberResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPhoneNumberResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetPhoneNumberResponseStatus4.Error,
                _ => null,
            };
        }
    }
}