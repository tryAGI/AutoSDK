//HintName: G.Models.WebhookDeployKeyCreatedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeployKeyCreatedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeployKeyCreatedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeployKeyCreatedAction value)
        {
            return value switch
            {
                WebhookDeployKeyCreatedAction.Created => "created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeployKeyCreatedAction? ToEnum(string value)
        {
            return value switch
            {
                "created" => WebhookDeployKeyCreatedAction.Created,
                _ => null,
            };
        }
    }
}