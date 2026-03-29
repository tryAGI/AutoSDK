//HintName: G.Models.GetComputeInstanceResponseSector.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sector identifier for instance placement within the region (if applicable)<br/>
    /// Example: sector_1
    /// </summary>
    public enum GetComputeInstanceResponseSector
    {
        /// <summary>
        /// 
        /// </summary>
        Sector1,
        /// <summary>
        /// 
        /// </summary>
        Sector2,
        /// <summary>
        /// 
        /// </summary>
        Sector3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetComputeInstanceResponseSectorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetComputeInstanceResponseSector value)
        {
            return value switch
            {
                GetComputeInstanceResponseSector.Sector1 => "sector_1",
                GetComputeInstanceResponseSector.Sector2 => "sector_2",
                GetComputeInstanceResponseSector.Sector3 => "sector_3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetComputeInstanceResponseSector? ToEnum(string value)
        {
            return value switch
            {
                "sector_1" => GetComputeInstanceResponseSector.Sector1,
                "sector_2" => GetComputeInstanceResponseSector.Sector2,
                "sector_3" => GetComputeInstanceResponseSector.Sector3,
                _ => null,
            };
        }
    }
}