//HintName: G.Models.BinaryQuantizationEncoding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BinaryQuantizationEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        OneAndHalfBits,
        /// <summary>
        /// 
        /// </summary>
        OneBit,
        /// <summary>
        /// 
        /// </summary>
        TwoBits,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BinaryQuantizationEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BinaryQuantizationEncoding value)
        {
            return value switch
            {
                BinaryQuantizationEncoding.OneAndHalfBits => "one_and_half_bits",
                BinaryQuantizationEncoding.OneBit => "one_bit",
                BinaryQuantizationEncoding.TwoBits => "two_bits",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BinaryQuantizationEncoding? ToEnum(string value)
        {
            return value switch
            {
                "one_and_half_bits" => BinaryQuantizationEncoding.OneAndHalfBits,
                "one_bit" => BinaryQuantizationEncoding.OneBit,
                "two_bits" => BinaryQuantizationEncoding.TwoBits,
                _ => null,
            };
        }
    }
}