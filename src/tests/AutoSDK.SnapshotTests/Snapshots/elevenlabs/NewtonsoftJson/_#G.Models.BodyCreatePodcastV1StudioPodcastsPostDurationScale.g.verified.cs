//HintName: G.Models.BodyCreatePodcastV1StudioPodcastsPostDurationScale.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Duration of the generated podcast. Must be one of:<br/>
    /// short - produces podcasts shorter than 3 minutes.<br/>
    /// default - produces podcasts roughly between 3-7 minutes.<br/>
    /// long - prodces podcasts longer than 7 minutes.<br/>
    /// Default Value: default<br/>
    /// Example: short
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyCreatePodcastV1StudioPodcastsPostDurationScale
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="short")]
        Short,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="long")]
        Long,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyCreatePodcastV1StudioPodcastsPostDurationScaleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreatePodcastV1StudioPodcastsPostDurationScale value)
        {
            return value switch
            {
                BodyCreatePodcastV1StudioPodcastsPostDurationScale.Short => "short",
                BodyCreatePodcastV1StudioPodcastsPostDurationScale.Default => "default",
                BodyCreatePodcastV1StudioPodcastsPostDurationScale.Long => "long",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreatePodcastV1StudioPodcastsPostDurationScale? ToEnum(string value)
        {
            return value switch
            {
                "short" => BodyCreatePodcastV1StudioPodcastsPostDurationScale.Short,
                "default" => BodyCreatePodcastV1StudioPodcastsPostDurationScale.Default,
                "long" => BodyCreatePodcastV1StudioPodcastsPostDurationScale.Long,
                _ => null,
            };
        }
    }
}