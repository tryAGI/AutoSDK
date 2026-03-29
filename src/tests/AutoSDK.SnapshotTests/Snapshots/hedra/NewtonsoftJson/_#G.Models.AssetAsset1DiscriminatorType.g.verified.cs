//HintName: G.Models.AssetAsset1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssetAsset1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generated_audio")]
        GeneratedAudio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generated_image")]
        GeneratedImage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generated_video")]
        GeneratedVideo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uploaded_audio")]
        UploadedAudio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uploaded_image")]
        UploadedImage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uploaded_video")]
        UploadedVideo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="voice")]
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetAsset1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetAsset1DiscriminatorType value)
        {
            return value switch
            {
                AssetAsset1DiscriminatorType.GeneratedAudio => "generated_audio",
                AssetAsset1DiscriminatorType.GeneratedImage => "generated_image",
                AssetAsset1DiscriminatorType.GeneratedVideo => "generated_video",
                AssetAsset1DiscriminatorType.UploadedAudio => "uploaded_audio",
                AssetAsset1DiscriminatorType.UploadedImage => "uploaded_image",
                AssetAsset1DiscriminatorType.UploadedVideo => "uploaded_video",
                AssetAsset1DiscriminatorType.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetAsset1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "generated_audio" => AssetAsset1DiscriminatorType.GeneratedAudio,
                "generated_image" => AssetAsset1DiscriminatorType.GeneratedImage,
                "generated_video" => AssetAsset1DiscriminatorType.GeneratedVideo,
                "uploaded_audio" => AssetAsset1DiscriminatorType.UploadedAudio,
                "uploaded_image" => AssetAsset1DiscriminatorType.UploadedImage,
                "uploaded_video" => AssetAsset1DiscriminatorType.UploadedVideo,
                "voice" => AssetAsset1DiscriminatorType.Voice,
                _ => null,
            };
        }
    }
}