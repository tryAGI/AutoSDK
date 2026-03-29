//HintName: G.Models.GetPhoneNumberResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetPhoneNumberResponseStatus
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
    public static class GetPhoneNumberResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPhoneNumberResponseStatus value)
        {
            return value switch
            {
                GetPhoneNumberResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPhoneNumberResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetPhoneNumberResponseStatus.Error,
                _ => null,
            };
        }
    }
}