//HintName: G.Models.PdfParserEngine1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PdfParserEngine1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pdf-text")]
        PdfText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PdfParserEngine1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PdfParserEngine1 value)
        {
            return value switch
            {
                PdfParserEngine1.PdfText => "pdf-text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PdfParserEngine1? ToEnum(string value)
        {
            return value switch
            {
                "pdf-text" => PdfParserEngine1.PdfText,
                _ => null,
            };
        }
    }
}