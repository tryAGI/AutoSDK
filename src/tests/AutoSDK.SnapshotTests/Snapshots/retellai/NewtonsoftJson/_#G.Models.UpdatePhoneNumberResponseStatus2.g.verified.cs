//HintName: G.Models.UpdatePhoneNumberResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdatePhoneNumberResponseStatus2
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
    public static class UpdatePhoneNumberResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePhoneNumberResponseStatus2 value)
        {
            return value switch
            {
                UpdatePhoneNumberResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePhoneNumberResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => UpdatePhoneNumberResponseStatus2.Error,
                _ => null,
            };
        }
    }
}