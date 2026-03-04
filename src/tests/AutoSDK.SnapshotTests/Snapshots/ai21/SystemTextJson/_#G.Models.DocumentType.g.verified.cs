//HintName: G.Models.DocumentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum DocumentType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentType value)
        {
            return value switch
            {
                DocumentType.Url => "URL",
                DocumentType.Text => "TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentType? ToEnum(string value)
        {
            return value switch
            {
                "URL" => DocumentType.Url,
                "TEXT" => DocumentType.Text,
                _ => null,
            };
        }
    }
}