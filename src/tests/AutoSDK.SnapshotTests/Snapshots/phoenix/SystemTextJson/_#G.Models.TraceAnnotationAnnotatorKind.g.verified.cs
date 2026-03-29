//HintName: G.Models.TraceAnnotationAnnotatorKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The kind of annotator used for the annotation
    /// </summary>
    public enum TraceAnnotationAnnotatorKind
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
    public static class TraceAnnotationAnnotatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceAnnotationAnnotatorKind value)
        {
            return value switch
            {
                TraceAnnotationAnnotatorKind.Code => "CODE",
                TraceAnnotationAnnotatorKind.Human => "HUMAN",
                TraceAnnotationAnnotatorKind.Llm => "LLM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceAnnotationAnnotatorKind? ToEnum(string value)
        {
            return value switch
            {
                "CODE" => TraceAnnotationAnnotatorKind.Code,
                "HUMAN" => TraceAnnotationAnnotatorKind.Human,
                "LLM" => TraceAnnotationAnnotatorKind.Llm,
                _ => null,
            };
        }
    }
}