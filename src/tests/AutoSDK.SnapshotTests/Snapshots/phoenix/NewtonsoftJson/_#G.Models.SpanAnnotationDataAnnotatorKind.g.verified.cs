//HintName: G.Models.SpanAnnotationDataAnnotatorKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The kind of annotator used for the annotation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpanAnnotationDataAnnotatorKind
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CODE")]
        Code,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HUMAN")]
        Human,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LLM")]
        Llm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpanAnnotationDataAnnotatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanAnnotationDataAnnotatorKind value)
        {
            return value switch
            {
                SpanAnnotationDataAnnotatorKind.Code => "CODE",
                SpanAnnotationDataAnnotatorKind.Human => "HUMAN",
                SpanAnnotationDataAnnotatorKind.Llm => "LLM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanAnnotationDataAnnotatorKind? ToEnum(string value)
        {
            return value switch
            {
                "CODE" => SpanAnnotationDataAnnotatorKind.Code,
                "HUMAN" => SpanAnnotationDataAnnotatorKind.Human,
                "LLM" => SpanAnnotationDataAnnotatorKind.Llm,
                _ => null,
            };
        }
    }
}