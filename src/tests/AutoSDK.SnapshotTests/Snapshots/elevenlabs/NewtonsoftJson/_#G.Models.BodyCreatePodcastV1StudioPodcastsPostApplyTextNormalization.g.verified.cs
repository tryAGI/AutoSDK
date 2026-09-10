//HintName: G.Models.BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="apply_english")]
        ApplyEnglish,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off")]
        Off,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="on")]
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization value)
        {
            return value switch
            {
                BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization.ApplyEnglish => "apply_english",
                BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization.Auto => "auto",
                BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization.Off => "off",
                BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization? ToEnum(string value)
        {
            return value switch
            {
                "apply_english" => BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization.ApplyEnglish,
                "auto" => BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization.Auto,
                "off" => BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization.Off,
                "on" => BodyCreatePodcastV1StudioPodcastsPostApplyTextNormalization.On,
                _ => null,
            };
        }
    }
}