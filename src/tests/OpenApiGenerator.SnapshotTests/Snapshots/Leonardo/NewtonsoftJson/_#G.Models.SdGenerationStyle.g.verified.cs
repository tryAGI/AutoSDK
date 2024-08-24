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
        ANIME,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BOKEH")]
        BOKEH,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CINEMATIC")]
        CINEMATIC,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CINEMATIC_CLOSEUP")]
        CINEMATICCLOSEUP,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CREATIVE")]
        CREATIVE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DYNAMIC")]
        DYNAMIC,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ENVIRONMENT")]
        ENVIRONMENT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FASHION")]
        FASHION,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILM")]
        FILM,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FOOD")]
        FOOD,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GENERAL")]
        GENERAL,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HDR")]
        HDR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ILLUSTRATION")]
        ILLUSTRATION,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LEONARDO")]
        LEONARDO,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LONG_EXPOSURE")]
        LONGEXPOSURE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MACRO")]
        MACRO,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MINIMALISTIC")]
        MINIMALISTIC,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MONOCHROME")]
        MONOCHROME,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MOODY")]
        MOODY,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NONE")]
        NONE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NEUTRAL")]
        NEUTRAL,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PHOTOGRAPHY")]
        PHOTOGRAPHY,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PORTRAIT")]
        PORTRAIT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RAYTRACED")]
        RAYTRACED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RENDER_3D")]
        RENDER3D,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RETRO")]
        RETRO,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SKETCH_BW")]
        SKETCHBW,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SKETCH_COLOR")]
        SKETCHCOLOR,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STOCK_PHOTO")]
        STOCKPHOTO,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIBRANT")]
        VIBRANT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UNPROCESSED")]
        UNPROCESSED,
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
                SdGenerationStyle.ANIME => "ANIME",
                SdGenerationStyle.BOKEH => "BOKEH",
                SdGenerationStyle.CINEMATIC => "CINEMATIC",
                SdGenerationStyle.CINEMATICCLOSEUP => "CINEMATIC_CLOSEUP",
                SdGenerationStyle.CREATIVE => "CREATIVE",
                SdGenerationStyle.DYNAMIC => "DYNAMIC",
                SdGenerationStyle.ENVIRONMENT => "ENVIRONMENT",
                SdGenerationStyle.FASHION => "FASHION",
                SdGenerationStyle.FILM => "FILM",
                SdGenerationStyle.FOOD => "FOOD",
                SdGenerationStyle.GENERAL => "GENERAL",
                SdGenerationStyle.HDR => "HDR",
                SdGenerationStyle.ILLUSTRATION => "ILLUSTRATION",
                SdGenerationStyle.LEONARDO => "LEONARDO",
                SdGenerationStyle.LONGEXPOSURE => "LONG_EXPOSURE",
                SdGenerationStyle.MACRO => "MACRO",
                SdGenerationStyle.MINIMALISTIC => "MINIMALISTIC",
                SdGenerationStyle.MONOCHROME => "MONOCHROME",
                SdGenerationStyle.MOODY => "MOODY",
                SdGenerationStyle.NONE => "NONE",
                SdGenerationStyle.NEUTRAL => "NEUTRAL",
                SdGenerationStyle.PHOTOGRAPHY => "PHOTOGRAPHY",
                SdGenerationStyle.PORTRAIT => "PORTRAIT",
                SdGenerationStyle.RAYTRACED => "RAYTRACED",
                SdGenerationStyle.RENDER3D => "RENDER_3D",
                SdGenerationStyle.RETRO => "RETRO",
                SdGenerationStyle.SKETCHBW => "SKETCH_BW",
                SdGenerationStyle.SKETCHCOLOR => "SKETCH_COLOR",
                SdGenerationStyle.STOCKPHOTO => "STOCK_PHOTO",
                SdGenerationStyle.VIBRANT => "VIBRANT",
                SdGenerationStyle.UNPROCESSED => "UNPROCESSED",
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
                "ANIME" => SdGenerationStyle.ANIME,
                "BOKEH" => SdGenerationStyle.BOKEH,
                "CINEMATIC" => SdGenerationStyle.CINEMATIC,
                "CINEMATIC_CLOSEUP" => SdGenerationStyle.CINEMATICCLOSEUP,
                "CREATIVE" => SdGenerationStyle.CREATIVE,
                "DYNAMIC" => SdGenerationStyle.DYNAMIC,
                "ENVIRONMENT" => SdGenerationStyle.ENVIRONMENT,
                "FASHION" => SdGenerationStyle.FASHION,
                "FILM" => SdGenerationStyle.FILM,
                "FOOD" => SdGenerationStyle.FOOD,
                "GENERAL" => SdGenerationStyle.GENERAL,
                "HDR" => SdGenerationStyle.HDR,
                "ILLUSTRATION" => SdGenerationStyle.ILLUSTRATION,
                "LEONARDO" => SdGenerationStyle.LEONARDO,
                "LONG_EXPOSURE" => SdGenerationStyle.LONGEXPOSURE,
                "MACRO" => SdGenerationStyle.MACRO,
                "MINIMALISTIC" => SdGenerationStyle.MINIMALISTIC,
                "MONOCHROME" => SdGenerationStyle.MONOCHROME,
                "MOODY" => SdGenerationStyle.MOODY,
                "NONE" => SdGenerationStyle.NONE,
                "NEUTRAL" => SdGenerationStyle.NEUTRAL,
                "PHOTOGRAPHY" => SdGenerationStyle.PHOTOGRAPHY,
                "PORTRAIT" => SdGenerationStyle.PORTRAIT,
                "RAYTRACED" => SdGenerationStyle.RAYTRACED,
                "RENDER_3D" => SdGenerationStyle.RENDER3D,
                "RETRO" => SdGenerationStyle.RETRO,
                "SKETCH_BW" => SdGenerationStyle.SKETCHBW,
                "SKETCH_COLOR" => SdGenerationStyle.SKETCHCOLOR,
                "STOCK_PHOTO" => SdGenerationStyle.STOCKPHOTO,
                "VIBRANT" => SdGenerationStyle.VIBRANT,
                "UNPROCESSED" => SdGenerationStyle.UNPROCESSED,
                _ => null,
            };
        }
    }
}