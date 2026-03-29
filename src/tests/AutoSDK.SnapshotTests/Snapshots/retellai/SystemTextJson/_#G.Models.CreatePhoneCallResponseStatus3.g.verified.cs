//HintName: G.Models.CreatePhoneCallResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePhoneCallResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePhoneCallResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePhoneCallResponseStatus3 value)
        {
            return value switch
            {
                CreatePhoneCallResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePhoneCallResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreatePhoneCallResponseStatus3.Error,
                _ => null,
            };
        }
    }
}