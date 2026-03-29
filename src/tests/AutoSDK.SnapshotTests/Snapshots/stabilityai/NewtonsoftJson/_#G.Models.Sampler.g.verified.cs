//HintName: G.Models.Sampler.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Which sampler to use for the diffusion process. If this value is omitted we'll automatically select an appropriate sampler for you.<br/>
    /// Example: K_DPM_2_ANCESTRAL
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Sampler
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DDIM")]
        Ddim,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DDPM")]
        Ddpm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="K_DPMPP_2M")]
        KDpmpp2m,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="K_DPMPP_2S_ANCESTRAL")]
        KDpmpp2sAncestral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="K_DPM_2")]
        KDpm2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="K_DPM_2_ANCESTRAL")]
        KDpm2Ancestral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="K_EULER")]
        KEuler,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="K_EULER_ANCESTRAL")]
        KEulerAncestral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="K_HEUN")]
        KHeun,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="K_LMS")]
        KLms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SamplerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Sampler value)
        {
            return value switch
            {
                Sampler.Ddim => "DDIM",
                Sampler.Ddpm => "DDPM",
                Sampler.KDpmpp2m => "K_DPMPP_2M",
                Sampler.KDpmpp2sAncestral => "K_DPMPP_2S_ANCESTRAL",
                Sampler.KDpm2 => "K_DPM_2",
                Sampler.KDpm2Ancestral => "K_DPM_2_ANCESTRAL",
                Sampler.KEuler => "K_EULER",
                Sampler.KEulerAncestral => "K_EULER_ANCESTRAL",
                Sampler.KHeun => "K_HEUN",
                Sampler.KLms => "K_LMS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Sampler? ToEnum(string value)
        {
            return value switch
            {
                "DDIM" => Sampler.Ddim,
                "DDPM" => Sampler.Ddpm,
                "K_DPMPP_2M" => Sampler.KDpmpp2m,
                "K_DPMPP_2S_ANCESTRAL" => Sampler.KDpmpp2sAncestral,
                "K_DPM_2" => Sampler.KDpm2,
                "K_DPM_2_ANCESTRAL" => Sampler.KDpm2Ancestral,
                "K_EULER" => Sampler.KEuler,
                "K_EULER_ANCESTRAL" => Sampler.KEulerAncestral,
                "K_HEUN" => Sampler.KHeun,
                "K_LMS" => Sampler.KLms,
                _ => null,
            };
        }
    }
}