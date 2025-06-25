//HintName: G.Models.WebhookSecurityAdvisoryUpdatedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookSecurityAdvisoryUpdatedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSecurityAdvisoryUpdatedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSecurityAdvisoryUpdatedAction value)
        {
            return value switch
            {
                WebhookSecurityAdvisoryUpdatedAction.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSecurityAdvisoryUpdatedAction? ToEnum(string value)
        {
            return value switch
            {
                "updated" => WebhookSecurityAdvisoryUpdatedAction.Updated,
                _ => null,
            };
        }
    }
}