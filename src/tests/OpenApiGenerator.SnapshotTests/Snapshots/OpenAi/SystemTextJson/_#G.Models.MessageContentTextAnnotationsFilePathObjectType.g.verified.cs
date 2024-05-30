//HintName: G.Models.MessageContentTextAnnotationsFilePathObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `file_path`.
    /// </summary>
    public enum MessageContentTextAnnotationsFilePathObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        FilePath,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageContentTextAnnotationsFilePathObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageContentTextAnnotationsFilePathObjectType value)
        {
            return value switch
            {
                MessageContentTextAnnotationsFilePathObjectType.FilePath => "file_path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageContentTextAnnotationsFilePathObjectType ToEnum(string value)
        {
            return value switch
            {
                "file_path" => MessageContentTextAnnotationsFilePathObjectType.FilePath,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}