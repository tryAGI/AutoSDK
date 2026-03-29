//HintName: G.Models.BinaryQuantizationQueryEncoding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BinaryQuantizationQueryEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        Binary,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Scalar4bits,
        /// <summary>
        /// 
        /// </summary>
        Scalar8bits,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BinaryQuantizationQueryEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BinaryQuantizationQueryEncoding value)
        {
            return value switch
            {
                BinaryQuantizationQueryEncoding.Binary => "binary",
                BinaryQuantizationQueryEncoding.Default => "default",
                BinaryQuantizationQueryEncoding.Scalar4bits => "scalar4bits",
                BinaryQuantizationQueryEncoding.Scalar8bits => "scalar8bits",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BinaryQuantizationQueryEncoding? ToEnum(string value)
        {
            return value switch
            {
                "binary" => BinaryQuantizationQueryEncoding.Binary,
                "default" => BinaryQuantizationQueryEncoding.Default,
                "scalar4bits" => BinaryQuantizationQueryEncoding.Scalar4bits,
                "scalar8bits" => BinaryQuantizationQueryEncoding.Scalar8bits,
                _ => null,
            };
        }
    }
}