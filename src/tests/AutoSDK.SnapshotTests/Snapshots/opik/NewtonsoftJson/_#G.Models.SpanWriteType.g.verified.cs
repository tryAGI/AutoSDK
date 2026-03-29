//HintName: G.Models.SpanWriteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpanWriteType
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
    public static class SpanWriteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanWriteType value)
        {
            return value switch
            {
                SpanWriteType.General => "general",
                SpanWriteType.Guardrail => "guardrail",
                SpanWriteType.Llm => "llm",
                SpanWriteType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanWriteType? ToEnum(string value)
        {
            return value switch
            {
                "general" => SpanWriteType.General,
                "guardrail" => SpanWriteType.Guardrail,
                "llm" => SpanWriteType.Llm,
                "tool" => SpanWriteType.Tool,
                _ => null,
            };
        }
    }
}