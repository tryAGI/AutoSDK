//HintName: G.Models.DocumentParseRequestOcr.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OCR mode. Set to auto to enable OCR for scanned documents,<br/>
    /// or force to always apply OCR.<br/>
    /// Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DocumentParseRequestOcr
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="force")]
        Force,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentParseRequestOcrExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentParseRequestOcr value)
        {
            return value switch
            {
                DocumentParseRequestOcr.Auto => "auto",
                DocumentParseRequestOcr.Force => "force",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentParseRequestOcr? ToEnum(string value)
        {
            return value switch
            {
                "auto" => DocumentParseRequestOcr.Auto,
                "force" => DocumentParseRequestOcr.Force,
                _ => null,
            };
        }
    }
}