//HintName: G.Models.ImportPhoneNumberResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImportPhoneNumberResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportPhoneNumberResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportPhoneNumberResponseStatus value)
        {
            return value switch
            {
                ImportPhoneNumberResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportPhoneNumberResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ImportPhoneNumberResponseStatus.Error,
                _ => null,
            };
        }
    }
}