//HintName: G.Models.CoordOrigin.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CoordOrigin.
    /// </summary>
    public enum CoordOrigin
    {
        /// <summary>
        /// 
        /// </summary>
        Bottomleft,
        /// <summary>
        /// 
        /// </summary>
        Topleft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CoordOriginExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CoordOrigin value)
        {
            return value switch
            {
                CoordOrigin.Bottomleft => "BOTTOMLEFT",
                CoordOrigin.Topleft => "TOPLEFT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CoordOrigin? ToEnum(string value)
        {
            return value switch
            {
                "BOTTOMLEFT" => CoordOrigin.Bottomleft,
                "TOPLEFT" => CoordOrigin.Topleft,
                _ => null,
            };
        }
    }
}