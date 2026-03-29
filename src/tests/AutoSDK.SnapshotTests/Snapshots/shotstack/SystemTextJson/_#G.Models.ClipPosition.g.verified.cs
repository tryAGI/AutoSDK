//HintName: G.Models.ClipPosition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Place the asset in one of nine predefined positions of the viewport. This is most effective for when the asset is scaled and you want to position the element to a specific position. &lt;ul&gt;<br/>
    ///   &lt;li&gt;`top` - top (center)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`topRight` - top right&lt;/li&gt;<br/>
    ///   &lt;li&gt;`right` - right (center)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`bottomRight` - bottom right&lt;/li&gt;<br/>
    ///   &lt;li&gt;`bottom` - bottom (center)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`bottomLeft` - bottom left&lt;/li&gt;<br/>
    ///   &lt;li&gt;`left` - left (center)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`topLeft` - top left&lt;/li&gt;<br/>
    ///   &lt;li&gt;`center` - center&lt;/li&gt;<br/>
    /// &lt;/ul&gt;
    /// </summary>
    public enum ClipPosition
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
        Center,
        /// <summary>
        /// 
        /// </summary>
        Left,
        /// <summary>
        /// 
        /// </summary>
        Right,
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
    public static class ClipPositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipPosition value)
        {
            return value switch
            {
                ClipPosition.Bottom => "bottom",
                ClipPosition.BottomLeft => "bottomLeft",
                ClipPosition.BottomRight => "bottomRight",
                ClipPosition.Center => "center",
                ClipPosition.Left => "left",
                ClipPosition.Right => "right",
                ClipPosition.Top => "top",
                ClipPosition.TopLeft => "topLeft",
                ClipPosition.TopRight => "topRight",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipPosition? ToEnum(string value)
        {
            return value switch
            {
                "bottom" => ClipPosition.Bottom,
                "bottomLeft" => ClipPosition.BottomLeft,
                "bottomRight" => ClipPosition.BottomRight,
                "center" => ClipPosition.Center,
                "left" => ClipPosition.Left,
                "right" => ClipPosition.Right,
                "top" => ClipPosition.Top,
                "topLeft" => ClipPosition.TopLeft,
                "topRight" => ClipPosition.TopRight,
                _ => null,
            };
        }
    }
}