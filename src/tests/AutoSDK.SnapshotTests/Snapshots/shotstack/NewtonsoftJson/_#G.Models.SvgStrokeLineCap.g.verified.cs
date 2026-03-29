//HintName: G.Models.SvgStrokeLineCap.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The shape at the end of open paths (lines, polylines, unclosed paths).<br/>
    /// &lt;ul&gt;<br/>
    ///   &lt;li&gt;`butt` - flat edge perpendicular to the line (default)&lt;/li&gt;<br/>
    ///   &lt;li&gt;`round` - semicircular cap extending beyond the endpoint&lt;/li&gt;<br/>
    ///   &lt;li&gt;`square` - rectangular cap extending beyond the endpoint&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Default Value: butt<br/>
    /// Example: round
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SvgStrokeLineCap
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="butt")]
        Butt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="round")]
        Round,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="square")]
        Square,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgStrokeLineCapExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgStrokeLineCap value)
        {
            return value switch
            {
                SvgStrokeLineCap.Butt => "butt",
                SvgStrokeLineCap.Round => "round",
                SvgStrokeLineCap.Square => "square",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgStrokeLineCap? ToEnum(string value)
        {
            return value switch
            {
                "butt" => SvgStrokeLineCap.Butt,
                "round" => SvgStrokeLineCap.Round,
                "square" => SvgStrokeLineCap.Square,
                _ => null,
            };
        }
    }
}