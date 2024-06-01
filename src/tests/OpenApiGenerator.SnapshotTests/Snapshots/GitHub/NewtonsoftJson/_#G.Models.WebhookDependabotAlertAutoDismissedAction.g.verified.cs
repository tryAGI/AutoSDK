//HintName: G.Models.WebhookDependabotAlertAutoDismissedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDependabotAlertAutoDismissedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto_dismissed")]
        AutoDismissed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDependabotAlertAutoDismissedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDependabotAlertAutoDismissedAction value)
        {
            return value switch
            {
                WebhookDependabotAlertAutoDismissedAction.AutoDismissed => "auto_dismissed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDependabotAlertAutoDismissedAction ToEnum(string value)
        {
            return value switch
            {
                "auto_dismissed" => WebhookDependabotAlertAutoDismissedAction.AutoDismissed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}