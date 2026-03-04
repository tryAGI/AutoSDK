//HintName: G.Models.TenantActivityStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// activity status of the tenant's shard. Optional for creating tenant (implicit `ACTIVE`) and required for updating tenant. For creation, allowed values are `ACTIVE` - tenant is fully active and `INACTIVE` - tenant is inactive; no actions can be performed on tenant, tenant's files are stored locally. For updating, `ACTIVE`, `INACTIVE` and also `OFFLOADED` - as INACTIVE, but files are stored on cloud storage. The following values are read-only and are set by the server for internal use: `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
    /// </summary>
    public enum TenantActivityStatus
    {
        /// <summary>
        /// `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        Active,
        /// <summary>
        /// `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        Inactive,
        /// <summary>
        /// `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        Offloaded,
        /// <summary>
        /// `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        Offloading,
        /// <summary>
        /// `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        Onloading,
        /// <summary>
        /// `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        Hot,
        /// <summary>
        /// `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        Cold,
        /// <summary>
        /// `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        Frozen,
        /// <summary>
        /// `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        Freezing,
        /// <summary>
        /// `OFFLOADING` - tenant is transitioning from ACTIVE/INACTIVE to OFFLOADED, `ONLOADING` - tenant is transitioning from OFFLOADED to ACTIVE/INACTIVE. We still accept deprecated names `HOT` (now `ACTIVE`), `COLD` (now `INACTIVE`), `FROZEN` (now `OFFLOADED`), `FREEZING` (now `OFFLOADING`), `UNFREEZING` (now `ONLOADING`).
        /// </summary>
        Unfreezing,
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
                TenantActivityStatus.Active => "ACTIVE",
                TenantActivityStatus.Inactive => "INACTIVE",
                TenantActivityStatus.Offloaded => "OFFLOADED",
                TenantActivityStatus.Offloading => "OFFLOADING",
                TenantActivityStatus.Onloading => "ONLOADING",
                TenantActivityStatus.Hot => "HOT",
                TenantActivityStatus.Cold => "COLD",
                TenantActivityStatus.Frozen => "FROZEN",
                TenantActivityStatus.Freezing => "FREEZING",
                TenantActivityStatus.Unfreezing => "UNFREEZING",
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
                "ACTIVE" => TenantActivityStatus.Active,
                "INACTIVE" => TenantActivityStatus.Inactive,
                "OFFLOADED" => TenantActivityStatus.Offloaded,
                "OFFLOADING" => TenantActivityStatus.Offloading,
                "ONLOADING" => TenantActivityStatus.Onloading,
                "HOT" => TenantActivityStatus.Hot,
                "COLD" => TenantActivityStatus.Cold,
                "FROZEN" => TenantActivityStatus.Frozen,
                "FREEZING" => TenantActivityStatus.Freezing,
                "UNFREEZING" => TenantActivityStatus.Unfreezing,
                _ => null,
            };
        }
    }
}