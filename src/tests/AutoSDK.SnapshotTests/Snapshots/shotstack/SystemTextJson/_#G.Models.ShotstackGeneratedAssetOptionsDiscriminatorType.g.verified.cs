//HintName: G.Models.ShotstackGeneratedAssetOptionsDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ShotstackGeneratedAssetOptionsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageToVideo,
        /// <summary>
        /// 
        /// </summary>
        TextGenerator,
        /// <summary>
        /// 
        /// </summary>
        TextToImage,
        /// <summary>
        /// 
        /// </summary>
        TextToSpeech,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShotstackGeneratedAssetOptionsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShotstackGeneratedAssetOptionsDiscriminatorType value)
        {
            return value switch
            {
                ShotstackGeneratedAssetOptionsDiscriminatorType.ImageToVideo => "image-to-video",
                ShotstackGeneratedAssetOptionsDiscriminatorType.TextGenerator => "text-generator",
                ShotstackGeneratedAssetOptionsDiscriminatorType.TextToImage => "text-to-image",
                ShotstackGeneratedAssetOptionsDiscriminatorType.TextToSpeech => "text-to-speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShotstackGeneratedAssetOptionsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image-to-video" => ShotstackGeneratedAssetOptionsDiscriminatorType.ImageToVideo,
                "text-generator" => ShotstackGeneratedAssetOptionsDiscriminatorType.TextGenerator,
                "text-to-image" => ShotstackGeneratedAssetOptionsDiscriminatorType.TextToImage,
                "text-to-speech" => ShotstackGeneratedAssetOptionsDiscriminatorType.TextToSpeech,
                _ => null,
            };
        }
    }
}