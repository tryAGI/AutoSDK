//HintName: G.Models.ImageAiModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageAiModel
    {
        /// <summary>
        /// 
        /// </summary>
        NanoBanana,
        /// <summary>
        /// 
        /// </summary>
        NanoBananaPro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageAiModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageAiModel value)
        {
            return value switch
            {
                ImageAiModel.NanoBanana => "nano-banana",
                ImageAiModel.NanoBananaPro => "nano-banana-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageAiModel? ToEnum(string value)
        {
            return value switch
            {
                "nano-banana" => ImageAiModel.NanoBanana,
                "nano-banana-pro" => ImageAiModel.NanoBananaPro,
                _ => null,
            };
        }
    }
}