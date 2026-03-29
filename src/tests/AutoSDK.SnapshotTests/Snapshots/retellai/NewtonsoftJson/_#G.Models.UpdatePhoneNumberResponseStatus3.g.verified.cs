//HintName: G.Models.UpdatePhoneNumberResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdatePhoneNumberResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdatePhoneNumberResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePhoneNumberResponseStatus3 value)
        {
            return value switch
            {
                UpdatePhoneNumberResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePhoneNumberResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdatePhoneNumberResponseStatus3.Error,
                _ => null,
            };
        }
    }
}