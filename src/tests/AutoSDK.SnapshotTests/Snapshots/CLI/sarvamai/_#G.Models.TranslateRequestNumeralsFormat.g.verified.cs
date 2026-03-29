//HintName: G.Models.TranslateRequestNumeralsFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Format of numerals in the output<br/>
    /// Default Value: international
    /// </summary>
    public enum TranslateRequestNumeralsFormat
    {
        /// <summary>
        /// 
        /// </summary>
        International,
        /// <summary>
        /// 
        /// </summary>
        Native,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslateRequestNumeralsFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslateRequestNumeralsFormat value)
        {
            return value switch
            {
                TranslateRequestNumeralsFormat.International => "international",
                TranslateRequestNumeralsFormat.Native => "native",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslateRequestNumeralsFormat? ToEnum(string value)
        {
            return value switch
            {
                "international" => TranslateRequestNumeralsFormat.International,
                "native" => TranslateRequestNumeralsFormat.Native,
                _ => null,
            };
        }
    }
}