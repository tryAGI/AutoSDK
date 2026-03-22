//HintName: G.Models.CustomModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The category the most accurately reflects the model.<br/>
    /// Default Value: GENERAL
    /// </summary>
    public enum CustomModelType
    {
        /// <summary>
        /// 
        /// </summary>
        Buildings,
        /// <summary>
        /// 
        /// </summary>
        Characters,
        /// <summary>
        /// 
        /// </summary>
        Environments,
        /// <summary>
        /// 
        /// </summary>
        Fashion,
        /// <summary>
        /// 
        /// </summary>
        GameItems,
        /// <summary>
        /// 
        /// </summary>
        General,
        /// <summary>
        /// 
        /// </summary>
        GraphicalElements,
        /// <summary>
        /// 
        /// </summary>
        Illustrations,
        /// <summary>
        /// 
        /// </summary>
        Photography,
        /// <summary>
        /// 
        /// </summary>
        PixelArt,
        /// <summary>
        /// 
        /// </summary>
        ProductDesign,
        /// <summary>
        /// 
        /// </summary>
        Textures,
        /// <summary>
        /// 
        /// </summary>
        UiElements,
        /// <summary>
        /// 
        /// </summary>
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
                CustomModelType.Buildings => "BUILDINGS",
                CustomModelType.Characters => "CHARACTERS",
                CustomModelType.Environments => "ENVIRONMENTS",
                CustomModelType.Fashion => "FASHION",
                CustomModelType.GameItems => "GAME_ITEMS",
                CustomModelType.General => "GENERAL",
                CustomModelType.GraphicalElements => "GRAPHICAL_ELEMENTS",
                CustomModelType.Illustrations => "ILLUSTRATIONS",
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
                "BUILDINGS" => CustomModelType.Buildings,
                "CHARACTERS" => CustomModelType.Characters,
                "ENVIRONMENTS" => CustomModelType.Environments,
                "FASHION" => CustomModelType.Fashion,
                "GAME_ITEMS" => CustomModelType.GameItems,
                "GENERAL" => CustomModelType.General,
                "GRAPHICAL_ELEMENTS" => CustomModelType.GraphicalElements,
                "ILLUSTRATIONS" => CustomModelType.Illustrations,
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