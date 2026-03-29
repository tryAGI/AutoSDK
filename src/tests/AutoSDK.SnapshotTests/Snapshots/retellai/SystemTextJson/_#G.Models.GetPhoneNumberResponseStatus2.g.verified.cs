//HintName: G.Models.GetPhoneNumberResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPhoneNumberResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPhoneNumberResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPhoneNumberResponseStatus2 value)
        {
            return value switch
            {
                GetPhoneNumberResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPhoneNumberResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetPhoneNumberResponseStatus2.Error,
                _ => null,
            };
        }
    }
}