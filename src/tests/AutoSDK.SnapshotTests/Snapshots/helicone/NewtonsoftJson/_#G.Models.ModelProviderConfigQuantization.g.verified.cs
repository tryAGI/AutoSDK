//HintName: G.Models.ModelProviderConfigQuantization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelProviderConfigQuantization
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
        [global::System.Runtime.Serialization.EnumMember(Value="fp4")]
        Fp4,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelProviderConfigQuantizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelProviderConfigQuantization value)
        {
            return value switch
            {
                ModelProviderConfigQuantization.Bf16 => "bf16",
                ModelProviderConfigQuantization.Fp16 => "fp16",
                ModelProviderConfigQuantization.Fp4 => "fp4",
                ModelProviderConfigQuantization.Fp8 => "fp8",
                ModelProviderConfigQuantization.Int4 => "int4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelProviderConfigQuantization? ToEnum(string value)
        {
            return value switch
            {
                "bf16" => ModelProviderConfigQuantization.Bf16,
                "fp16" => ModelProviderConfigQuantization.Fp16,
                "fp4" => ModelProviderConfigQuantization.Fp4,
                "fp8" => ModelProviderConfigQuantization.Fp8,
                "int4" => ModelProviderConfigQuantization.Int4,
                _ => null,
            };
        }
    }
}