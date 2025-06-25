//HintName: G.Models.BetaRequestDocumentBlockType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestDocumentBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestDocumentBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestDocumentBlockType value)
        {
            return value switch
            {
                BetaRequestDocumentBlockType.Document => "document",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestDocumentBlockType? ToEnum(string value)
        {
            return value switch
            {
                "document" => BetaRequestDocumentBlockType.Document,
                _ => null,
            };
        }
    }
}