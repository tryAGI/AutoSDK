//HintName: G.Models.CreateMessageRequestContentVariant2ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateMessageRequestContentVariant2ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageFile,
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMessageRequestContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMessageRequestContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                CreateMessageRequestContentVariant2ItemDiscriminatorType.ImageFile => "image_file",
                CreateMessageRequestContentVariant2ItemDiscriminatorType.ImageUrl => "image_url",
                CreateMessageRequestContentVariant2ItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMessageRequestContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image_file" => CreateMessageRequestContentVariant2ItemDiscriminatorType.ImageFile,
                "image_url" => CreateMessageRequestContentVariant2ItemDiscriminatorType.ImageUrl,
                "text" => CreateMessageRequestContentVariant2ItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}