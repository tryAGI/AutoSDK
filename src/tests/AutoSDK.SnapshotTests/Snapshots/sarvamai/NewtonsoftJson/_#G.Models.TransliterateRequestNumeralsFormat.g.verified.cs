//HintName: G.Models.TransliterateRequestNumeralsFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Format of numerals in the output<br/>
    /// Default Value: international
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransliterateRequestNumeralsFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="international")]
        International,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="native")]
        Native,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransliterateRequestNumeralsFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransliterateRequestNumeralsFormat value)
        {
            return value switch
            {
                TransliterateRequestNumeralsFormat.International => "international",
                TransliterateRequestNumeralsFormat.Native => "native",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransliterateRequestNumeralsFormat? ToEnum(string value)
        {
            return value switch
            {
                "international" => TransliterateRequestNumeralsFormat.International,
                "native" => TransliterateRequestNumeralsFormat.Native,
                _ => null,
            };
        }
    }
}