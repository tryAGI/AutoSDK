//HintName: G.Models.WebhookProjectColumnCreatedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookProjectColumnCreatedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookProjectColumnCreatedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookProjectColumnCreatedAction value)
        {
            return value switch
            {
                WebhookProjectColumnCreatedAction.Created => "created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookProjectColumnCreatedAction ToEnum(string value)
        {
            return value switch
            {
                "created" => WebhookProjectColumnCreatedAction.Created,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}