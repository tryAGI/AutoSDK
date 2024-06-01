//HintName: G.Models.WebhookDeploymentProtectionRuleRequestedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentProtectionRuleRequestedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Requested,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentProtectionRuleRequestedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentProtectionRuleRequestedAction value)
        {
            return value switch
            {
                WebhookDeploymentProtectionRuleRequestedAction.Requested => "requested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentProtectionRuleRequestedAction ToEnum(string value)
        {
            return value switch
            {
                "requested" => WebhookDeploymentProtectionRuleRequestedAction.Requested,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}