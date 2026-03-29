//HintName: G.Models.RouterOpenRouterModelQuantization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RouterOpenRouterModelQuantization
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RouterOpenRouterModelQuantizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RouterOpenRouterModelQuantization value)
        {
            return value switch
            {
                RouterOpenRouterModelQuantization.Bf16 => "bf16",
                RouterOpenRouterModelQuantization.Fp16 => "fp16",
                RouterOpenRouterModelQuantization.Fp32 => "fp32",
                RouterOpenRouterModelQuantization.Fp4 => "fp4",
                RouterOpenRouterModelQuantization.Fp6 => "fp6",
                RouterOpenRouterModelQuantization.Fp8 => "fp8",
                RouterOpenRouterModelQuantization.Int4 => "int4",
                RouterOpenRouterModelQuantization.Int8 => "int8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RouterOpenRouterModelQuantization? ToEnum(string value)
        {
            return value switch
            {
                "bf16" => RouterOpenRouterModelQuantization.Bf16,
                "fp16" => RouterOpenRouterModelQuantization.Fp16,
                "fp32" => RouterOpenRouterModelQuantization.Fp32,
                "fp4" => RouterOpenRouterModelQuantization.Fp4,
                "fp6" => RouterOpenRouterModelQuantization.Fp6,
                "fp8" => RouterOpenRouterModelQuantization.Fp8,
                "int4" => RouterOpenRouterModelQuantization.Int4,
                "int8" => RouterOpenRouterModelQuantization.Int8,
                _ => null,
            };
        }
    }
}