//HintName: G.Models.RegisterPhoneCallResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RegisterPhoneCallResponseStatus4
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
    public static class RegisterPhoneCallResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegisterPhoneCallResponseStatus4 value)
        {
            return value switch
            {
                RegisterPhoneCallResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegisterPhoneCallResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => RegisterPhoneCallResponseStatus4.Error,
                _ => null,
            };
        }
    }
}