//HintName: G.Models.BetaPlainTextSourceMediaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaPlainTextSourceMediaType
    {
        /// <summary>
        /// 
        /// </summary>
        TextPlain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPlainTextSourceMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPlainTextSourceMediaType value)
        {
            return value switch
            {
                BetaPlainTextSourceMediaType.TextPlain => "text/plain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPlainTextSourceMediaType? ToEnum(string value)
        {
            return value switch
            {
                "text/plain" => BetaPlainTextSourceMediaType.TextPlain,
                _ => null,
            };
        }
    }
}