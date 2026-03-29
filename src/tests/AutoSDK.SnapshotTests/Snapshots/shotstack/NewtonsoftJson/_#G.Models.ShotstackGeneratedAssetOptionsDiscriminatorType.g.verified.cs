//HintName: G.Models.ShotstackGeneratedAssetOptionsDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ShotstackGeneratedAssetOptionsDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image-to-video")]
        ImageToVideo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-generator")]
        TextGenerator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-to-image")]
        TextToImage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text-to-speech")]
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