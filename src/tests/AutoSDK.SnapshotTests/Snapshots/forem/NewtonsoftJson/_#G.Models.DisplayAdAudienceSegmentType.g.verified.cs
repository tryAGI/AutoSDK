//HintName: G.Models.DisplayAdAudienceSegmentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies an group of users to show this ad to (only works with logged-in users)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DisplayAdAudienceSegmentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dark_theme")]
        DarkTheme,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experience1")]
        Experience1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experience2")]
        Experience2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experience3")]
        Experience3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experience4")]
        Experience4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experience5")]
        Experience5,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="light_theme")]
        LightTheme,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="no_experience")]
        NoExperience,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="no_posts_yet")]
        NoPostsYet,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="posted")]
        Posted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="testing")]
        Testing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trusted")]
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