//HintName: G.Models.VariationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of variation.
    /// </summary>
    public enum VariationType
    {
        /// <summary>
        /// 
        /// </summary>
        Outpaint,
        /// <summary>
        /// 
        /// </summary>
        Inpaint,
        /// <summary>
        /// 
        /// </summary>
        Upscale,
        /// <summary>
        /// 
        /// </summary>
        Unzoom,
        /// <summary>
        /// 
        /// </summary>
        Nobg,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VariationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VariationType value)
        {
            return value switch
            {
                VariationType.Outpaint => "OUTPAINT",
                VariationType.Inpaint => "INPAINT",
                VariationType.Upscale => "UPSCALE",
                VariationType.Unzoom => "UNZOOM",
                VariationType.Nobg => "NOBG",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VariationType? ToEnum(string value)
        {
            return value switch
            {
                "OUTPAINT" => VariationType.Outpaint,
                "INPAINT" => VariationType.Inpaint,
                "UPSCALE" => VariationType.Upscale,
                "UNZOOM" => VariationType.Unzoom,
                "NOBG" => VariationType.Nobg,
                _ => null,
            };
        }
    }
}