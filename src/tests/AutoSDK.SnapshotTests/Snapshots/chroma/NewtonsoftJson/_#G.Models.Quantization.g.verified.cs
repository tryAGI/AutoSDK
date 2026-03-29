//HintName: G.Models.Quantization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Quantization implementation for SPANN vector index.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Quantization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="four_bit_rabit_q_with_u_search")]
        FourBitRabitQWithUSearch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QuantizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Quantization value)
        {
            return value switch
            {
                Quantization.FourBitRabitQWithUSearch => "four_bit_rabit_q_with_u_search",
                Quantization.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Quantization? ToEnum(string value)
        {
            return value switch
            {
                "four_bit_rabit_q_with_u_search" => Quantization.FourBitRabitQWithUSearch,
                "none" => Quantization.None,
                _ => null,
            };
        }
    }
}