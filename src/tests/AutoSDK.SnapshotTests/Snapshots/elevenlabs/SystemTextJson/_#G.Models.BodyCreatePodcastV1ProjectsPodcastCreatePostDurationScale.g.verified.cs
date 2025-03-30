//HintName: G.Models.BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScale.g.cs

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
    public enum BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScale
    {
        /// <summary>
        /// 
        /// </summary>
        Short,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Long,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScaleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScale value)
        {
            return value switch
            {
                BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScale.Short => "short",
                BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScale.Default => "default",
                BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScale.Long => "long",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScale? ToEnum(string value)
        {
            return value switch
            {
                "short" => BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScale.Short,
                "default" => BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScale.Default,
                "long" => BodyCreatePodcastV1ProjectsPodcastCreatePostDurationScale.Long,
                _ => null,
            };
        }
    }
}