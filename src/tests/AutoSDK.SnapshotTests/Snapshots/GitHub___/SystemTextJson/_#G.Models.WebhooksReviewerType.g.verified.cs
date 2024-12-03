//HintName: G.Models.WebhooksReviewerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksReviewerType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksReviewerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksReviewerType value)
        {
            return value switch
            {
                WebhooksReviewerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReviewerType? ToEnum(string value)
        {
            return value switch
            {
                "User" => WebhooksReviewerType.User,
                _ => null,
            };
        }
    }
}