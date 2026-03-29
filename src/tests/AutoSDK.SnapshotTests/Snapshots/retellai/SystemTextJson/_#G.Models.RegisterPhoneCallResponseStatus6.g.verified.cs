//HintName: G.Models.RegisterPhoneCallResponseStatus6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegisterPhoneCallResponseStatus6
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegisterPhoneCallResponseStatus6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegisterPhoneCallResponseStatus6 value)
        {
            return value switch
            {
                RegisterPhoneCallResponseStatus6.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegisterPhoneCallResponseStatus6? ToEnum(string value)
        {
            return value switch
            {
                "error" => RegisterPhoneCallResponseStatus6.Error,
                _ => null,
            };
        }
    }
}