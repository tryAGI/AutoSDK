//HintName: G.Models.WebhookPersonalAccessTokenRequestApprovedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPersonalAccessTokenRequestApprovedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Approved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPersonalAccessTokenRequestApprovedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPersonalAccessTokenRequestApprovedAction value)
        {
            return value switch
            {
                WebhookPersonalAccessTokenRequestApprovedAction.Approved => "approved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPersonalAccessTokenRequestApprovedAction? ToEnum(string value)
        {
            return value switch
            {
                "approved" => WebhookPersonalAccessTokenRequestApprovedAction.Approved,
                _ => null,
            };
        }
    }
}