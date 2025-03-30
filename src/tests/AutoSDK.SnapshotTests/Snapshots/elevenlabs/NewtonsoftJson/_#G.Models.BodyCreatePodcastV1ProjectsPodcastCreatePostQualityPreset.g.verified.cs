//HintName: G.Models.BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output quality of the generated audio. Must be one of:<br/>
    /// standard - standard output format, 128kbps with 44.1kHz sample rate.<br/>
    /// high - high quality output format, 192kbps with 44.1kHz sample rate and major improvements on our side. Using this setting increases the credit cost by 20%.<br/>
    /// ultra - ultra quality output format, 192kbps with 44.1kHz sample rate and highest improvements on our side. Using this setting increases the credit cost by 50%.<br/>
    /// ultra lossless - ultra quality output format, 705.6kbps with 44.1kHz sample rate and highest improvements on our side in a fully lossless format. Using this setting increases the credit cost by 100%.<br/>
    /// Default Value: standard<br/>
    /// Example: standard
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="standard")]
        Standard,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="highest")]
        Highest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ultra")]
        Ultra,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ultra_lossless")]
        UltraLossless,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset value)
        {
            return value switch
            {
                BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset.Standard => "standard",
                BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset.High => "high",
                BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset.Highest => "highest",
                BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset.Ultra => "ultra",
                BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset.UltraLossless => "ultra_lossless",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset? ToEnum(string value)
        {
            return value switch
            {
                "standard" => BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset.Standard,
                "high" => BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset.High,
                "highest" => BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset.Highest,
                "ultra" => BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset.Ultra,
                "ultra_lossless" => BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset.UltraLossless,
                _ => null,
            };
        }
    }
}