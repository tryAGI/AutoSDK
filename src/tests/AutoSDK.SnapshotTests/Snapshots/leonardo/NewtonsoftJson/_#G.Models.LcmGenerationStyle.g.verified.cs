//HintName: G.Models.LcmGenerationStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The style to generate LCM images with.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LcmGenerationStyle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ANIME")]
        Anime,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CINEMATIC")]
        Cinematic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DIGITAL_ART")]
        DigitalArt,
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
        [global::System.Runtime.Serialization.EnumMember(Value="FANTASY_ART")]
        FantasyArt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ILLUSTRATION")]
        Illustration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NONE")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PHOTOGRAPHY")]
        Photography,
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
        [global::System.Runtime.Serialization.EnumMember(Value="VIBRANT")]
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