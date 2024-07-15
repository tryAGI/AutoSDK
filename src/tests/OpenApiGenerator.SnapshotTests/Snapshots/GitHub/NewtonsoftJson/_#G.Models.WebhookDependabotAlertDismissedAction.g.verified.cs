//HintName: G.Models.WebhookDependabotAlertDismissedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDependabotAlertDismissedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dismissed")]
        Dismissed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDependabotAlertDismissedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDependabotAlertDismissedAction value)
        {
            return value switch
            {
                WebhookDependabotAlertDismissedAction.Dismissed => "dismissed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDependabotAlertDismissedAction? ToEnum(string value)
        {
            return value switch
            {
                "dismissed" => WebhookDependabotAlertDismissedAction.Dismissed,
                _ => null,
            };
        }
    }
}