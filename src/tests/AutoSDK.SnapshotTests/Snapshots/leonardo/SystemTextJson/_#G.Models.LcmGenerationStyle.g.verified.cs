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
        Anime,
        /// <summary>
        /// 
        /// </summary>
        Cinematic,
        /// <summary>
        /// 
        /// </summary>
        DigitalArt,
        /// <summary>
        /// 
        /// </summary>
        Dynamic,
        /// <summary>
        /// 
        /// </summary>
        Environment,
        /// <summary>
        /// 
        /// </summary>
        FantasyArt,
        /// <summary>
        /// 
        /// </summary>
        Illustration,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Photography,
        /// <summary>
        /// 
        /// </summary>
        Raytraced,
        /// <summary>
        /// 
        /// </summary>
        Render3d,
        /// <summary>
        /// 
        /// </summary>
        SketchBw,
        /// <summary>
        /// 
        /// </summary>
        SketchColor,
        /// <summary>
        /// 
        /// </summary>
        Vibrant,
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
                LcmGenerationStyle.Anime => "ANIME",
                LcmGenerationStyle.Cinematic => "CINEMATIC",
                LcmGenerationStyle.DigitalArt => "DIGITAL_ART",
                LcmGenerationStyle.Dynamic => "DYNAMIC",
                LcmGenerationStyle.Environment => "ENVIRONMENT",
                LcmGenerationStyle.FantasyArt => "FANTASY_ART",
                LcmGenerationStyle.Illustration => "ILLUSTRATION",
                LcmGenerationStyle.None => "NONE",
                LcmGenerationStyle.Photography => "PHOTOGRAPHY",
                LcmGenerationStyle.Raytraced => "RAYTRACED",
                LcmGenerationStyle.Render3d => "RENDER_3D",
                LcmGenerationStyle.SketchBw => "SKETCH_BW",
                LcmGenerationStyle.SketchColor => "SKETCH_COLOR",
                LcmGenerationStyle.Vibrant => "VIBRANT",
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
                "ANIME" => LcmGenerationStyle.Anime,
                "CINEMATIC" => LcmGenerationStyle.Cinematic,
                "DIGITAL_ART" => LcmGenerationStyle.DigitalArt,
                "DYNAMIC" => LcmGenerationStyle.Dynamic,
                "ENVIRONMENT" => LcmGenerationStyle.Environment,
                "FANTASY_ART" => LcmGenerationStyle.FantasyArt,
                "ILLUSTRATION" => LcmGenerationStyle.Illustration,
                "NONE" => LcmGenerationStyle.None,
                "PHOTOGRAPHY" => LcmGenerationStyle.Photography,
                "RAYTRACED" => LcmGenerationStyle.Raytraced,
                "RENDER_3D" => LcmGenerationStyle.Render3d,
                "SKETCH_BW" => LcmGenerationStyle.SketchBw,
                "SKETCH_COLOR" => LcmGenerationStyle.SketchColor,
                "VIBRANT" => LcmGenerationStyle.Vibrant,
                _ => null,
            };
        }
    }
}