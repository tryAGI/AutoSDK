//HintName: G.Models.CaptionStyleVerticalPlacementModelAlign.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleVerticalPlacementModelAlign
    {
        /// <summary>
        /// 
        /// </summary>
        Top,
        /// <summary>
        /// 
        /// </summary>
        Center,
        /// <summary>
        /// 
        /// </summary>
        Bottom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionStyleVerticalPlacementModelAlignExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleVerticalPlacementModelAlign value)
        {
            return value switch
            {
                CaptionStyleVerticalPlacementModelAlign.Top => "top",
                CaptionStyleVerticalPlacementModelAlign.Center => "center",
                CaptionStyleVerticalPlacementModelAlign.Bottom => "bottom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleVerticalPlacementModelAlign? ToEnum(string value)
        {
            return value switch
            {
                "top" => CaptionStyleVerticalPlacementModelAlign.Top,
                "center" => CaptionStyleVerticalPlacementModelAlign.Center,
                "bottom" => CaptionStyleVerticalPlacementModelAlign.Bottom,
                _ => null,
            };
        }
    }
}