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
        Bottom,
        /// <summary>
        /// 
        /// </summary>
        BottomLeft,
        /// <summary>
        /// 
        /// </summary>
        BottomRight,
        /// <summary>
        /// 
        /// </summary>
        Top,
        /// <summary>
        /// 
        /// </summary>
        TopLeft,
        /// <summary>
        /// 
        /// </summary>
        TopRight,
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
                WidgetPlacement.Bottom => "bottom",
                WidgetPlacement.BottomLeft => "bottom-left",
                WidgetPlacement.BottomRight => "bottom-right",
                WidgetPlacement.Top => "top",
                WidgetPlacement.TopLeft => "top-left",
                WidgetPlacement.TopRight => "top-right",
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
                "bottom" => WidgetPlacement.Bottom,
                "bottom-left" => WidgetPlacement.BottomLeft,
                "bottom-right" => WidgetPlacement.BottomRight,
                "top" => WidgetPlacement.Top,
                "top-left" => WidgetPlacement.TopLeft,
                "top-right" => WidgetPlacement.TopRight,
                _ => null,
            };
        }
    }
}