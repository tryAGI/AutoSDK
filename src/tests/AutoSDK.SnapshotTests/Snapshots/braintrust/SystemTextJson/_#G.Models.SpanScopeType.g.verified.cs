//HintName: G.Models.SpanScopeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpanScopeType
    {
        /// <summary>
        /// 
        /// </summary>
        Span,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpanScopeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanScopeType value)
        {
            return value switch
            {
                SpanScopeType.Span => "span",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanScopeType? ToEnum(string value)
        {
            return value switch
            {
                "span" => SpanScopeType.Span,
                _ => null,
            };
        }
    }
}