//HintName: G.Models.WebhookCustomPropertyCreatedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCustomPropertyCreatedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCustomPropertyCreatedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCustomPropertyCreatedAction value)
        {
            return value switch
            {
                WebhookCustomPropertyCreatedAction.Created => "created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCustomPropertyCreatedAction ToEnum(string value)
        {
            return value switch
            {
                "created" => WebhookCustomPropertyCreatedAction.Created,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}