//HintName: G.Models.WebhookDependabotAlertAutoReopenedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDependabotAlertAutoReopenedAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto_reopened")]
        AutoReopened,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDependabotAlertAutoReopenedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDependabotAlertAutoReopenedAction value)
        {
            return value switch
            {
                WebhookDependabotAlertAutoReopenedAction.AutoReopened => "auto_reopened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDependabotAlertAutoReopenedAction? ToEnum(string value)
        {
            return value switch
            {
                "auto_reopened" => WebhookDependabotAlertAutoReopenedAction.AutoReopened,
                _ => null,
            };
        }
    }
}