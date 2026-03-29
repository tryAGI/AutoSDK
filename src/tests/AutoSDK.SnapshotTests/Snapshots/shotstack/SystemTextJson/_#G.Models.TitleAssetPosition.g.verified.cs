//HintName: G.Models.TitleAssetPosition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Place the title in one of nine predefined positions of the viewport. &lt;ul&gt;<br/>
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
    public enum TitleAssetPosition
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
    public static class TitleAssetPositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TitleAssetPosition value)
        {
            return value switch
            {
                TitleAssetPosition.Bottom => "bottom",
                TitleAssetPosition.BottomLeft => "bottomLeft",
                TitleAssetPosition.BottomRight => "bottomRight",
                TitleAssetPosition.Center => "center",
                TitleAssetPosition.Left => "left",
                TitleAssetPosition.Right => "right",
                TitleAssetPosition.Top => "top",
                TitleAssetPosition.TopLeft => "topLeft",
                TitleAssetPosition.TopRight => "topRight",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TitleAssetPosition? ToEnum(string value)
        {
            return value switch
            {
                "bottom" => TitleAssetPosition.Bottom,
                "bottomLeft" => TitleAssetPosition.BottomLeft,
                "bottomRight" => TitleAssetPosition.BottomRight,
                "center" => TitleAssetPosition.Center,
                "left" => TitleAssetPosition.Left,
                "right" => TitleAssetPosition.Right,
                "top" => TitleAssetPosition.Top,
                "topLeft" => TitleAssetPosition.TopLeft,
                "topRight" => TitleAssetPosition.TopRight,
                _ => null,
            };
        }
    }
}