//HintName: G.Models.CustomModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category the most accurately reflects the model.<br/>
    /// Default Value: GENERAL
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CustomModelType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GENERAL")]
        GENERAL,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BUILDINGS")]
        BUILDINGS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CHARACTERS")]
        CHARACTERS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ENVIRONMENTS")]
        ENVIRONMENTS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FASHION")]
        FASHION,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ILLUSTRATIONS")]
        ILLUSTRATIONS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GAME_ITEMS")]
        GAMEITEMS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GRAPHICAL_ELEMENTS")]
        GRAPHICALELEMENTS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PHOTOGRAPHY")]
        PHOTOGRAPHY,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PIXEL_ART")]
        PIXELART,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PRODUCT_DESIGN")]
        PRODUCTDESIGN,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TEXTURES")]
        TEXTURES,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UI_ELEMENTS")]
        UIELEMENTS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VECTOR")]
        VECTOR,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomModelType value)
        {
            return value switch
            {
                CustomModelType.GENERAL => "GENERAL",
                CustomModelType.BUILDINGS => "BUILDINGS",
                CustomModelType.CHARACTERS => "CHARACTERS",
                CustomModelType.ENVIRONMENTS => "ENVIRONMENTS",
                CustomModelType.FASHION => "FASHION",
                CustomModelType.ILLUSTRATIONS => "ILLUSTRATIONS",
                CustomModelType.GAMEITEMS => "GAME_ITEMS",
                CustomModelType.GRAPHICALELEMENTS => "GRAPHICAL_ELEMENTS",
                CustomModelType.PHOTOGRAPHY => "PHOTOGRAPHY",
                CustomModelType.PIXELART => "PIXEL_ART",
                CustomModelType.PRODUCTDESIGN => "PRODUCT_DESIGN",
                CustomModelType.TEXTURES => "TEXTURES",
                CustomModelType.UIELEMENTS => "UI_ELEMENTS",
                CustomModelType.VECTOR => "VECTOR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomModelType? ToEnum(string value)
        {
            return value switch
            {
                "GENERAL" => CustomModelType.GENERAL,
                "BUILDINGS" => CustomModelType.BUILDINGS,
                "CHARACTERS" => CustomModelType.CHARACTERS,
                "ENVIRONMENTS" => CustomModelType.ENVIRONMENTS,
                "FASHION" => CustomModelType.FASHION,
                "ILLUSTRATIONS" => CustomModelType.ILLUSTRATIONS,
                "GAME_ITEMS" => CustomModelType.GAMEITEMS,
                "GRAPHICAL_ELEMENTS" => CustomModelType.GRAPHICALELEMENTS,
                "PHOTOGRAPHY" => CustomModelType.PHOTOGRAPHY,
                "PIXEL_ART" => CustomModelType.PIXELART,
                "PRODUCT_DESIGN" => CustomModelType.PRODUCTDESIGN,
                "TEXTURES" => CustomModelType.TEXTURES,
                "UI_ELEMENTS" => CustomModelType.UIELEMENTS,
                "VECTOR" => CustomModelType.VECTOR,
                _ => null,
            };
        }
    }
}