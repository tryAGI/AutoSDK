//HintName: G.Models.BetaContentBlockSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaContentBlockSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Content,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaContentBlockSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContentBlockSourceType value)
        {
            return value switch
            {
                BetaContentBlockSourceType.Content => "content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContentBlockSourceType? ToEnum(string value)
        {
            return value switch
            {
                "content" => BetaContentBlockSourceType.Content,
                _ => null,
            };
        }
    }
}