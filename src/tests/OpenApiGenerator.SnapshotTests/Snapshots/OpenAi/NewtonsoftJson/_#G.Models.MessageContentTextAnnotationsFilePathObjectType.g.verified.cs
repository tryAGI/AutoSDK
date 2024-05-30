//HintName: G.Models.MessageContentTextAnnotationsFilePathObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `file_path`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageContentTextAnnotationsFilePathObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_path")]
        FilePath,
    }

    public static class MessageContentTextAnnotationsFilePathObjectTypeExtensions
    {
        public static string ToValueString(this MessageContentTextAnnotationsFilePathObjectType value)
        {
            return value switch
            {
                MessageContentTextAnnotationsFilePathObjectType.FilePath => "file_path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageContentTextAnnotationsFilePathObjectType ToEnum(string value)
        {
            return value switch
            {
                "file_path" => MessageContentTextAnnotationsFilePathObjectType.FilePath,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageContentTextAnnotationsFilePathObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => MessageContentTextAnnotationsFilePathObjectType.FilePath,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}