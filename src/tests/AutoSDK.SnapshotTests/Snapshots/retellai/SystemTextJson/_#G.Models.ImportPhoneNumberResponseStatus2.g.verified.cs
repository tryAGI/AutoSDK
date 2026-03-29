//HintName: G.Models.ImportPhoneNumberResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImportPhoneNumberResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportPhoneNumberResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportPhoneNumberResponseStatus2 value)
        {
            return value switch
            {
                ImportPhoneNumberResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportPhoneNumberResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => ImportPhoneNumberResponseStatus2.Error,
                _ => null,
            };
        }
    }
}