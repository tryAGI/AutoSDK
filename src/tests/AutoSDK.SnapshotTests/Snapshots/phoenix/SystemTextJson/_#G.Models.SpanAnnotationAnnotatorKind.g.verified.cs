//HintName: G.Models.SpanAnnotationAnnotatorKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The kind of annotator used for the annotation
    /// </summary>
    public enum SpanAnnotationAnnotatorKind
    {
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        Human,
        /// <summary>
        /// 
        /// </summary>
        Llm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpanAnnotationAnnotatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanAnnotationAnnotatorKind value)
        {
            return value switch
            {
                SpanAnnotationAnnotatorKind.Code => "CODE",
                SpanAnnotationAnnotatorKind.Human => "HUMAN",
                SpanAnnotationAnnotatorKind.Llm => "LLM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanAnnotationAnnotatorKind? ToEnum(string value)
        {
            return value switch
            {
                "CODE" => SpanAnnotationAnnotatorKind.Code,
                "HUMAN" => SpanAnnotationAnnotatorKind.Human,
                "LLM" => SpanAnnotationAnnotatorKind.Llm,
                _ => null,
            };
        }
    }
}