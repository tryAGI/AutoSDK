//HintName: G.Models.PdfParserEngine0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PdfParserEngine0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cloudflare-ai")]
        CloudflareAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mistral-ocr")]
        MistralOcr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="native")]
        Native,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PdfParserEngine0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PdfParserEngine0 value)
        {
            return value switch
            {
                PdfParserEngine0.CloudflareAi => "cloudflare-ai",
                PdfParserEngine0.MistralOcr => "mistral-ocr",
                PdfParserEngine0.Native => "native",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PdfParserEngine0? ToEnum(string value)
        {
            return value switch
            {
                "cloudflare-ai" => PdfParserEngine0.CloudflareAi,
                "mistral-ocr" => PdfParserEngine0.MistralOcr,
                "native" => PdfParserEngine0.Native,
                _ => null,
            };
        }
    }
}