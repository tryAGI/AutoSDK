//HintName: G.Models.RegisterPhoneCallResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RegisterPhoneCallResponseStatus
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
    public static class RegisterPhoneCallResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegisterPhoneCallResponseStatus value)
        {
            return value switch
            {
                RegisterPhoneCallResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegisterPhoneCallResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => RegisterPhoneCallResponseStatus.Error,
                _ => null,
            };
        }
    }
}