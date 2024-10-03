//HintName: G.Models.TenantActivityStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// activity status of the tenant's shard. Optional for creating tenant (implicit `ACTIVE`) and required for updating tenant. For creation, allowed values are `ACTIVE` - tenant is fully active and `INACTIVE` - tenant is inactive; no actions can be performed on tenant, tenant's files are stored locally. For updating, `ACTIVE`, `INACTIVE` and also `OFFLOADED` - as INACTIVE, but files are stored on cloud storage. The following values are read-only and are set by the server for internal use: `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TenantActivityStatus
    {
        /// <summary>
        /// `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ACTIVE")]
        ACTIVE,
        /// <summary>
        /// `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INACTIVE")]
        INACTIVE,
        /// <summary>
        /// `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OFFLOADED")]
        OFFLOADED,
        /// <summary>
        /// `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OFFLOADING")]
        OFFLOADING,
        /// <summary>
        /// `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ONLOADING")]
        ONLOADING,
        /// <summary>
        /// `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HOT")]
        HOT,
        /// <summary>
        /// `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COLD")]
        COLD,
        /// <summary>
        /// `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FROZEN")]
        FROZEN,
        /// <summary>
        /// `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FREEZING")]
        FREEZING,
        /// <summary>
        /// `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNFREEZING")]
        UNFREEZING,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TenantActivityStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TenantActivityStatus value)
        {
            return value switch
            {
                TenantActivityStatus.ACTIVE => "ACTIVE",
                TenantActivityStatus.INACTIVE => "INACTIVE",
                TenantActivityStatus.OFFLOADED => "OFFLOADED",
                TenantActivityStatus.OFFLOADING => "OFFLOADING",
                TenantActivityStatus.ONLOADING => "ONLOADING",
                TenantActivityStatus.HOT => "HOT",
                TenantActivityStatus.COLD => "COLD",
                TenantActivityStatus.FROZEN => "FROZEN",
                TenantActivityStatus.FREEZING => "FREEZING",
                TenantActivityStatus.UNFREEZING => "UNFREEZING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TenantActivityStatus? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => TenantActivityStatus.ACTIVE,
                "INACTIVE" => TenantActivityStatus.INACTIVE,
                "OFFLOADED" => TenantActivityStatus.OFFLOADED,
                "OFFLOADING" => TenantActivityStatus.OFFLOADING,
                "ONLOADING" => TenantActivityStatus.ONLOADING,
                "HOT" => TenantActivityStatus.HOT,
                "COLD" => TenantActivityStatus.COLD,
                "FROZEN" => TenantActivityStatus.FROZEN,
                "FREEZING" => TenantActivityStatus.FREEZING,
                "UNFREEZING" => TenantActivityStatus.UNFREEZING,
                _ => null,
            };
        }
    }
}