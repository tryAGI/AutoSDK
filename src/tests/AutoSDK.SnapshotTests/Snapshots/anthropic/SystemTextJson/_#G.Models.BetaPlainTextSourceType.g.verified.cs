//HintName: G.Models.BetaPlainTextSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaPlainTextSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPlainTextSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPlainTextSourceType value)
        {
            return value switch
            {
                BetaPlainTextSourceType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPlainTextSourceType? ToEnum(string value)
        {
            return value switch
            {
                "text" => BetaPlainTextSourceType.Text,
                _ => null,
            };
        }
    }
}