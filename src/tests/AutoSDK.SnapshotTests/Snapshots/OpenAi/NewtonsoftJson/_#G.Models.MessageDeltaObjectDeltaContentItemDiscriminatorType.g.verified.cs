//HintName: G.Models.MessageDeltaObjectDeltaContentItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageDeltaObjectDeltaContentItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_file")]
        ImageFile,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="refusal")]
        Refusal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_url")]
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageDeltaObjectDeltaContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDeltaObjectDeltaContentItemDiscriminatorType value)
        {
            return value switch
            {
                MessageDeltaObjectDeltaContentItemDiscriminatorType.ImageFile => "image_file",
                MessageDeltaObjectDeltaContentItemDiscriminatorType.Text => "text",
                MessageDeltaObjectDeltaContentItemDiscriminatorType.Refusal => "refusal",
                MessageDeltaObjectDeltaContentItemDiscriminatorType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDeltaObjectDeltaContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image_file" => MessageDeltaObjectDeltaContentItemDiscriminatorType.ImageFile,
                "text" => MessageDeltaObjectDeltaContentItemDiscriminatorType.Text,
                "refusal" => MessageDeltaObjectDeltaContentItemDiscriminatorType.Refusal,
                "image_url" => MessageDeltaObjectDeltaContentItemDiscriminatorType.ImageUrl,
                _ => null,
            };
        }
    }
}