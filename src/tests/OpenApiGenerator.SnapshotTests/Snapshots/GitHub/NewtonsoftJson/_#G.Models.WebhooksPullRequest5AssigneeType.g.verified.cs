//HintName: G.Models.WebhooksPullRequest5AssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksPullRequest5AssigneeType
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksPullRequest5AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5AssigneeType value)
        {
            return value switch
            {
                WebhooksPullRequest5AssigneeType.Bot => "Bot",
                WebhooksPullRequest5AssigneeType.User => "User",
                WebhooksPullRequest5AssigneeType.Organization => "Organization",
                WebhooksPullRequest5AssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5AssigneeType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksPullRequest5AssigneeType.Bot,
                "User" => WebhooksPullRequest5AssigneeType.User,
                "Organization" => WebhooksPullRequest5AssigneeType.Organization,
                "Mannequin" => WebhooksPullRequest5AssigneeType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}