//HintName: G.Models.AnnotationDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AnnotationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="container_file_citation")]
        ContainerFileCitation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_citation")]
        FileCitation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_path")]
        FilePath,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url_citation")]
        UrlCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationDiscriminatorType value)
        {
            return value switch
            {
                AnnotationDiscriminatorType.ContainerFileCitation => "container_file_citation",
                AnnotationDiscriminatorType.FileCitation => "file_citation",
                AnnotationDiscriminatorType.FilePath => "file_path",
                AnnotationDiscriminatorType.UrlCitation => "url_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "container_file_citation" => AnnotationDiscriminatorType.ContainerFileCitation,
                "file_citation" => AnnotationDiscriminatorType.FileCitation,
                "file_path" => AnnotationDiscriminatorType.FilePath,
                "url_citation" => AnnotationDiscriminatorType.UrlCitation,
                _ => null,
            };
        }
    }
}