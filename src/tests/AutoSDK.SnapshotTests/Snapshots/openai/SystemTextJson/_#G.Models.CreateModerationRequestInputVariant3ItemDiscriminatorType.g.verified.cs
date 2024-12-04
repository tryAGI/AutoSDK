//HintName: G.Models.CreateModerationRequestInputVariant3ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModerationRequestInputVariant3ItemDiscriminatorType
    {
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
    public static class CreateModerationRequestInputVariant3ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModerationRequestInputVariant3ItemDiscriminatorType value)
        {
            return value switch
            {
                CreateModerationRequestInputVariant3ItemDiscriminatorType.ImageUrl => "image_url",
                CreateModerationRequestInputVariant3ItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModerationRequestInputVariant3ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => CreateModerationRequestInputVariant3ItemDiscriminatorType.ImageUrl,
                "text" => CreateModerationRequestInputVariant3ItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}