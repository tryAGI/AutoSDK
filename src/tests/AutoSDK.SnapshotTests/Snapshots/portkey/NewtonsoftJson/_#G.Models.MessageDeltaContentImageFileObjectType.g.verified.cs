//HintName: G.Models.MessageDeltaContentImageFileObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `image_file`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageDeltaContentImageFileObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_file")]
        ImageFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageDeltaContentImageFileObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDeltaContentImageFileObjectType value)
        {
            return value switch
            {
                MessageDeltaContentImageFileObjectType.ImageFile => "image_file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDeltaContentImageFileObjectType? ToEnum(string value)
        {
            return value switch
            {
                "image_file" => MessageDeltaContentImageFileObjectType.ImageFile,
                _ => null,
            };
        }
    }
}