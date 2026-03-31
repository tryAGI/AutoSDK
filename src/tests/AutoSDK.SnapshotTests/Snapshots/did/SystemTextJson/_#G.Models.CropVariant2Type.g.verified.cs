//HintName: G.Models.CropVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the crop.
    /// </summary>
    public enum CropVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Rectangle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CropVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CropVariant2Type value)
        {
            return value switch
            {
                CropVariant2Type.Rectangle => "rectangle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CropVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "rectangle" => CropVariant2Type.Rectangle,
                _ => null,
            };
        }
    }
}