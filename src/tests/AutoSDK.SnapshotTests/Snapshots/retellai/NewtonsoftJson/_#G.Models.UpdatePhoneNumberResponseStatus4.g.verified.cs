//HintName: G.Models.UpdatePhoneNumberResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdatePhoneNumberResponseStatus4
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
    public static class UpdatePhoneNumberResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePhoneNumberResponseStatus4 value)
        {
            return value switch
            {
                UpdatePhoneNumberResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePhoneNumberResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdatePhoneNumberResponseStatus4.Error,
                _ => null,
            };
        }
    }
}