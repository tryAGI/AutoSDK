//HintName: G.Models.SpanDocumentAnnotationDataAnnotatorKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The kind of annotator used for the annotation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SpanDocumentAnnotationDataAnnotatorKind
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
    public static class SpanDocumentAnnotationDataAnnotatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpanDocumentAnnotationDataAnnotatorKind value)
        {
            return value switch
            {
                SpanDocumentAnnotationDataAnnotatorKind.Code => "CODE",
                SpanDocumentAnnotationDataAnnotatorKind.Human => "HUMAN",
                SpanDocumentAnnotationDataAnnotatorKind.Llm => "LLM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpanDocumentAnnotationDataAnnotatorKind? ToEnum(string value)
        {
            return value switch
            {
                "CODE" => SpanDocumentAnnotationDataAnnotatorKind.Code,
                "HUMAN" => SpanDocumentAnnotationDataAnnotatorKind.Human,
                "LLM" => SpanDocumentAnnotationDataAnnotatorKind.Llm,
                _ => null,
            };
        }
    }
}