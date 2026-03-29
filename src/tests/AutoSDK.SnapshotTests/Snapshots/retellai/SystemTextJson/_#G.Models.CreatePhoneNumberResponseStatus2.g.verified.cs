//HintName: G.Models.CreatePhoneNumberResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePhoneNumberResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePhoneNumberResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePhoneNumberResponseStatus2 value)
        {
            return value switch
            {
                CreatePhoneNumberResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePhoneNumberResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreatePhoneNumberResponseStatus2.Error,
                _ => null,
            };
        }
    }
}