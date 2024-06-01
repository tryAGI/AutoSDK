//HintName: G.Models.WebhookBranchProtectionConfigurationDisabledAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookBranchProtectionConfigurationDisabledAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookBranchProtectionConfigurationDisabledActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookBranchProtectionConfigurationDisabledAction value)
        {
            return value switch
            {
                WebhookBranchProtectionConfigurationDisabledAction.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookBranchProtectionConfigurationDisabledAction ToEnum(string value)
        {
            return value switch
            {
                "disabled" => WebhookBranchProtectionConfigurationDisabledAction.Disabled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}