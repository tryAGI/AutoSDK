//HintName: G.Models.CropVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the crop.
    /// </summary>
    public enum CropVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Wide,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CropVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CropVariant1Type value)
        {
            return value switch
            {
                CropVariant1Type.Wide => "wide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CropVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "wide" => CropVariant1Type.Wide,
                _ => null,
            };
        }
    }
}