//HintName: G.Models.WebhooksReviewerReviewerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksReviewerReviewerType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksReviewerReviewerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksReviewerReviewerType value)
        {
            return value switch
            {
                WebhooksReviewerReviewerType.Bot => "Bot",
                WebhooksReviewerReviewerType.Organization => "Organization",
                WebhooksReviewerReviewerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReviewerReviewerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksReviewerReviewerType.Bot,
                "Organization" => WebhooksReviewerReviewerType.Organization,
                "User" => WebhooksReviewerReviewerType.User,
                _ => null,
            };
        }
    }
}