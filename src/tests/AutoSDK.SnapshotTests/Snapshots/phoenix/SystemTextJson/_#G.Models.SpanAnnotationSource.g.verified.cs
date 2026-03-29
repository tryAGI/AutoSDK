//HintName: G.Models.SpanAnnotationSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SpanAnnotationSource
    {
        /// <summary>
        /// 
        /// </summary>
        Api,
        /// <summary>
        /// 
        /// </summary>
        App,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpanAnnotationSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanAnnotationSource value)
        {
            return value switch
            {
                SpanAnnotationSource.Api => "API",
                SpanAnnotationSource.App => "APP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanAnnotationSource? ToEnum(string value)
        {
            return value switch
            {
                "API" => SpanAnnotationSource.Api,
                "APP" => SpanAnnotationSource.App,
                _ => null,
            };
        }
    }
}