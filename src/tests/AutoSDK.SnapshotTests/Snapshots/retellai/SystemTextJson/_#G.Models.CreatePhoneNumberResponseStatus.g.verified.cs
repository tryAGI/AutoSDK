//HintName: G.Models.CreatePhoneNumberResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePhoneNumberResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePhoneNumberResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePhoneNumberResponseStatus value)
        {
            return value switch
            {
                CreatePhoneNumberResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePhoneNumberResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreatePhoneNumberResponseStatus.Error,
                _ => null,
            };
        }
    }
}