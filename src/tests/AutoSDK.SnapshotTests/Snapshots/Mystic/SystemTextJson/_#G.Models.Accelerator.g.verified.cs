//HintName: G.Models.Accelerator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An enumeration.
    /// </summary>
    public enum Accelerator
    {
        /// <summary>
        /// 
        /// </summary>
        NvidiaT4,
        /// <summary>
        /// 
        /// </summary>
        NvidiaA100,
        /// <summary>
        /// 
        /// </summary>
        NvidiaA10080gb,
        /// <summary>
        /// 
        /// </summary>
        NvidiaH100,
        /// <summary>
        /// 
        /// </summary>
        NvidiaL4,
        /// <summary>
        /// 
        /// </summary>
        Cpu,
        /// <summary>
        /// 
        /// </summary>
        NvidiaA1005gb,
        /// <summary>
        /// 
        /// </summary>
        NvidiaA10010gb,
        /// <summary>
        /// 
        /// </summary>
        NvidiaA10020gb,
        /// <summary>
        /// 
        /// </summary>
        NvidiaA10080gb10gb,
        /// <summary>
        /// 
        /// </summary>
        NvidiaA10080gb20gb,
        /// <summary>
        /// 
        /// </summary>
        NvidiaA10080gb40gb,
        /// <summary>
        /// 
        /// </summary>
        NvidiaA10,
        /// <summary>
        /// 
        /// </summary>
        NvidiaA1012gb,
        /// <summary>
        /// 
        /// </summary>
        NvidiaA108gb,
        /// <summary>
        /// 
        /// </summary>
        NvidiaA104gb,
        /// <summary>
        /// 
        /// </summary>
        NvidiaH10010gb,
        /// <summary>
        /// 
        /// </summary>
        NvidiaH10020gb,
        /// <summary>
        /// 
        /// </summary>
        NvidiaH10040gb,
        /// <summary>
        /// 
        /// </summary>
        NvidiaH10080gb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AcceleratorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Accelerator value)
        {
            return value switch
            {
                Accelerator.NvidiaT4 => "nvidia_t4",
                Accelerator.NvidiaA100 => "nvidia_a100",
                Accelerator.NvidiaA10080gb => "nvidia_a100_80gb",
                Accelerator.NvidiaH100 => "nvidia_h100",
                Accelerator.NvidiaL4 => "nvidia_l4",
                Accelerator.Cpu => "cpu",
                Accelerator.NvidiaA1005gb => "nvidia_a100_5gb",
                Accelerator.NvidiaA10010gb => "nvidia_a100_10gb",
                Accelerator.NvidiaA10020gb => "nvidia_a100_20gb",
                Accelerator.NvidiaA10080gb10gb => "nvidia_a100_80gb_10gb",
                Accelerator.NvidiaA10080gb20gb => "nvidia_a100_80gb_20gb",
                Accelerator.NvidiaA10080gb40gb => "nvidia_a100_80gb_40gb",
                Accelerator.NvidiaA10 => "nvidia_a10",
                Accelerator.NvidiaA1012gb => "nvidia_a10_12gb",
                Accelerator.NvidiaA108gb => "nvidia_a10_8gb",
                Accelerator.NvidiaA104gb => "nvidia_a10_4gb",
                Accelerator.NvidiaH10010gb => "nvidia_h100_10gb",
                Accelerator.NvidiaH10020gb => "nvidia_h100_20gb",
                Accelerator.NvidiaH10040gb => "nvidia_h100_40gb",
                Accelerator.NvidiaH10080gb => "nvidia_h100_80gb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Accelerator? ToEnum(string value)
        {
            return value switch
            {
                "nvidia_t4" => Accelerator.NvidiaT4,
                "nvidia_a100" => Accelerator.NvidiaA100,
                "nvidia_a100_80gb" => Accelerator.NvidiaA10080gb,
                "nvidia_h100" => Accelerator.NvidiaH100,
                "nvidia_l4" => Accelerator.NvidiaL4,
                "cpu" => Accelerator.Cpu,
                "nvidia_a100_5gb" => Accelerator.NvidiaA1005gb,
                "nvidia_a100_10gb" => Accelerator.NvidiaA10010gb,
                "nvidia_a100_20gb" => Accelerator.NvidiaA10020gb,
                "nvidia_a100_80gb_10gb" => Accelerator.NvidiaA10080gb10gb,
                "nvidia_a100_80gb_20gb" => Accelerator.NvidiaA10080gb20gb,
                "nvidia_a100_80gb_40gb" => Accelerator.NvidiaA10080gb40gb,
                "nvidia_a10" => Accelerator.NvidiaA10,
                "nvidia_a10_12gb" => Accelerator.NvidiaA1012gb,
                "nvidia_a10_8gb" => Accelerator.NvidiaA108gb,
                "nvidia_a10_4gb" => Accelerator.NvidiaA104gb,
                "nvidia_h100_10gb" => Accelerator.NvidiaH10010gb,
                "nvidia_h100_20gb" => Accelerator.NvidiaH10020gb,
                "nvidia_h100_40gb" => Accelerator.NvidiaH10040gb,
                "nvidia_h100_80gb" => Accelerator.NvidiaH10080gb,
                _ => null,
            };
        }
    }
}