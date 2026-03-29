//HintName: G.Models.RegisterPhoneCallResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RegisterPhoneCallResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
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