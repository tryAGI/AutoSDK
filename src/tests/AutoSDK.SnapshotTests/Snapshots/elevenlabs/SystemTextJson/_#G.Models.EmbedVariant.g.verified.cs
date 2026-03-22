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
        Compact,
        /// <summary>
        /// 
        /// </summary>
        Expandable,
        /// <summary>
        /// 
        /// </summary>
        Full,
        /// <summary>
        /// 
        /// </summary>
        Tiny,
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
                EmbedVariant.Compact => "compact",
                EmbedVariant.Expandable => "expandable",
                EmbedVariant.Full => "full",
                EmbedVariant.Tiny => "tiny",
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
                "compact" => EmbedVariant.Compact,
                "expandable" => EmbedVariant.Expandable,
                "full" => EmbedVariant.Full,
                "tiny" => EmbedVariant.Tiny,
                _ => null,
            };
        }
    }
}