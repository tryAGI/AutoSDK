//HintName: G.Models.Quantization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Quantization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bf16")]
        Bf16,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fp16")]
        Fp16,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fp32")]
        Fp32,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fp4")]
        Fp4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fp6")]
        Fp6,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fp8")]
        Fp8,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="int4")]
        Int4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="int8")]
        Int8,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unknown")]
        Unknown,
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
                Quantization.Bf16 => "bf16",
                Quantization.Fp16 => "fp16",
                Quantization.Fp32 => "fp32",
                Quantization.Fp4 => "fp4",
                Quantization.Fp6 => "fp6",
                Quantization.Fp8 => "fp8",
                Quantization.Int4 => "int4",
                Quantization.Int8 => "int8",
                Quantization.Unknown => "unknown",
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
                "bf16" => Quantization.Bf16,
                "fp16" => Quantization.Fp16,
                "fp32" => Quantization.Fp32,
                "fp4" => Quantization.Fp4,
                "fp6" => Quantization.Fp6,
                "fp8" => Quantization.Fp8,
                "int4" => Quantization.Int4,
                "int8" => Quantization.Int8,
                "unknown" => Quantization.Unknown,
                _ => null,
            };
        }
    }
}