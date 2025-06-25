//HintName: G.Models.EmbedVariant.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbedVariant
    {
        /// <summary>
        /// 
        /// </summary>
        Tiny,
        /// <summary>
        /// 
        /// </summary>
        Compact,
        /// <summary>
        /// 
        /// </summary>
        Full,
        /// <summary>
        /// 
        /// </summary>
        Expandable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbedVariantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbedVariant value)
        {
            return value switch
            {
                EmbedVariant.Tiny => "tiny",
                EmbedVariant.Compact => "compact",
                EmbedVariant.Full => "full",
                EmbedVariant.Expandable => "expandable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbedVariant? ToEnum(string value)
        {
            return value switch
            {
                "tiny" => EmbedVariant.Tiny,
                "compact" => EmbedVariant.Compact,
                "full" => EmbedVariant.Full,
                "expandable" => EmbedVariant.Expandable,
                _ => null,
            };
        }
    }
}