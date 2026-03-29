//HintName: G.Models.SessionAnnotationDataAnnotatorKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The kind of annotator used for the annotation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SessionAnnotationDataAnnotatorKind
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
    public static class SessionAnnotationDataAnnotatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionAnnotationDataAnnotatorKind value)
        {
            return value switch
            {
                SessionAnnotationDataAnnotatorKind.Code => "CODE",
                SessionAnnotationDataAnnotatorKind.Human => "HUMAN",
                SessionAnnotationDataAnnotatorKind.Llm => "LLM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionAnnotationDataAnnotatorKind? ToEnum(string value)
        {
            return value switch
            {
                "CODE" => SessionAnnotationDataAnnotatorKind.Code,
                "HUMAN" => SessionAnnotationDataAnnotatorKind.Human,
                "LLM" => SessionAnnotationDataAnnotatorKind.Llm,
                _ => null,
            };
        }
    }
}