//HintName: G.Models.AnnotationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of annotation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AnnotationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="document_citation")]
        DocumentCitation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function_citation")]
        FunctionCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationType value)
        {
            return value switch
            {
                AnnotationType.DocumentCitation => "document_citation",
                AnnotationType.FunctionCitation => "function_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationType? ToEnum(string value)
        {
            return value switch
            {
                "document_citation" => AnnotationType.DocumentCitation,
                "function_citation" => AnnotationType.FunctionCitation,
                _ => null,
            };
        }
    }
}