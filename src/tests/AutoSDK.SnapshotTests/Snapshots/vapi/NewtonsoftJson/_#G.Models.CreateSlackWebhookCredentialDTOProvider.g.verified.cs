//HintName: G.Models.CreateSlackWebhookCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSlackWebhookCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slack-webhook")]
        SlackWebhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSlackWebhookCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSlackWebhookCredentialDTOProvider value)
        {
            return value switch
            {
                CreateSlackWebhookCredentialDTOProvider.SlackWebhook => "slack-webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSlackWebhookCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "slack-webhook" => CreateSlackWebhookCredentialDTOProvider.SlackWebhook,
                _ => null,
            };
        }
    }
}