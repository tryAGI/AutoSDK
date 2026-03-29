//HintName: G.Models.OtlpKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OtlpKind
    {
        /// <summary>
        /// 
        /// </summary>
        SpanKindClient,
        /// <summary>
        /// 
        /// </summary>
        SpanKindConsumer,
        /// <summary>
        /// 
        /// </summary>
        SpanKindInternal,
        /// <summary>
        /// 
        /// </summary>
        SpanKindProducer,
        /// <summary>
        /// 
        /// </summary>
        SpanKindServer,
        /// <summary>
        /// 
        /// </summary>
        SpanKindUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OtlpKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OtlpKind value)
        {
            return value switch
            {
                OtlpKind.SpanKindClient => "SPAN_KIND_CLIENT",
                OtlpKind.SpanKindConsumer => "SPAN_KIND_CONSUMER",
                OtlpKind.SpanKindInternal => "SPAN_KIND_INTERNAL",
                OtlpKind.SpanKindProducer => "SPAN_KIND_PRODUCER",
                OtlpKind.SpanKindServer => "SPAN_KIND_SERVER",
                OtlpKind.SpanKindUnspecified => "SPAN_KIND_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OtlpKind? ToEnum(string value)
        {
            return value switch
            {
                "SPAN_KIND_CLIENT" => OtlpKind.SpanKindClient,
                "SPAN_KIND_CONSUMER" => OtlpKind.SpanKindConsumer,
                "SPAN_KIND_INTERNAL" => OtlpKind.SpanKindInternal,
                "SPAN_KIND_PRODUCER" => OtlpKind.SpanKindProducer,
                "SPAN_KIND_SERVER" => OtlpKind.SpanKindServer,
                "SPAN_KIND_UNSPECIFIED" => OtlpKind.SpanKindUnspecified,
                _ => null,
            };
        }
    }
}