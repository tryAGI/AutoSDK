//HintName: G.Models.WebhookPullRequestConvertedToDraftAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestConvertedToDraftAction
    {
        /// <summary>
        /// 
        /// </summary>
        ConvertedToDraft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestConvertedToDraftActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestConvertedToDraftAction value)
        {
            return value switch
            {
                WebhookPullRequestConvertedToDraftAction.ConvertedToDraft => "converted_to_draft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestConvertedToDraftAction ToEnum(string value)
        {
            return value switch
            {
                "converted_to_draft" => WebhookPullRequestConvertedToDraftAction.ConvertedToDraft,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}