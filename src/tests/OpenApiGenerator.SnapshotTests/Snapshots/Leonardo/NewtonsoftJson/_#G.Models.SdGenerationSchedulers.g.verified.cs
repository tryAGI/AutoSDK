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
        [global::System.Runtime.Serialization.EnumMember(Value="KLMS")]
        KLMS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EULER_ANCESTRAL_DISCRETE")]
        EULERANCESTRALDISCRETE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EULER_DISCRETE")]
        EULERDISCRETE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DDIM")]
        DDIM,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DPM_SOLVER")]
        DPMSOLVER,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PNDM")]
        PNDM,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LEONARDO")]
        LEONARDO,
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
                SdGenerationSchedulers.KLMS => "KLMS",
                SdGenerationSchedulers.EULERANCESTRALDISCRETE => "EULER_ANCESTRAL_DISCRETE",
                SdGenerationSchedulers.EULERDISCRETE => "EULER_DISCRETE",
                SdGenerationSchedulers.DDIM => "DDIM",
                SdGenerationSchedulers.DPMSOLVER => "DPM_SOLVER",
                SdGenerationSchedulers.PNDM => "PNDM",
                SdGenerationSchedulers.LEONARDO => "LEONARDO",
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
                "KLMS" => SdGenerationSchedulers.KLMS,
                "EULER_ANCESTRAL_DISCRETE" => SdGenerationSchedulers.EULERANCESTRALDISCRETE,
                "EULER_DISCRETE" => SdGenerationSchedulers.EULERDISCRETE,
                "DDIM" => SdGenerationSchedulers.DDIM,
                "DPM_SOLVER" => SdGenerationSchedulers.DPMSOLVER,
                "PNDM" => SdGenerationSchedulers.PNDM,
                "LEONARDO" => SdGenerationSchedulers.LEONARDO,
                _ => null,
            };
        }
    }
}