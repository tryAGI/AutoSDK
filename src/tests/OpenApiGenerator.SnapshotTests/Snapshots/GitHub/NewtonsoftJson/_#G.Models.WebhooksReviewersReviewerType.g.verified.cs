//HintName: G.Models.WebhooksReviewersReviewerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksReviewersReviewerType
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
    public static class WebhooksReviewersReviewerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksReviewersReviewerType value)
        {
            return value switch
            {
                WebhooksReviewersReviewerType.Bot => "Bot",
                WebhooksReviewersReviewerType.User => "User",
                WebhooksReviewersReviewerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReviewersReviewerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksReviewersReviewerType.Bot,
                "User" => WebhooksReviewersReviewerType.User,
                "Organization" => WebhooksReviewersReviewerType.Organization,
                _ => null,
            };
        }
    }
}