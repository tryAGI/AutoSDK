//HintName: G.Models.BodyCreatePodcastV1StudioPodcastsPostQualityPreset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output quality of the generated audio. Must be one of:<br/>
    /// standard - standard output format, 128kbps with 44.1kHz sample rate.<br/>
    /// high - high quality output format, 192kbps with 44.1kHz sample rate and major improvements on our side. Using this setting increases the credit cost by 20%.<br/>
    /// ultra - ultra quality output format, 192kbps with 44.1kHz sample rate and highest improvements on our side. Using this setting increases the credit cost by 50%.<br/>
    /// ultra lossless - ultra quality output format, 705.6kbps with 44.1kHz sample rate and highest improvements on our side in a fully lossless format. Using this setting increases the credit cost by 100%.<br/>
    /// Default Value: standard
    /// </summary>
    public enum BodyCreatePodcastV1StudioPodcastsPostQualityPreset
    {
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Highest,
        /// <summary>
        /// 
        /// </summary>
        Ultra,
        /// <summary>
        /// 
        /// </summary>
        UltraLossless,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyCreatePodcastV1StudioPodcastsPostQualityPresetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreatePodcastV1StudioPodcastsPostQualityPreset value)
        {
            return value switch
            {
                BodyCreatePodcastV1StudioPodcastsPostQualityPreset.Standard => "standard",
                BodyCreatePodcastV1StudioPodcastsPostQualityPreset.High => "high",
                BodyCreatePodcastV1StudioPodcastsPostQualityPreset.Highest => "highest",
                BodyCreatePodcastV1StudioPodcastsPostQualityPreset.Ultra => "ultra",
                BodyCreatePodcastV1StudioPodcastsPostQualityPreset.UltraLossless => "ultra_lossless",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreatePodcastV1StudioPodcastsPostQualityPreset? ToEnum(string value)
        {
            return value switch
            {
                "standard" => BodyCreatePodcastV1StudioPodcastsPostQualityPreset.Standard,
                "high" => BodyCreatePodcastV1StudioPodcastsPostQualityPreset.High,
                "highest" => BodyCreatePodcastV1StudioPodcastsPostQualityPreset.Highest,
                "ultra" => BodyCreatePodcastV1StudioPodcastsPostQualityPreset.Ultra,
                "ultra_lossless" => BodyCreatePodcastV1StudioPodcastsPostQualityPreset.UltraLossless,
                _ => null,
            };
        }
    }
}