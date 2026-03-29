//HintName: G.Models.CreateComputeInstanceResponseInstanceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of compute instance (GPU configuration)<br/>
    /// Example: gpu_1x_h100_sxm5
    /// </summary>
    public enum CreateComputeInstanceResponseInstanceType
    {
        /// <summary>
        /// 
        /// </summary>
        Gpu1xH100Sxm5,
        /// <summary>
        /// 
        /// </summary>
        Gpu8xH100Sxm5,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateComputeInstanceResponseInstanceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateComputeInstanceResponseInstanceType value)
        {
            return value switch
            {
                CreateComputeInstanceResponseInstanceType.Gpu1xH100Sxm5 => "gpu_1x_h100_sxm5",
                CreateComputeInstanceResponseInstanceType.Gpu8xH100Sxm5 => "gpu_8x_h100_sxm5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateComputeInstanceResponseInstanceType? ToEnum(string value)
        {
            return value switch
            {
                "gpu_1x_h100_sxm5" => CreateComputeInstanceResponseInstanceType.Gpu1xH100Sxm5,
                "gpu_8x_h100_sxm5" => CreateComputeInstanceResponseInstanceType.Gpu8xH100Sxm5,
                _ => null,
            };
        }
    }
}