//HintName: G.Models.WebhooksRuleLockBranchEnforcementLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enforcement level of the branch lock setting. `off` means the branch is not locked, `non_admins` means the branch is read-only for non_admins, and `everyone` means the branch is read-only for everyone.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksRuleLockBranchEnforcementLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="everyone")]
        Everyone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="non_admins")]
        NonAdmins,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="off")]
        Off,
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
                WebhooksRuleLockBranchEnforcementLevel.Everyone => "everyone",
                WebhooksRuleLockBranchEnforcementLevel.NonAdmins => "non_admins",
                WebhooksRuleLockBranchEnforcementLevel.Off => "off",
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
                "everyone" => WebhooksRuleLockBranchEnforcementLevel.Everyone,
                "non_admins" => WebhooksRuleLockBranchEnforcementLevel.NonAdmins,
                "off" => WebhooksRuleLockBranchEnforcementLevel.Off,
                _ => null,
            };
        }
    }
}