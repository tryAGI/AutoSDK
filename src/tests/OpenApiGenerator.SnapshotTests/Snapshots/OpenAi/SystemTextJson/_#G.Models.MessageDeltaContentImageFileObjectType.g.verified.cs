//HintName: G.Models.MessageDeltaContentImageFileObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `image_file`.
    /// </summary>
    public enum MessageDeltaContentImageFileObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageFile,
    }

    public static class MessageDeltaContentImageFileObjectTypeExtensions
    {
        public static string ToValueString(this MessageDeltaContentImageFileObjectType value)
        {
            return value switch
            {
                MessageDeltaContentImageFileObjectType.ImageFile => "image_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageDeltaContentImageFileObjectType ToEnum(string value)
        {
            return value switch
            {
                "image_file" => MessageDeltaContentImageFileObjectType.ImageFile,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageDeltaContentImageFileObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => MessageDeltaContentImageFileObjectType.ImageFile,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}