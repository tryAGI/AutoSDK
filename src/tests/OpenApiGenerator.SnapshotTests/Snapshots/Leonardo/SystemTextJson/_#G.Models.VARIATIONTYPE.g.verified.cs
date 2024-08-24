//HintName: G.Models.VARIATIONTYPE.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of variation.
    /// </summary>
    public enum VARIATIONTYPE
    {
        /// <summary>
        /// 
        /// </summary>
        OUTPAINT,
        /// <summary>
        /// 
        /// </summary>
        INPAINT,
        /// <summary>
        /// 
        /// </summary>
        UPSCALE,
        /// <summary>
        /// 
        /// </summary>
        UNZOOM,
        /// <summary>
        /// 
        /// </summary>
        NOBG,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VARIATIONTYPEExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VARIATIONTYPE value)
        {
            return value switch
            {
                VARIATIONTYPE.OUTPAINT => "OUTPAINT",
                VARIATIONTYPE.INPAINT => "INPAINT",
                VARIATIONTYPE.UPSCALE => "UPSCALE",
                VARIATIONTYPE.UNZOOM => "UNZOOM",
                VARIATIONTYPE.NOBG => "NOBG",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VARIATIONTYPE? ToEnum(string value)
        {
            return value switch
            {
                "OUTPAINT" => VARIATIONTYPE.OUTPAINT,
                "INPAINT" => VARIATIONTYPE.INPAINT,
                "UPSCALE" => VARIATIONTYPE.UPSCALE,
                "UNZOOM" => VARIATIONTYPE.UNZOOM,
                "NOBG" => VARIATIONTYPE.NOBG,
                _ => null,
            };
        }
    }
}