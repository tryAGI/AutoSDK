//HintName: G.Models.CpuEndian.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CpuEndian
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="big")]
        Big,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="little")]
        Little,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="other")]
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