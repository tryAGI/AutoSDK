//HintName: G.Models.SpanSearchStreamRequestPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpanSearchStreamRequestPublicType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="general")]
        General,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="guardrail")]
        Guardrail,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm")]
        Llm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpanSearchStreamRequestPublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanSearchStreamRequestPublicType value)
        {
            return value switch
            {
                SpanSearchStreamRequestPublicType.General => "general",
                SpanSearchStreamRequestPublicType.Guardrail => "guardrail",
                SpanSearchStreamRequestPublicType.Llm => "llm",
                SpanSearchStreamRequestPublicType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanSearchStreamRequestPublicType? ToEnum(string value)
        {
            return value switch
            {
                "general" => SpanSearchStreamRequestPublicType.General,
                "guardrail" => SpanSearchStreamRequestPublicType.Guardrail,
                "llm" => SpanSearchStreamRequestPublicType.Llm,
                "tool" => SpanSearchStreamRequestPublicType.Tool,
                _ => null,
            };
        }
    }
}