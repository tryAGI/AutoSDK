//HintName: G.Models.DisplayAdAudienceSegmentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies an group of users to show this ad to (only works with logged-in users)
    /// </summary>
    public enum DisplayAdAudienceSegmentType
    {
        /// <summary>
        /// 
        /// </summary>
        DarkTheme,
        /// <summary>
        /// 
        /// </summary>
        Experience1,
        /// <summary>
        /// 
        /// </summary>
        Experience2,
        /// <summary>
        /// 
        /// </summary>
        Experience3,
        /// <summary>
        /// 
        /// </summary>
        Experience4,
        /// <summary>
        /// 
        /// </summary>
        Experience5,
        /// <summary>
        /// 
        /// </summary>
        LightTheme,
        /// <summary>
        /// 
        /// </summary>
        NoExperience,
        /// <summary>
        /// 
        /// </summary>
        NoPostsYet,
        /// <summary>
        /// 
        /// </summary>
        Posted,
        /// <summary>
        /// 
        /// </summary>
        Testing,
        /// <summary>
        /// 
        /// </summary>
        Trusted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DisplayAdAudienceSegmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DisplayAdAudienceSegmentType value)
        {
            return value switch
            {
                DisplayAdAudienceSegmentType.DarkTheme => "dark_theme",
                DisplayAdAudienceSegmentType.Experience1 => "experience1",
                DisplayAdAudienceSegmentType.Experience2 => "experience2",
                DisplayAdAudienceSegmentType.Experience3 => "experience3",
                DisplayAdAudienceSegmentType.Experience4 => "experience4",
                DisplayAdAudienceSegmentType.Experience5 => "experience5",
                DisplayAdAudienceSegmentType.LightTheme => "light_theme",
                DisplayAdAudienceSegmentType.NoExperience => "no_experience",
                DisplayAdAudienceSegmentType.NoPostsYet => "no_posts_yet",
                DisplayAdAudienceSegmentType.Posted => "posted",
                DisplayAdAudienceSegmentType.Testing => "testing",
                DisplayAdAudienceSegmentType.Trusted => "trusted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DisplayAdAudienceSegmentType? ToEnum(string value)
        {
            return value switch
            {
                "dark_theme" => DisplayAdAudienceSegmentType.DarkTheme,
                "experience1" => DisplayAdAudienceSegmentType.Experience1,
                "experience2" => DisplayAdAudienceSegmentType.Experience2,
                "experience3" => DisplayAdAudienceSegmentType.Experience3,
                "experience4" => DisplayAdAudienceSegmentType.Experience4,
                "experience5" => DisplayAdAudienceSegmentType.Experience5,
                "light_theme" => DisplayAdAudienceSegmentType.LightTheme,
                "no_experience" => DisplayAdAudienceSegmentType.NoExperience,
                "no_posts_yet" => DisplayAdAudienceSegmentType.NoPostsYet,
                "posted" => DisplayAdAudienceSegmentType.Posted,
                "testing" => DisplayAdAudienceSegmentType.Testing,
                "trusted" => DisplayAdAudienceSegmentType.Trusted,
                _ => null,
            };
        }
    }
}