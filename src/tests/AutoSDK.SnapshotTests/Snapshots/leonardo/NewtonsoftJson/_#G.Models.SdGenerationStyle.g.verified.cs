//HintName: G.Models.SdGenerationStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The style to generate images with. When photoReal is enabled, refer to the Guide section for a full list. When alchemy is disabled, use LEONARDO or NONE. When alchemy is enabled, use ANIME, CREATIVE, DYNAMIC, ENVIRONMENT, GENERAL, ILLUSTRATION, PHOTOGRAPHY, RAYTRACED, RENDER_3D, SKETCH_BW, SKETCH_COLOR, or NONE.<br/>
    /// Default Value: DYNAMIC
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SdGenerationStyle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ANIME")]
        Anime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BOKEH")]
        Bokeh,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CINEMATIC")]
        Cinematic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CINEMATIC_CLOSEUP")]
        CinematicCloseup,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CREATIVE")]
        Creative,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DYNAMIC")]
        Dynamic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ENVIRONMENT")]
        Environment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FASHION")]
        Fashion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILM")]
        Film,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FOOD")]
        Food,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GENERAL")]
        General,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HDR")]
        Hdr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ILLUSTRATION")]
        Illustration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LEONARDO")]
        Leonardo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LONG_EXPOSURE")]
        LongExposure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MACRO")]
        Macro,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MINIMALISTIC")]
        Minimalistic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MONOCHROME")]
        Monochrome,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MOODY")]
        Moody,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NONE")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NEUTRAL")]
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PHOTOGRAPHY")]
        Photography,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PORTRAIT")]
        Portrait,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RAYTRACED")]
        Raytraced,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RENDER_3D")]
        Render3d,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RETRO")]
        Retro,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SKETCH_BW")]
        SketchBw,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SKETCH_COLOR")]
        SketchColor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STOCK_PHOTO")]
        StockPhoto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIBRANT")]
        Vibrant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNPROCESSED")]
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