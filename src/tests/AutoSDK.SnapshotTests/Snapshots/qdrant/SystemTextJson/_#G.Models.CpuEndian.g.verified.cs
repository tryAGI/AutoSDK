//HintName: G.Models.CpuEndian.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CpuEndian
    {
        /// <summary>
        /// 
        /// </summary>
        Big,
        /// <summary>
        /// 
        /// </summary>
        Little,
        /// <summary>
        /// 
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CpuEndianExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CpuEndian value)
        {
            return value switch
            {
                CpuEndian.Big => "big",
                CpuEndian.Little => "little",
                CpuEndian.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CpuEndian? ToEnum(string value)
        {
            return value switch
            {
                "big" => CpuEndian.Big,
                "little" => CpuEndian.Little,
                "other" => CpuEndian.Other,
                _ => null,
            };
        }
    }
}