//HintName: G.Models.CaptionStyleHorizontalPlacementModelAlign.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleHorizontalPlacementModelAlign
    {
        /// <summary>
        /// 
        /// </summary>
        Center,
        /// <summary>
        /// 
        /// </summary>
        Left,
        /// <summary>
        /// 
        /// </summary>
        Right,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionStyleHorizontalPlacementModelAlignExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleHorizontalPlacementModelAlign value)
        {
            return value switch
            {
                CaptionStyleHorizontalPlacementModelAlign.Center => "center",
                CaptionStyleHorizontalPlacementModelAlign.Left => "left",
                CaptionStyleHorizontalPlacementModelAlign.Right => "right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleHorizontalPlacementModelAlign? ToEnum(string value)
        {
            return value switch
            {
                "center" => CaptionStyleHorizontalPlacementModelAlign.Center,
                "left" => CaptionStyleHorizontalPlacementModelAlign.Left,
                "right" => CaptionStyleHorizontalPlacementModelAlign.Right,
                _ => null,
            };
        }
    }
}