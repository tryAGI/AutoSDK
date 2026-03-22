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
        Inpaint,
        /// <summary>
        /// 
        /// </summary>
        Nobg,
        /// <summary>
        /// 
        /// </summary>
        Outpaint,
        /// <summary>
        /// 
        /// </summary>
        Unzoom,
        /// <summary>
        /// 
        /// </summary>
        Upscale,
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
                VariationType.Inpaint => "INPAINT",
                VariationType.Nobg => "NOBG",
                VariationType.Outpaint => "OUTPAINT",
                VariationType.Unzoom => "UNZOOM",
                VariationType.Upscale => "UPSCALE",
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
                "INPAINT" => VariationType.Inpaint,
                "NOBG" => VariationType.Nobg,
                "OUTPAINT" => VariationType.Outpaint,
                "UNZOOM" => VariationType.Unzoom,
                "UPSCALE" => VariationType.Upscale,
                _ => null,
            };
        }
    }
}