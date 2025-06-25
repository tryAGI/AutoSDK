//HintName: G.Models.WebhookBranchProtectionConfigurationEnabledAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookBranchProtectionConfigurationEnabledAction
    {
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookBranchProtectionConfigurationEnabledActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookBranchProtectionConfigurationEnabledAction value)
        {
            return value switch
            {
                WebhookBranchProtectionConfigurationEnabledAction.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookBranchProtectionConfigurationEnabledAction? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => WebhookBranchProtectionConfigurationEnabledAction.Enabled,
                _ => null,
            };
        }
    }
}