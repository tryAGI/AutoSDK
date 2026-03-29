//HintName: G.Models.SpanKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpanKind
    {
        /// <summary>
        /// 
        /// </summary>
        Client,
        /// <summary>
        /// 
        /// </summary>
        Consumer,
        /// <summary>
        /// 
        /// </summary>
        Internal,
        /// <summary>
        /// 
        /// </summary>
        Producer,
        /// <summary>
        /// 
        /// </summary>
        Server,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpanKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanKind value)
        {
            return value switch
            {
                SpanKind.Client => "SpanKind.CLIENT",
                SpanKind.Consumer => "SpanKind.CONSUMER",
                SpanKind.Internal => "SpanKind.INTERNAL",
                SpanKind.Producer => "SpanKind.PRODUCER",
                SpanKind.Server => "SpanKind.SERVER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanKind? ToEnum(string value)
        {
            return value switch
            {
                "SpanKind.CLIENT" => SpanKind.Client,
                "SpanKind.CONSUMER" => SpanKind.Consumer,
                "SpanKind.INTERNAL" => SpanKind.Internal,
                "SpanKind.PRODUCER" => SpanKind.Producer,
                "SpanKind.SERVER" => SpanKind.Server,
                _ => null,
            };
        }
    }
}