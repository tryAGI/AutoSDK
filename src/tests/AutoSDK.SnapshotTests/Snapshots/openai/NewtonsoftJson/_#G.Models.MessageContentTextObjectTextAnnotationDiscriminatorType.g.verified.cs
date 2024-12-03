//HintName: G.Models.MessageContentTextObjectTextAnnotationDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageContentTextObjectTextAnnotationDiscriminatorType
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageContentTextObjectTextAnnotationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageContentTextObjectTextAnnotationDiscriminatorType value)
        {
            return value switch
            {
                MessageContentTextObjectTextAnnotationDiscriminatorType.FileCitation => "file_citation",
                MessageContentTextObjectTextAnnotationDiscriminatorType.FilePath => "file_path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageContentTextObjectTextAnnotationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file_citation" => MessageContentTextObjectTextAnnotationDiscriminatorType.FileCitation,
                "file_path" => MessageContentTextObjectTextAnnotationDiscriminatorType.FilePath,
                _ => null,
            };
        }
    }
}