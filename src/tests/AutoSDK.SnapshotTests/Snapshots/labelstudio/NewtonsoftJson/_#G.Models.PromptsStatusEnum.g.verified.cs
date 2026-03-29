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
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptsStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Adala not connected")]
        AdalaNotConnected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Cloud license per organization disabled")]
        CloudLicensePerOrganizationDisabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Disabled for this organization [FF]")]
        DisabledForThisOrganizationff,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Enabled")]
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Expired")]
        Expired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="On-premise global license disabled")]
        OnPremiseGlobalLicenseDisabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
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