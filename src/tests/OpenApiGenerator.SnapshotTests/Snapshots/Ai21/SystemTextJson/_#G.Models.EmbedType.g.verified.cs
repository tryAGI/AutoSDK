//HintName: G.Models.EmbedType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum EmbedType
    {
        /// <summary>
        /// 
        /// </summary>
        Query,
        /// <summary>
        /// 
        /// </summary>
        Segment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbedType value)
        {
            return value switch
            {
                EmbedType.Query => "query",
                EmbedType.Segment => "segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbedType? ToEnum(string value)
        {
            return value switch
            {
                "query" => EmbedType.Query,
                "segment" => EmbedType.Segment,
                _ => null,
            };
        }
    }
}