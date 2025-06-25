//HintName: G.Models.BetaResponseTextBlockType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: text
    /// </summary>
    public enum BetaResponseTextBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseTextBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseTextBlockType value)
        {
            return value switch
            {
                BetaResponseTextBlockType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseTextBlockType? ToEnum(string value)
        {
            return value switch
            {
                "text" => BetaResponseTextBlockType.Text,
                _ => null,
            };
        }
    }
}