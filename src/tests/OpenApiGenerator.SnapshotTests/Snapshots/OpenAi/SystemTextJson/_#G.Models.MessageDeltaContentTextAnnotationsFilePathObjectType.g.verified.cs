//HintName: G.Models.MessageDeltaContentTextAnnotationsFilePathObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `file_path`.
    /// </summary>
    public enum MessageDeltaContentTextAnnotationsFilePathObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        FilePath,
    }

    public static class MessageDeltaContentTextAnnotationsFilePathObjectTypeExtensions
    {
        public static string ToValueString(this MessageDeltaContentTextAnnotationsFilePathObjectType value)
        {
            return value switch
            {
                MessageDeltaContentTextAnnotationsFilePathObjectType.FilePath => "file_path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageDeltaContentTextAnnotationsFilePathObjectType ToEnum(string value)
        {
            return value switch
            {
                "file_path" => MessageDeltaContentTextAnnotationsFilePathObjectType.FilePath,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageDeltaContentTextAnnotationsFilePathObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => MessageDeltaContentTextAnnotationsFilePathObjectType.FilePath,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}