//HintName: G.Models.CreatePhoneNumberResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePhoneNumberResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePhoneNumberResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePhoneNumberResponseStatus3 value)
        {
            return value switch
            {
                CreatePhoneNumberResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePhoneNumberResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreatePhoneNumberResponseStatus3.Error,
                _ => null,
            };
        }
    }
}