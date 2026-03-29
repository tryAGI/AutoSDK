//HintName: G.Models.CreateComputeInstanceRequestInstanceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of compute instance to create<br/>
    /// Example: gpu_1x_h100_sxm5
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateComputeInstanceRequestInstanceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpu_1x_h100_sxm5")]
        Gpu1xH100Sxm5,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpu_8x_h100_sxm5")]
        Gpu8xH100Sxm5,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateComputeInstanceRequestInstanceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateComputeInstanceRequestInstanceType value)
        {
            return value switch
            {
                CreateComputeInstanceRequestInstanceType.Gpu1xH100Sxm5 => "gpu_1x_h100_sxm5",
                CreateComputeInstanceRequestInstanceType.Gpu8xH100Sxm5 => "gpu_8x_h100_sxm5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateComputeInstanceRequestInstanceType? ToEnum(string value)
        {
            return value switch
            {
                "gpu_1x_h100_sxm5" => CreateComputeInstanceRequestInstanceType.Gpu1xH100Sxm5,
                "gpu_8x_h100_sxm5" => CreateComputeInstanceRequestInstanceType.Gpu8xH100Sxm5,
                _ => null,
            };
        }
    }
}