//HintName: G.Models.RegisterPhoneCallResponseStatus5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegisterPhoneCallResponseStatus5
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegisterPhoneCallResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegisterPhoneCallResponseStatus5 value)
        {
            return value switch
            {
                RegisterPhoneCallResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegisterPhoneCallResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => RegisterPhoneCallResponseStatus5.Error,
                _ => null,
            };
        }
    }
}