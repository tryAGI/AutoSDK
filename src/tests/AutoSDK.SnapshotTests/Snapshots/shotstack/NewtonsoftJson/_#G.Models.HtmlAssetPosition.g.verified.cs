//HintName: G.Models.HtmlAssetPosition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Place the HTML in one of nine predefined positions within the HTML area. &lt;ul&gt;<br/>
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
    [global::System.Runtime.Serialization.DataContract]
    public enum HtmlAssetPosition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bottom")]
        Bottom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bottomLeft")]
        BottomLeft,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bottomRight")]
        BottomRight,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="center")]
        Center,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="left")]
        Left,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="right")]
        Right,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="top")]
        Top,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="topLeft")]
        TopLeft,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="topRight")]
        TopRight,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HtmlAssetPositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HtmlAssetPosition value)
        {
            return value switch
            {
                HtmlAssetPosition.Bottom => "bottom",
                HtmlAssetPosition.BottomLeft => "bottomLeft",
                HtmlAssetPosition.BottomRight => "bottomRight",
                HtmlAssetPosition.Center => "center",
                HtmlAssetPosition.Left => "left",
                HtmlAssetPosition.Right => "right",
                HtmlAssetPosition.Top => "top",
                HtmlAssetPosition.TopLeft => "topLeft",
                HtmlAssetPosition.TopRight => "topRight",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HtmlAssetPosition? ToEnum(string value)
        {
            return value switch
            {
                "bottom" => HtmlAssetPosition.Bottom,
                "bottomLeft" => HtmlAssetPosition.BottomLeft,
                "bottomRight" => HtmlAssetPosition.BottomRight,
                "center" => HtmlAssetPosition.Center,
                "left" => HtmlAssetPosition.Left,
                "right" => HtmlAssetPosition.Right,
                "top" => HtmlAssetPosition.Top,
                "topLeft" => HtmlAssetPosition.TopLeft,
                "topRight" => HtmlAssetPosition.TopRight,
                _ => null,
            };
        }
    }
}