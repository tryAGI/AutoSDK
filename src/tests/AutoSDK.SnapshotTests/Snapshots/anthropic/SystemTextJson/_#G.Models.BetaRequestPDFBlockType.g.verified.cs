//HintName: G.Models.BetaRequestPDFBlockType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestPDFBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestPDFBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestPDFBlockType value)
        {
            return value switch
            {
                BetaRequestPDFBlockType.Document => "document",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestPDFBlockType? ToEnum(string value)
        {
            return value switch
            {
                "document" => BetaRequestPDFBlockType.Document,
                _ => null,
            };
        }
    }
}