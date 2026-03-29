//HintName: G.Models.PromptsStatusEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `Enabled` - Enabled<br/>
    /// * `Cloud license per organization disabled` - Cloud license per organization disabled<br/>
    /// * `On-premise global license disabled` - On-premise global license disabled<br/>
    /// * `Expired` - Expired<br/>
    /// * `Adala not connected` - Adala not connected<br/>
    /// * `Disabled for this organization [FF]` - Disabled for this organization [FF]<br/>
    /// * `unknown` - unknown
    /// </summary>
    public enum PromptsStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        AdalaNotConnected,
        /// <summary>
        /// 
        /// </summary>
        CloudLicensePerOrganizationDisabled,
        /// <summary>
        /// 
        /// </summary>
        DisabledForThisOrganizationff,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        OnPremiseGlobalLicenseDisabled,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptsStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptsStatusEnum value)
        {
            return value switch
            {
                PromptsStatusEnum.AdalaNotConnected => "Adala not connected",
                PromptsStatusEnum.CloudLicensePerOrganizationDisabled => "Cloud license per organization disabled",
                PromptsStatusEnum.DisabledForThisOrganizationff => "Disabled for this organization [FF]",
                PromptsStatusEnum.Enabled => "Enabled",
                PromptsStatusEnum.Expired => "Expired",
                PromptsStatusEnum.OnPremiseGlobalLicenseDisabled => "On-premise global license disabled",
                PromptsStatusEnum.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptsStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "Adala not connected" => PromptsStatusEnum.AdalaNotConnected,
                "Cloud license per organization disabled" => PromptsStatusEnum.CloudLicensePerOrganizationDisabled,
                "Disabled for this organization [FF]" => PromptsStatusEnum.DisabledForThisOrganizationff,
                "Enabled" => PromptsStatusEnum.Enabled,
                "Expired" => PromptsStatusEnum.Expired,
                "On-premise global license disabled" => PromptsStatusEnum.OnPremiseGlobalLicenseDisabled,
                "unknown" => PromptsStatusEnum.Unknown,
                _ => null,
            };
        }
    }
}