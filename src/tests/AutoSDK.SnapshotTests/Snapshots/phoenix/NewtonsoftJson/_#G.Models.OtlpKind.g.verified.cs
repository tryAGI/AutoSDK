//HintName: G.Models.OtlpKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OtlpKind
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SPAN_KIND_CLIENT")]
        SpanKindClient,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SPAN_KIND_CONSUMER")]
        SpanKindConsumer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SPAN_KIND_INTERNAL")]
        SpanKindInternal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SPAN_KIND_PRODUCER")]
        SpanKindProducer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SPAN_KIND_SERVER")]
        SpanKindServer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SPAN_KIND_UNSPECIFIED")]
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