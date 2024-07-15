//HintName: G.Models.WebhookMilestoneOpenedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookMilestoneOpenedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Opened,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMilestoneOpenedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMilestoneOpenedAction value)
        {
            return value switch
            {
                WebhookMilestoneOpenedAction.Opened => "opened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMilestoneOpenedAction? ToEnum(string value)
        {
            return value switch
            {
                "opened" => WebhookMilestoneOpenedAction.Opened,
                _ => null,
            };
        }
    }
}