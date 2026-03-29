//HintName: G.Models.CreateComputeInstanceResponseSector.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sector identifier for instance placement within the region (if applicable)<br/>
    /// Example: sector_1
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateComputeInstanceResponseSector
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
    public static class CreateComputeInstanceResponseSectorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateComputeInstanceResponseSector value)
        {
            return value switch
            {
                CreateComputeInstanceResponseSector.Sector1 => "sector_1",
                CreateComputeInstanceResponseSector.Sector2 => "sector_2",
                CreateComputeInstanceResponseSector.Sector3 => "sector_3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateComputeInstanceResponseSector? ToEnum(string value)
        {
            return value switch
            {
                "sector_1" => CreateComputeInstanceResponseSector.Sector1,
                "sector_2" => CreateComputeInstanceResponseSector.Sector2,
                "sector_3" => CreateComputeInstanceResponseSector.Sector3,
                _ => null,
            };
        }
    }
}