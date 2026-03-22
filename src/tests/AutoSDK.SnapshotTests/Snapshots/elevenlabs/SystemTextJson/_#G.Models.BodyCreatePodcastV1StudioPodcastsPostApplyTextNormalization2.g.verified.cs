//HintName: G.Models.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2
    {
        /// <summary>
        /// 
        /// </summary>
        ApplyEnglish,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Off,
        /// <summary>
        /// 
        /// </summary>
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2 value)
        {
            return value switch
            {
                BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2.ApplyEnglish => "apply_english",
                BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2.Auto => "auto",
                BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2.Off => "off",
                BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2? ToEnum(string value)
        {
            return value switch
            {
                "apply_english" => BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2.ApplyEnglish,
                "auto" => BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2.Auto,
                "off" => BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2.Off,
                "on" => BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization2.On,
                _ => null,
            };
        }
    }
}