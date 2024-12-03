//HintName: G.Models.LcmGenerationStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The style to generate LCM images with.
    /// </summary>
    public enum LcmGenerationStyle
    {
        /// <summary>
        /// 
        /// </summary>
        ANIME,
        /// <summary>
        /// 
        /// </summary>
        CINEMATIC,
        /// <summary>
        /// 
        /// </summary>
        DIGITALART,
        /// <summary>
        /// 
        /// </summary>
        DYNAMIC,
        /// <summary>
        /// 
        /// </summary>
        ENVIRONMENT,
        /// <summary>
        /// 
        /// </summary>
        FANTASYART,
        /// <summary>
        /// 
        /// </summary>
        ILLUSTRATION,
        /// <summary>
        /// 
        /// </summary>
        PHOTOGRAPHY,
        /// <summary>
        /// 
        /// </summary>
        RENDER3D,
        /// <summary>
        /// 
        /// </summary>
        RAYTRACED,
        /// <summary>
        /// 
        /// </summary>
        SKETCHBW,
        /// <summary>
        /// 
        /// </summary>
        SKETCHCOLOR,
        /// <summary>
        /// 
        /// </summary>
        VIBRANT,
        /// <summary>
        /// 
        /// </summary>
        NONE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LcmGenerationStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LcmGenerationStyle value)
        {
            return value switch
            {
                LcmGenerationStyle.ANIME => "ANIME",
                LcmGenerationStyle.CINEMATIC => "CINEMATIC",
                LcmGenerationStyle.DIGITALART => "DIGITAL_ART",
                LcmGenerationStyle.DYNAMIC => "DYNAMIC",
                LcmGenerationStyle.ENVIRONMENT => "ENVIRONMENT",
                LcmGenerationStyle.FANTASYART => "FANTASY_ART",
                LcmGenerationStyle.ILLUSTRATION => "ILLUSTRATION",
                LcmGenerationStyle.PHOTOGRAPHY => "PHOTOGRAPHY",
                LcmGenerationStyle.RENDER3D => "RENDER_3D",
                LcmGenerationStyle.RAYTRACED => "RAYTRACED",
                LcmGenerationStyle.SKETCHBW => "SKETCH_BW",
                LcmGenerationStyle.SKETCHCOLOR => "SKETCH_COLOR",
                LcmGenerationStyle.VIBRANT => "VIBRANT",
                LcmGenerationStyle.NONE => "NONE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LcmGenerationStyle? ToEnum(string value)
        {
            return value switch
            {
                "ANIME" => LcmGenerationStyle.ANIME,
                "CINEMATIC" => LcmGenerationStyle.CINEMATIC,
                "DIGITAL_ART" => LcmGenerationStyle.DIGITALART,
                "DYNAMIC" => LcmGenerationStyle.DYNAMIC,
                "ENVIRONMENT" => LcmGenerationStyle.ENVIRONMENT,
                "FANTASY_ART" => LcmGenerationStyle.FANTASYART,
                "ILLUSTRATION" => LcmGenerationStyle.ILLUSTRATION,
                "PHOTOGRAPHY" => LcmGenerationStyle.PHOTOGRAPHY,
                "RENDER_3D" => LcmGenerationStyle.RENDER3D,
                "RAYTRACED" => LcmGenerationStyle.RAYTRACED,
                "SKETCH_BW" => LcmGenerationStyle.SKETCHBW,
                "SKETCH_COLOR" => LcmGenerationStyle.SKETCHCOLOR,
                "VIBRANT" => LcmGenerationStyle.VIBRANT,
                "NONE" => LcmGenerationStyle.NONE,
                _ => null,
            };
        }
    }
}