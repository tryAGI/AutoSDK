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
        ANIME,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CINEMATIC")]
        CINEMATIC,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DIGITAL_ART")]
        DIGITALART,
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
        [global::System.Runtime.Serialization.EnumMember(Value="FANTASY_ART")]
        FANTASYART,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ILLUSTRATION")]
        ILLUSTRATION,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PHOTOGRAPHY")]
        PHOTOGRAPHY,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RENDER_3D")]
        RENDER3D,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RAYTRACED")]
        RAYTRACED,
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
        [global::System.Runtime.Serialization.EnumMember(Value="VIBRANT")]
        VIBRANT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NONE")]
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