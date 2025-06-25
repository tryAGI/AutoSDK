//HintName: G.Models.ImageGenToolModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The image generation model to use. Default: `gpt-image-1`.<br/>
    /// Default Value: gpt-image-1
    /// </summary>
    public enum ImageGenToolModel
    {
        /// <summary>
        /// `gpt-image-1`.
        /// </summary>
        GptImage1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenToolModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenToolModel value)
        {
            return value switch
            {
                ImageGenToolModel.GptImage1 => "gpt-image-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenToolModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-image-1" => ImageGenToolModel.GptImage1,
                _ => null,
            };
        }
    }
}