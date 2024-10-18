//HintName: G.Models.MessageDeltaContentTextObjectTextAnnotationDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageDeltaContentTextObjectTextAnnotationDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        FileCitation,
        /// <summary>
        /// 
        /// </summary>
        FilePath,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageDeltaContentTextObjectTextAnnotationDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDeltaContentTextObjectTextAnnotationDiscriminatorType value)
        {
            return value switch
            {
                MessageDeltaContentTextObjectTextAnnotationDiscriminatorType.FileCitation => "file_citation",
                MessageDeltaContentTextObjectTextAnnotationDiscriminatorType.FilePath => "file_path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDeltaContentTextObjectTextAnnotationDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file_citation" => MessageDeltaContentTextObjectTextAnnotationDiscriminatorType.FileCitation,
                "file_path" => MessageDeltaContentTextObjectTextAnnotationDiscriminatorType.FilePath,
                _ => null,
            };
        }
    }
}