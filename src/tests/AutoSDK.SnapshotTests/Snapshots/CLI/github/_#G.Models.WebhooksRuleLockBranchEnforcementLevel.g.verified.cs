//HintName: G.Models.WebhooksRuleLockBranchEnforcementLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enforcement level of the branch lock setting. `off` means the branch is not locked, `non_admins` means the branch is read-only for non_admins, and `everyone` means the branch is read-only for everyone.
    /// </summary>
    public enum WebhooksRuleLockBranchEnforcementLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Off,
        /// <summary>
        /// 
        /// </summary>
        NonAdmins,
        /// <summary>
        /// 
        /// </summary>
        Everyone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksRuleLockBranchEnforcementLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksRuleLockBranchEnforcementLevel value)
        {
            return value switch
            {
                WebhooksRuleLockBranchEnforcementLevel.Off => "off",
                WebhooksRuleLockBranchEnforcementLevel.NonAdmins => "non_admins",
                WebhooksRuleLockBranchEnforcementLevel.Everyone => "everyone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksRuleLockBranchEnforcementLevel? ToEnum(string value)
        {
            return value switch
            {
                "off" => WebhooksRuleLockBranchEnforcementLevel.Off,
                "non_admins" => WebhooksRuleLockBranchEnforcementLevel.NonAdmins,
                "everyone" => WebhooksRuleLockBranchEnforcementLevel.Everyone,
                _ => null,
            };
        }
    }
}