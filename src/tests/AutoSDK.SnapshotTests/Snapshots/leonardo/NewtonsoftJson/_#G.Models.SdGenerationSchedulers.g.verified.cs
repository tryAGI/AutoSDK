//HintName: G.Models.SdGenerationSchedulers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The scheduler to generate images with. Defaults to EULER_DISCRETE if not specified.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SdGenerationSchedulers
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DDIM")]
        Ddim,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DPM_SOLVER")]
        DpmSolver,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EULER_ANCESTRAL_DISCRETE")]
        EulerAncestralDiscrete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EULER_DISCRETE")]
        EulerDiscrete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="KLMS")]
        Klms,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LEONARDO")]
        Leonardo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PNDM")]
        Pndm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SdGenerationSchedulersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SdGenerationSchedulers value)
        {
            return value switch
            {
                SdGenerationSchedulers.Ddim => "DDIM",
                SdGenerationSchedulers.DpmSolver => "DPM_SOLVER",
                SdGenerationSchedulers.EulerAncestralDiscrete => "EULER_ANCESTRAL_DISCRETE",
                SdGenerationSchedulers.EulerDiscrete => "EULER_DISCRETE",
                SdGenerationSchedulers.Klms => "KLMS",
                SdGenerationSchedulers.Leonardo => "LEONARDO",
                SdGenerationSchedulers.Pndm => "PNDM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SdGenerationSchedulers? ToEnum(string value)
        {
            return value switch
            {
                "DDIM" => SdGenerationSchedulers.Ddim,
                "DPM_SOLVER" => SdGenerationSchedulers.DpmSolver,
                "EULER_ANCESTRAL_DISCRETE" => SdGenerationSchedulers.EulerAncestralDiscrete,
                "EULER_DISCRETE" => SdGenerationSchedulers.EulerDiscrete,
                "KLMS" => SdGenerationSchedulers.Klms,
                "LEONARDO" => SdGenerationSchedulers.Leonardo,
                "PNDM" => SdGenerationSchedulers.Pndm,
                _ => null,
            };
        }
    }
}