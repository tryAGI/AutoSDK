//HintName: G.Models.OrganizationSecretScanningAlertValidity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The token status as of the latest validity check.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrganizationSecretScanningAlertValidity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inactive")]
        Inactive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationSecretScanningAlertValidityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationSecretScanningAlertValidity value)
        {
            return value switch
            {
                OrganizationSecretScanningAlertValidity.Active => "active",
                OrganizationSecretScanningAlertValidity.Inactive => "inactive",
                OrganizationSecretScanningAlertValidity.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationSecretScanningAlertValidity ToEnum(string value)
        {
            return value switch
            {
                "active" => OrganizationSecretScanningAlertValidity.Active,
                "inactive" => OrganizationSecretScanningAlertValidity.Inactive,
                "unknown" => OrganizationSecretScanningAlertValidity.Unknown,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}