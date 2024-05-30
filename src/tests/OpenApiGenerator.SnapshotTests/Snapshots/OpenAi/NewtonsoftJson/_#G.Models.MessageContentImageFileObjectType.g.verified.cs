//HintName: G.Models.MessageContentImageFileObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `image_file`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageContentImageFileObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_file")]
        ImageFile,
    }

    public static class MessageContentImageFileObjectTypeExtensions
    {
        public static string ToValueString(this MessageContentImageFileObjectType value)
        {
            return value switch
            {
                MessageContentImageFileObjectType.ImageFile => "image_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageContentImageFileObjectType ToEnum(string value)
        {
            return value switch
            {
                "image_file" => MessageContentImageFileObjectType.ImageFile,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageContentImageFileObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => MessageContentImageFileObjectType.ImageFile,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}