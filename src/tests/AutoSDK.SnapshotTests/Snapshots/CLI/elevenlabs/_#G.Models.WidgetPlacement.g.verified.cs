//HintName: G.Models.WidgetPlacement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WidgetPlacement
    {
        /// <summary>
        /// 
        /// </summary>
        TopLeft,
        /// <summary>
        /// 
        /// </summary>
        Top,
        /// <summary>
        /// 
        /// </summary>
        TopRight,
        /// <summary>
        /// 
        /// </summary>
        BottomLeft,
        /// <summary>
        /// 
        /// </summary>
        Bottom,
        /// <summary>
        /// 
        /// </summary>
        BottomRight,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WidgetPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WidgetPlacement value)
        {
            return value switch
            {
                WidgetPlacement.TopLeft => "top-left",
                WidgetPlacement.Top => "top",
                WidgetPlacement.TopRight => "top-right",
                WidgetPlacement.BottomLeft => "bottom-left",
                WidgetPlacement.Bottom => "bottom",
                WidgetPlacement.BottomRight => "bottom-right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WidgetPlacement? ToEnum(string value)
        {
            return value switch
            {
                "top-left" => WidgetPlacement.TopLeft,
                "top" => WidgetPlacement.Top,
                "top-right" => WidgetPlacement.TopRight,
                "bottom-left" => WidgetPlacement.BottomLeft,
                "bottom" => WidgetPlacement.Bottom,
                "bottom-right" => WidgetPlacement.BottomRight,
                _ => null,
            };
        }
    }
}