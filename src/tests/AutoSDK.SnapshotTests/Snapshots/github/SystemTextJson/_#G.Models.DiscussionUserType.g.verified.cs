//HintName: G.Models.DiscussionUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DiscussionUserType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiscussionUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiscussionUserType value)
        {
            return value switch
            {
                DiscussionUserType.Bot => "Bot",
                DiscussionUserType.Organization => "Organization",
                DiscussionUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiscussionUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => DiscussionUserType.Bot,
                "Organization" => DiscussionUserType.Organization,
                "User" => DiscussionUserType.User,
                _ => null,
            };
        }
    }
}