//HintName: G.Models.CreatePhoneCallResponseStatus5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePhoneCallResponseStatus5
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePhoneCallResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePhoneCallResponseStatus5 value)
        {
            return value switch
            {
                CreatePhoneCallResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePhoneCallResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreatePhoneCallResponseStatus5.Error,
                _ => null,
            };
        }
    }
}