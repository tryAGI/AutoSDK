//HintName: G.Models.SdGenerationStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The style to generate images with. When photoReal is enabled, refer to the Guide section for a full list. When alchemy is disabled, use LEONARDO or NONE. When alchemy is enabled, use ANIME, CREATIVE, DYNAMIC, ENVIRONMENT, GENERAL, ILLUSTRATION, PHOTOGRAPHY, RAYTRACED, RENDER_3D, SKETCH_BW, SKETCH_COLOR, or NONE.<br/>
    /// Default Value: DYNAMIC
    /// </summary>
    public enum SdGenerationStyle
    {
        /// <summary>
        /// 
        /// </summary>
        Anime,
        /// <summary>
        /// 
        /// </summary>
        Bokeh,
        /// <summary>
        /// 
        /// </summary>
        Cinematic,
        /// <summary>
        /// 
        /// </summary>
        CinematicCloseup,
        /// <summary>
        /// 
        /// </summary>
        Creative,
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
        Fashion,
        /// <summary>
        /// 
        /// </summary>
        Film,
        /// <summary>
        /// 
        /// </summary>
        Food,
        /// <summary>
        /// 
        /// </summary>
        General,
        /// <summary>
        /// 
        /// </summary>
        Hdr,
        /// <summary>
        /// 
        /// </summary>
        Illustration,
        /// <summary>
        /// 
        /// </summary>
        Leonardo,
        /// <summary>
        /// 
        /// </summary>
        LongExposure,
        /// <summary>
        /// 
        /// </summary>
        Macro,
        /// <summary>
        /// 
        /// </summary>
        Minimalistic,
        /// <summary>
        /// 
        /// </summary>
        Monochrome,
        /// <summary>
        /// 
        /// </summary>
        Moody,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Photography,
        /// <summary>
        /// 
        /// </summary>
        Portrait,
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
        Retro,
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
        StockPhoto,
        /// <summary>
        /// 
        /// </summary>
        Vibrant,
        /// <summary>
        /// 
        /// </summary>
        Unprocessed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SdGenerationStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SdGenerationStyle value)
        {
            return value switch
            {
                SdGenerationStyle.Anime => "ANIME",
                SdGenerationStyle.Bokeh => "BOKEH",
                SdGenerationStyle.Cinematic => "CINEMATIC",
                SdGenerationStyle.CinematicCloseup => "CINEMATIC_CLOSEUP",
                SdGenerationStyle.Creative => "CREATIVE",
                SdGenerationStyle.Dynamic => "DYNAMIC",
                SdGenerationStyle.Environment => "ENVIRONMENT",
                SdGenerationStyle.Fashion => "FASHION",
                SdGenerationStyle.Film => "FILM",
                SdGenerationStyle.Food => "FOOD",
                SdGenerationStyle.General => "GENERAL",
                SdGenerationStyle.Hdr => "HDR",
                SdGenerationStyle.Illustration => "ILLUSTRATION",
                SdGenerationStyle.Leonardo => "LEONARDO",
                SdGenerationStyle.LongExposure => "LONG_EXPOSURE",
                SdGenerationStyle.Macro => "MACRO",
                SdGenerationStyle.Minimalistic => "MINIMALISTIC",
                SdGenerationStyle.Monochrome => "MONOCHROME",
                SdGenerationStyle.Moody => "MOODY",
                SdGenerationStyle.None => "NONE",
                SdGenerationStyle.Neutral => "NEUTRAL",
                SdGenerationStyle.Photography => "PHOTOGRAPHY",
                SdGenerationStyle.Portrait => "PORTRAIT",
                SdGenerationStyle.Raytraced => "RAYTRACED",
                SdGenerationStyle.Render3d => "RENDER_3D",
                SdGenerationStyle.Retro => "RETRO",
                SdGenerationStyle.SketchBw => "SKETCH_BW",
                SdGenerationStyle.SketchColor => "SKETCH_COLOR",
                SdGenerationStyle.StockPhoto => "STOCK_PHOTO",
                SdGenerationStyle.Vibrant => "VIBRANT",
                SdGenerationStyle.Unprocessed => "UNPROCESSED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SdGenerationStyle? ToEnum(string value)
        {
            return value switch
            {
                "ANIME" => SdGenerationStyle.Anime,
                "BOKEH" => SdGenerationStyle.Bokeh,
                "CINEMATIC" => SdGenerationStyle.Cinematic,
                "CINEMATIC_CLOSEUP" => SdGenerationStyle.CinematicCloseup,
                "CREATIVE" => SdGenerationStyle.Creative,
                "DYNAMIC" => SdGenerationStyle.Dynamic,
                "ENVIRONMENT" => SdGenerationStyle.Environment,
                "FASHION" => SdGenerationStyle.Fashion,
                "FILM" => SdGenerationStyle.Film,
                "FOOD" => SdGenerationStyle.Food,
                "GENERAL" => SdGenerationStyle.General,
                "HDR" => SdGenerationStyle.Hdr,
                "ILLUSTRATION" => SdGenerationStyle.Illustration,
                "LEONARDO" => SdGenerationStyle.Leonardo,
                "LONG_EXPOSURE" => SdGenerationStyle.LongExposure,
                "MACRO" => SdGenerationStyle.Macro,
                "MINIMALISTIC" => SdGenerationStyle.Minimalistic,
                "MONOCHROME" => SdGenerationStyle.Monochrome,
                "MOODY" => SdGenerationStyle.Moody,
                "NONE" => SdGenerationStyle.None,
                "NEUTRAL" => SdGenerationStyle.Neutral,
                "PHOTOGRAPHY" => SdGenerationStyle.Photography,
                "PORTRAIT" => SdGenerationStyle.Portrait,
                "RAYTRACED" => SdGenerationStyle.Raytraced,
                "RENDER_3D" => SdGenerationStyle.Render3d,
                "RETRO" => SdGenerationStyle.Retro,
                "SKETCH_BW" => SdGenerationStyle.SketchBw,
                "SKETCH_COLOR" => SdGenerationStyle.SketchColor,
                "STOCK_PHOTO" => SdGenerationStyle.StockPhoto,
                "VIBRANT" => SdGenerationStyle.Vibrant,
                "UNPROCESSED" => SdGenerationStyle.Unprocessed,
                _ => null,
            };
        }
    }
}