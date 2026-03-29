//HintName: G.Models.CreateComputeInstanceRequestSector.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sector for InfiniBand configuration (only valid with gpu_8x_h100_sxm5)<br/>
    /// Example: sector_1
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateComputeInstanceRequestSector
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sector_1")]
        Sector1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sector_2")]
        Sector2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sector_3")]
        Sector3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateComputeInstanceRequestSectorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateComputeInstanceRequestSector value)
        {
            return value switch
            {
                CreateComputeInstanceRequestSector.Sector1 => "sector_1",
                CreateComputeInstanceRequestSector.Sector2 => "sector_2",
                CreateComputeInstanceRequestSector.Sector3 => "sector_3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateComputeInstanceRequestSector? ToEnum(string value)
        {
            return value switch
            {
                "sector_1" => CreateComputeInstanceRequestSector.Sector1,
                "sector_2" => CreateComputeInstanceRequestSector.Sector2,
                "sector_3" => CreateComputeInstanceRequestSector.Sector3,
                _ => null,
            };
        }
    }
}