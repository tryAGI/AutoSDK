//HintName: G.Models.SlackWebhookCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SlackWebhookCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        SlackWebhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SlackWebhookCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SlackWebhookCredentialProvider value)
        {
            return value switch
            {
                SlackWebhookCredentialProvider.SlackWebhook => "slack-webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SlackWebhookCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "slack-webhook" => SlackWebhookCredentialProvider.SlackWebhook,
                _ => null,
            };
        }
    }
}