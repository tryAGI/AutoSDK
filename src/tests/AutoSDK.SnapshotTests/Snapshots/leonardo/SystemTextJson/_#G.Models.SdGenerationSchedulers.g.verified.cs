//HintName: G.Models.SdGenerationSchedulers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The scheduler to generate images with. Defaults to EULER_DISCRETE if not specified.
    /// </summary>
    public enum SdGenerationSchedulers
    {
        /// <summary>
        /// 
        /// </summary>
        Klms,
        /// <summary>
        /// 
        /// </summary>
        EulerAncestralDiscrete,
        /// <summary>
        /// 
        /// </summary>
        EulerDiscrete,
        /// <summary>
        /// 
        /// </summary>
        Ddim,
        /// <summary>
        /// 
        /// </summary>
        DpmSolver,
        /// <summary>
        /// 
        /// </summary>
        Pndm,
        /// <summary>
        /// 
        /// </summary>
        Leonardo,
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
                SdGenerationSchedulers.Klms => "KLMS",
                SdGenerationSchedulers.EulerAncestralDiscrete => "EULER_ANCESTRAL_DISCRETE",
                SdGenerationSchedulers.EulerDiscrete => "EULER_DISCRETE",
                SdGenerationSchedulers.Ddim => "DDIM",
                SdGenerationSchedulers.DpmSolver => "DPM_SOLVER",
                SdGenerationSchedulers.Pndm => "PNDM",
                SdGenerationSchedulers.Leonardo => "LEONARDO",
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
                "KLMS" => SdGenerationSchedulers.Klms,
                "EULER_ANCESTRAL_DISCRETE" => SdGenerationSchedulers.EulerAncestralDiscrete,
                "EULER_DISCRETE" => SdGenerationSchedulers.EulerDiscrete,
                "DDIM" => SdGenerationSchedulers.Ddim,
                "DPM_SOLVER" => SdGenerationSchedulers.DpmSolver,
                "PNDM" => SdGenerationSchedulers.Pndm,
                "LEONARDO" => SdGenerationSchedulers.Leonardo,
                _ => null,
            };
        }
    }
}