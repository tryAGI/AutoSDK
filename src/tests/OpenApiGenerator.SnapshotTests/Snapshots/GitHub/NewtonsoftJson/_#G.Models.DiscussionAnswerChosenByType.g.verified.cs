//HintName: G.Models.DiscussionAnswerChosenByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DiscussionAnswerChosenByType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiscussionAnswerChosenByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiscussionAnswerChosenByType value)
        {
            return value switch
            {
                DiscussionAnswerChosenByType.Bot => "Bot",
                DiscussionAnswerChosenByType.User => "User",
                DiscussionAnswerChosenByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiscussionAnswerChosenByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => DiscussionAnswerChosenByType.Bot,
                "User" => DiscussionAnswerChosenByType.User,
                "Organization" => DiscussionAnswerChosenByType.Organization,
                _ => null,
            };
        }
    }
}