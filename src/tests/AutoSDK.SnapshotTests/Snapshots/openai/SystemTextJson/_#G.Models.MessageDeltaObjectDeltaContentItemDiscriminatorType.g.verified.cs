//HintName: G.Models.MessageDeltaObjectDeltaContentItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageDeltaObjectDeltaContentItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageFile,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Refusal,
        /// <summary>
        /// 
        /// </summary>
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