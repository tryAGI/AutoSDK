//HintName: G.Models.SessionAnnotationAnnotatorKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The kind of annotator used for the annotation
    /// </summary>
    public enum SessionAnnotationAnnotatorKind
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
    public static class SessionAnnotationAnnotatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionAnnotationAnnotatorKind value)
        {
            return value switch
            {
                SessionAnnotationAnnotatorKind.Code => "CODE",
                SessionAnnotationAnnotatorKind.Human => "HUMAN",
                SessionAnnotationAnnotatorKind.Llm => "LLM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionAnnotationAnnotatorKind? ToEnum(string value)
        {
            return value switch
            {
                "CODE" => SessionAnnotationAnnotatorKind.Code,
                "HUMAN" => SessionAnnotationAnnotatorKind.Human,
                "LLM" => SessionAnnotationAnnotatorKind.Llm,
                _ => null,
            };
        }
    }
}