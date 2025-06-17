//HintName: G.Models.WidgetPlacement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WidgetPlacement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="top-left")]
        TopLeft,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="top")]
        Top,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="top-right")]
        TopRight,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bottom-left")]
        BottomLeft,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bottom")]
        Bottom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bottom-right")]
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