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
        General,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BUILDINGS")]
        Buildings,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CHARACTERS")]
        Characters,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ENVIRONMENTS")]
        Environments,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FASHION")]
        Fashion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ILLUSTRATIONS")]
        Illustrations,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GAME_ITEMS")]
        GameItems,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GRAPHICAL_ELEMENTS")]
        GraphicalElements,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PHOTOGRAPHY")]
        Photography,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PIXEL_ART")]
        PixelArt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PRODUCT_DESIGN")]
        ProductDesign,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TEXTURES")]
        Textures,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="UI_ELEMENTS")]
        UiElements,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VECTOR")]
        Vector,
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
                CustomModelType.General => "GENERAL",
                CustomModelType.Buildings => "BUILDINGS",
                CustomModelType.Characters => "CHARACTERS",
                CustomModelType.Environments => "ENVIRONMENTS",
                CustomModelType.Fashion => "FASHION",
                CustomModelType.Illustrations => "ILLUSTRATIONS",
                CustomModelType.GameItems => "GAME_ITEMS",
                CustomModelType.GraphicalElements => "GRAPHICAL_ELEMENTS",
                CustomModelType.Photography => "PHOTOGRAPHY",
                CustomModelType.PixelArt => "PIXEL_ART",
                CustomModelType.ProductDesign => "PRODUCT_DESIGN",
                CustomModelType.Textures => "TEXTURES",
                CustomModelType.UiElements => "UI_ELEMENTS",
                CustomModelType.Vector => "VECTOR",
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
                "GENERAL" => CustomModelType.General,
                "BUILDINGS" => CustomModelType.Buildings,
                "CHARACTERS" => CustomModelType.Characters,
                "ENVIRONMENTS" => CustomModelType.Environments,
                "FASHION" => CustomModelType.Fashion,
                "ILLUSTRATIONS" => CustomModelType.Illustrations,
                "GAME_ITEMS" => CustomModelType.GameItems,
                "GRAPHICAL_ELEMENTS" => CustomModelType.GraphicalElements,
                "PHOTOGRAPHY" => CustomModelType.Photography,
                "PIXEL_ART" => CustomModelType.PixelArt,
                "PRODUCT_DESIGN" => CustomModelType.ProductDesign,
                "TEXTURES" => CustomModelType.Textures,
                "UI_ELEMENTS" => CustomModelType.UiElements,
                "VECTOR" => CustomModelType.Vector,
                _ => null,
            };
        }
    }
}